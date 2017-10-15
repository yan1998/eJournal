using System;
using System.Data.SqlClient;
using JournalLibrary;
using System.Windows.Forms;
using System.Configuration;

namespace journal.administrator
{
    public partial class DeletePeople : Form
    {
        private string mode;
        private string connectionString;

        public DeletePeople(string mode)
        {
            InitializeComponent();
            this.mode = mode;
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            if (mode == "prepod")
            {
                Prepods p = new Prepods();
                p.OpenConnection(connectionString);
                comboBox1.Items.AddRange(p.GetAllPrepods());
                p.CloseConnection();
            }
            else if (mode == "student")
            {
                Students s = new Students();
                s.OpenConnection(connectionString);
                comboBox1.Items.AddRange(s.GetAllStudents().Split('\n'));
                s.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Выберите")
            {
                MessageBox.Show("Вы не выбрали!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] mas = comboBox1.Text.Split(' ');
            string name = mas[1];
            string surname = mas[0];
            string patronumic = mas[2];
            if (mode == "prepod")
            {
                try
                {
                    Prepods prepods = new Prepods();
                    prepods.OpenConnection(connectionString);
                    prepods.DeletePrepodByFIO(name, surname, patronumic);
                    prepods.CloseConnection();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Невозможно удалить преподавателя!\nУдалите сперва предметы, которые он ведет!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Преподователь был успешно удален!");
                this.Close();
            }
            else if (mode == "student")
            {
                try
                {
                    Students students = new Students();
                    students.OpenConnection(connectionString);
                    students.DeleteStudentByFIO(name, surname, patronumic);
                    students.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Студент был успешно удален!");
                this.Close();
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ввод запрещен!");
            e.Handled = true;
        }
    }
}
