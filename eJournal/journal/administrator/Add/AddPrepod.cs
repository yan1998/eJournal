using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using JournalLibrary;
using System.Configuration;

namespace journal.administrator
{
    public partial class AddPrepod : Form
    {
        private string connectionSrting = ConfigurationManager.AppSettings["connectionString"];
        public AddPrepod()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            People prepod = new People();
            prepod.name = textBox_Name.Text;
            prepod.surname = textBox_Surname.Text;
            prepod.patronumic = textBox_Patronumic.Text;
            prepod.login = textBox_Login.Text;
            prepod.birthday = dateTimePicker_Birthday.Value;
            prepod.information = richTextBox_Information.Text;
            try
            {
                Prepods prepods = new Prepods();
                prepods.OpenConnection(connectionSrting);
                prepods.InsertPrepod(prepod);
                prepods.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Преподаватель был успешно добавлен!");
            this.Close();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}
