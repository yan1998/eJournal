using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using JournalLibrary;

namespace journal.prepod
{
    public partial class Dnevnic : Form
    {
        private string connectionString;
        private int nzach;
        public Dnevnic(int nzach)
        {
            InitializeComponent();
            this.nzach = nzach;
            connectionString = ConfigurationManager.AppSettings["connectionString"];
        }

        private void Dnevnic_Load(object sender, EventArgs e)
        {
            Marks m = new Marks();
            m.OpenConnection(connectionString);
            dataGridView1.DataSource = m.GetMarksByNzachStudent(nzach);
            m.CloseConnection();

            dataGridView1.Columns[1].Width = 55;
            dataGridView1.Columns[2].Width = 65;
            dataGridView1.Columns[3].Width = 210;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            


        }
    }
}
