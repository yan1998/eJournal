using System;
using JournalLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace journal.prepod
{
    public partial class StudentMain : Form
    {
        private int nzach;
        private string connectionString;

        public StudentMain(People s)
        {
            InitializeComponent();
            //звполнения всех полей данными про студента из БД
            this.Text = s.surname + " " + s.name;
            this.label_Fio.Text = s.surname + " " + s.name[0] + '.' + s.patronumic[0];
            this.label_birthday.Text = s.ConvertDate();
            this.richTextBox_Info.Text = s.information;
            this.label_Phone.Text = s.phonenumber;
            Students st = new Students();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            st.OpenConnection(connectionString);
            nzach = st.GetNzachByFIO(s.surname, s.name, s.patronumic);
            st.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewStudent vp = new ViewStudent();
            this.Opacity = 0;
            vp.ShowDialog();

        }

        private void button_Dnevnik_Click(object sender, EventArgs e)
        {
            Dnevnic dn = new Dnevnic(nzach);
            this.Opacity = 0;
            dn.ShowDialog();
        }

        private void button_journal_Click(object sender, EventArgs e)
        {
            View_Journal vj = new View_Journal(nzach);
            this.Opacity = 0;
            vj.ShowDialog();
        }

        private void StudentMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StudentMain_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
