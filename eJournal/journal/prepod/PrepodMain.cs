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
    public partial class PrepodMain : Form
    {
        private string connectionString;
        private int id;

        public PrepodMain(People p)
        {
            InitializeComponent();
            //звполнение данными поля
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            Prepods prep = new Prepods();
            prep.OpenConnection(connectionString);
            id=prep.GetIdByFIO(p.name,p.surname,p.patronumic);
            prep.CloseConnection();
            this.Text = p.surname + " " + p.name;
            this.label_Fio.Text = p.surname + " " + p.name[0] + '.' + p.patronumic[0];
            this.label_birthday.Text = p.ConvertDate();
            this.richTextBox_Info.Text = p.information;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterMarks em = new EnterMarks(id);
            this.Opacity = 0;
            em.ShowDialog();
        }

        private void PrepodMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PrepodMain_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void button_Info_Click(object sender, EventArgs e)
        {
            View v = new View();
            this.Opacity = 0;
            v.ShowDialog();
        }
    }
}
