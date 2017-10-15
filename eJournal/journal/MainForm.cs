using System;
using JournalLibrary;
using System.Windows.Forms;
using System.Configuration;

namespace journal
{
    public partial class MainForm : Form
    {
        private string connectionString;//строка подключения

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.AppSettings["connectionString"];// получение строки подключения из конфигурационого файла
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == String.Empty || textBox_Password.Text==String.Empty)
            {
                MessageBox.Show("Вы не ввели логин или пароль\n","Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            switch (comboBox_Choice.Text)   // выбор типа профиля
            {
                case "Администратор":
                    if (textBox_Login.Text == "admin" && textBox_Password.Text == "admin")
                    {
                        administrator.AdminMain admin = new administrator.AdminMain();
                        this.Opacity = 0;
                        admin.ShowDialog();
                    }
                    else
                        MessageBox.Show("Вы ввели неверный логин или пароль\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "Студент":
                    try
                    {
                        Students s = new Students();// создание объекта студента
                        s.OpenConnection(connectionString);//открытие соединения
                        People student = s.Autorization(textBox_Login.Text, textBox_Password.Text);// получение инфы о студенте
                        if (textBox_Password.Text == "12345")// если пароль стандартный- то происходит его изменение
                        {
                            NewPasswordDialog newpas = new NewPasswordDialog(this);
                            newpas.ShowDialog();
                            s.ChangeNewPassword(textBox_Login.Text, label_NewPas.Text);//запись нового пароля в бд
                        }
                        prepod.StudentMain form = new prepod.StudentMain(student);
                        s.CloseConnection();// закрытие соединения
                        this.Opacity = 0;
                        form.ShowDialog();
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Преподаватель":
                    try
                    {
                        Prepods p = new Prepods();
                        p.OpenConnection(connectionString);
                        People prepod = p.Autorization(textBox_Login.Text, textBox_Password.Text);
                        if (textBox_Password.Text == "12345")
                        {
                            NewPasswordDialog newpas = new NewPasswordDialog(this);
                            newpas.ShowDialog();
                            p.ChangeNewPassword(textBox_Login.Text,label_NewPas.Text); //запись нового пароля в бд
                        }
                        prepod.PrepodMain form = new prepod.PrepodMain(prepod);
                        p.CloseConnection();
                        this.Opacity = 0;
                        form.ShowDialog();
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    MessageBox.Show("Вы не выбрали тип профиля\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void comboBox_Choice_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ввод запрещен!");
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
