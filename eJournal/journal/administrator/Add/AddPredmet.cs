using System;
using System.Configuration;
using System.Collections.Generic;
using JournalLibrary;
using System.Windows.Forms;

namespace journal.administrator
{
    public partial class AddPredmet : Form
    {
        private string connectionString=ConfigurationManager.AppSettings["connectionString"];
        public AddPredmet()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPredmet_Load(object sender, EventArgs e)
        {
            Prepods p = new Prepods();
            p.OpenConnection(connectionString);
            this.comboBox_Prepods.Items.AddRange(p.GetAllPrepods());
            p.CloseConnection();

        }

        private void comboBox_Predmets_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ввод запрещен!");
            e.Handled = true;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" || comboBox_Prepods.Text == "Выберите")
            {
                MessageBox.Show("Повторите ввод!");
                return;
            }
            Predmets p = new Predmets();
            p.OpenConnection(connectionString);
            p.InsertPredmet(textBox_Name.Text,comboBox_Prepods.Text,connectionString);
            p.CloseConnection();
            MessageBox.Show("Предмет был добавлен успешно!");
            this.Close();
        }
    }
}
