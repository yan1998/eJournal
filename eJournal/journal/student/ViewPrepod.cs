using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JournalLibrary;

namespace journal.prepod
{
    public partial class ViewStudent : Form
    {
        private string connectionString = null;

        public ViewStudent()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
        }
        
        private void ViewPrepod_Load(object sender, EventArgs e)
        {
            Prepods p = new Prepods();
            p.OpenConnection(connectionString);
            comboBox1.Items.AddRange(p.GetAllPrepods());
            p.CloseConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prepods p = new Prepods();
            p.OpenConnection(connectionString);
            People pe = p.GetPrepodByFIO(comboBox1.SelectedItem.ToString());
            int idprep = p.GetIdByFIO(pe.name,pe.surname,pe.patronumic);
            p.CloseConnection();
            this.label_Fio.Text = pe.surname + " " + pe.name[0] + '.' + pe.patronumic[0];
            this.label_birthday.Text = pe.ConvertDate();
            this.richTextBox_Info.Text = pe.information;
            Predmets pr = new Predmets();
            pr.OpenConnection(connectionString);
            this.richTextBox1.Text = "";
            this.richTextBox1.Text = String.Join("\n",pr.GetPredmetsByPrepodId(idprep));
            pr.CloseConnection();
            this.Text = comboBox1.Text;
            pictureBox1.Visible = true;
            label_Fio.Visible = true;
            label_birthday.Visible = true;
            label1.Visible = true;
            richTextBox_Info.Visible = true;
            richTextBox1.Visible = true;
        }
    }
}
