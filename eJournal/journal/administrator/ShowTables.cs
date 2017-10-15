using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using JournalLibrary;

namespace journal.administrator
{
    public partial class ShowTables : Form
    {
        private string connectionString;

        public ShowTables()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionDB con = new ConnectionDB();
            con.OpenConnection(connectionString);
            string sql = $"select * from {comboBox1.SelectedItem}";
            dataGridView1.DataSource = con.SelectSQL(sql);
            con.CloseConnection();
        }
    }
}
