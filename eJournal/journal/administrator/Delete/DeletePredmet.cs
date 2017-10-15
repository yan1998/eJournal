using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using JournalLibrary;

namespace journal.administrator
{
    public partial class DeletePredmet : Form
    {
        private string connectionString;

        public DeletePredmet()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            Predmets p = new Predmets();
            p.OpenConnection(connectionString);
            comboBox1.Items.AddRange(p.GetAllPredmets());
            p.CloseConnection();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Выберите предмет")
            {
                MessageBox.Show("Вы не предмет!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Predmets p = new Predmets();
            int idprd=-1;
            try
            {
                p.OpenConnection(connectionString);
                idprd = p.GetIdByName(comboBox1.Text);
                p.DeletePredmet(comboBox1.Text);
                p.CloseConnection();
            }
            catch (SqlException ex)
            {
                DialogResult result = MessageBox.Show("Невозможно удалить предмет!\nВ журнале присутствуют оценки!\nУдалить все оценки?", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Marks m = new Marks();
                    m.OpenConnection(connectionString);
                    m.DeleteMarksByPredmetId(idprd);
                    m.CloseConnection();
                    p.DeletePredmet(comboBox1.Text);
                    MessageBox.Show("Предмет был успешно удален!");
                }
                p.CloseConnection();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Предмет был успешно удален!");
            this.Close();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ввод запрещен!");
            e.Handled = true;
        }
    }
}
