using System;
using System.Data.SqlClient;
using System.Configuration;
using JournalLibrary;
using System.Windows.Forms;

namespace journal.administrator
{
    public partial class DeleteGrup : Form
    {
        private Grups grups;
        private string connectionString;
        public DeleteGrup()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            grups = new Grups();
            grups.OpenConnection(connectionString);
            this.comboBox_Grups.Items.AddRange(grups.GetAllGrups());
            grups.CloseConnection();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (this.comboBox_Grups.Text == "Выберите группу")
            {
                MessageBox.Show("Выберите группу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                grups.OpenConnection(connectionString);
                grups.DeleteGrup(this.comboBox_Grups.Text);
                grups.CloseConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("В данной группе находятся студенты!\nСначала необходимо удалить всех студентов!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grups.CloseConnection();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                grups.CloseConnection();
                return;
            }
            MessageBox.Show("Группа была успешно удалена!");
            this.Close();
        }

        private void comboBox_Grups_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ввод запрещён!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            e.Handled = true;
        }
    }
}
