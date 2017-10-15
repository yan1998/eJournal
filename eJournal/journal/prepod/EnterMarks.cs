using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using JournalLibrary;

namespace journal.prepod
{
    public partial class EnterMarks : Form
    {
        private int kolst = 0;
        private string connectionString;
        private int id;
        private Dictionary<int, People> d;

        public EnterMarks(int id)
        {
            InitializeComponent();
            this.id = id;
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            Predmets pr = new Predmets();
            pr.OpenConnection(connectionString);
            comboBox_Predmet.Items.AddRange(pr.GetPredmetsByPrepodId(id));
            pr.CloseConnection();
            Grups g = new Grups();
            g.OpenConnection(connectionString);
            comboBox_Group.Items.AddRange(g.GetAllGrups());
            g.CloseConnection();
        }

        private void comboBox_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            Students st = new Students();
            st.OpenConnection(connectionString);
            d = new Dictionary<int, People>();
            d = st.GetStudentsInGroup((string)comboBox_Group.SelectedItem);
            st.CloseConnection();
            int i = 105, j = 1 ;
            foreach (var item in d)
            {
                if (this.Controls.ContainsKey("l"+j))
                    this.Controls.RemoveByKey("l"+j);
                Label l = new Label();
                l.Name = "l" + j;
                l.Text = item.Value.ToString();
                l.Width = 200;
                l.Location = new Point(20,i);
                l.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
                if (this.Controls.ContainsKey("t" + j))
                    this.Controls.RemoveByKey("t" + j);
                /* TextBox t = new TextBox();
                 t.Name = "t"+j;
                 t.Location = new Point(230, i);
                 t.Width = 30;
                 t.MaxLength = 1;
                 t.KeyPress += Preverka;*/
                ComboBox c = new ComboBox();
                c.Name="t" + j;
                c.Location = new Point(230, i);
                c.Width = 35;
                c.Items.AddRange(new string[] {"н","о","1","2","3","4","5"});
                c.KeyPress += C_KeyPress;
                i += 30;
                j++;
                this.Controls.Add(l);
                this.Controls.Add(c);
            }
            for (int z = j; z <= kolst; z++)
            {
                this.Controls.RemoveByKey("l" + z);
                this.Controls.RemoveByKey("t" + z);
            }
            kolst = --j;
        }

        private void C_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ввод запрещен!");
            e.Handled = true;
        }

        /*
       private void Preverka(object sender, KeyPressEventArgs e)
       {
           TextBox t = (TextBox)sender;
           if(e.KeyChar!='1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar!= '5' && e.KeyChar != 'н' && e.KeyChar!='п' && e.KeyChar!=(Char)Keys.Back)
               e.Handled = true;
       }
       */
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_Group.Text == "Выберите группу" || comboBox_Predmet.Text== "Выберите предмет")
            {
                MessageBox.Show("Выберите группу и предмет!","Ошибка!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            DateTime date = DateTime.Now;
            Predmets pr = new Predmets();
            pr.OpenConnection(connectionString);
            int idprd = pr.GetIdByName(comboBox_Predmet.Text);
            pr.CloseConnection();
            Marks m = new Marks();
            int j = 1;
            m.OpenConnection(connectionString);
            foreach (var item in d)
            {
                if (this.Controls["t" + j].Text=="")
                    continue;
                int nzach = item.Key;
                char mark = this.Controls["t"+j].Text[0];
                m.InsertMark(nzach, id, idprd, mark, date);
                j++;
            }
            m.CloseConnection();
            MessageBox.Show("Оценки были успешно сохранены!");
            this.Close();
        }

        private void EnterMarks_Load(object sender, EventArgs e)
        {

        }
    }
}