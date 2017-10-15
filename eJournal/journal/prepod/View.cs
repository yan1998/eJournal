using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JournalLibrary;
using System.Configuration;

namespace journal.prepod
{
    public partial class View : Form
    {
        private string connectionString;

        public View()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
        }

        private void View_Load(object sender, EventArgs e)
        {
            Students s = new Students();
            s.OpenConnection(connectionString);
            comboBox1.Items.AddRange(s.GetAllStudents().Split('\n'));
            s.CloseConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Students s = new Students();
            s.OpenConnection(connectionString);
            People pe = s.GetStudentByFIO(comboBox1.SelectedItem.ToString());
            s.CloseConnection();
            this.label_Fio.Text = pe.surname + " " + pe.name[0] + '.' + pe.patronumic[0];
            this.label_birthday.Text = pe.ConvertDate();
            this.richTextBox_Info.Text = pe.information;
            this.label_Phone.Text = "+38"+pe.phonenumber;
            this.Text = comboBox1.Text;
            pictureBox1.Visible = true;
            label_Fio.Visible = true;
            label_birthday.Visible = true;
            label1.Visible = true;
            richTextBox_Info.Visible = true;
            label_Phone.Visible = true;
        }
    }
}
