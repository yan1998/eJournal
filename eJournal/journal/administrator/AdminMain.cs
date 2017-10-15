using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace journal.administrator
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void button_AddPrepod_Click(object sender, EventArgs e)
        {
            AddPrepod add = new AddPrepod();
            this.Opacity = 0;
            add.ShowDialog();
        }

        private void button_AddGrup_Click(object sender, EventArgs e)
        {
            AddGrup grup = new AddGrup();
            this.Opacity = 0;
            grup.ShowDialog();
        }

        private void button_AddStudent_Click(object sender, EventArgs e)
        {
            AddStudent student = new AddStudent();
            this.Opacity = 0;
            student.ShowDialog();
        }

        private void button_DeleteGrup_Click(object sender, EventArgs e)
        {
            DeleteGrup grup = new DeleteGrup();
            this.Opacity = 0;
            grup.ShowDialog();
        }
        private void button_DeletePrepod_Click(object sender, EventArgs e)
        {
            DeletePeople prepod = new DeletePeople("prepod");
            this.Opacity = 0;
            prepod.ShowDialog();
        }

        private void button_DeleteStudent_Click(object sender, EventArgs e)
        {
            DeletePeople student = new DeletePeople("student");
            this.Opacity = 0;
            student.ShowDialog();
        }

        private void button_AddPredmet_Click(object sender, EventArgs e)
        {
            AddPredmet predmet = new AddPredmet();
            this.Opacity = 0;
            predmet.ShowDialog();
        }

        private void button_DeletePredmet_Click(object sender, EventArgs e)
        {
            DeletePredmet p = new DeletePredmet();
            this.Opacity = 0;
            p.ShowDialog();
        }

        private void AdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminMain_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void button_ShowTables_Click(object sender, EventArgs e)
        {
            ShowTables s = new ShowTables();
            this.Opacity = 0;
            s.ShowDialog();
        }
    }
}
