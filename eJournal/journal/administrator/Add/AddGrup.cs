using System;
using JournalLibrary;
using System.Windows.Forms;
using System.Configuration;

namespace journal.administrator
{
    public partial class AddGrup : Form
    {
        private string connectionString = null;
        public AddGrup()
        {
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            try
            {
                Grups grups = new Grups();
                grups.OpenConnection(connectionString);
                grups.InsertGrups(name);
                grups.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Группа была успешно добавлена!");
            this.Close();
        }

        private void AddGrup_Load(object sender, EventArgs e)
        {

        }
    }
}
