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
    public partial class View_Journal : Form
    {
        private string connectionString;
        private int nzach;
        public View_Journal(int nzach)
        {
            InitializeComponent();
            this.nzach = nzach;
            connectionString = ConfigurationManager.AppSettings["connectionString"];
        }

        private void View_Journal_Load(object sender, EventArgs e)
        {
            
            Predmets pr = new Predmets();
            pr.OpenConnection(connectionString);
            comboBox1.Items.AddRange(pr.GetPredmetsByNzach(nzach));
            pr.CloseConnection();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grups g = new Grups();
            g.OpenConnection(connectionString);
            int idgr = g.GetIdByNzach(nzach);
            g.CloseConnection();
            Predmets p = new Predmets();
            p.OpenConnection(connectionString);
            int idprd = p.GetIdByName(comboBox1.Text);
            p.CloseConnection();
            Marks m = new Marks();
            m.OpenConnection(connectionString);
            dataGridView1.DataSource = m.GetMarksByGroupAndPredmet(idgr,idprd);
            m.CloseConnection();
        }
    }
}
