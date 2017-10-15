using System;
using System.Configuration;
using JournalLibrary;
using System.Windows.Forms;

namespace journal.administrator
{
    public partial class AddStudent:Form
    {
        private Grups grups;
        private string connectionString = null;
        public AddStudent()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            grups = new Grups();
            grups.OpenConnection(connectionString);
            comboBox_Grups.Items.AddRange(grups.GetAllGrups());
            grups.CloseConnection();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            People  student= new People();
            student.name = textBox_Name.Text;
            student.surname = textBox_Surname.Text;
            student.patronumic = textBox_Patronumic.Text;
            student.login = textBox_Login.Text;
            student.birthday = dateTimePicker_Birthday.Value;
            student.information = richTextBox_Information.Text;
            student.phonenumber = textBox_PhoneNumber.Text;
            try
            {
                grups.OpenConnection(connectionString);
                students.OpenConnection(connectionString);
                students.InsertStudent(student, grups.GetIdByName(comboBox_Grups.Text));
                students.CloseConnection();
                grups.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Студент был успешно добавлен!\nПароль для первого входа - 12345");
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void comboBox_Grups_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ввод запрещен!");
            e.Handled = true;
        }
    }
}
