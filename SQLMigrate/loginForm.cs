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

namespace SQLMigrate
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 1;
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = this.textBox1.Text;
            scsb.InitialCatalog = "master";
            scsb.UserID = this.textBox2.Text;
            scsb.Password = this.textBox3.Text;

            connectionString = scsb.ToString();

            this.Hide();
        }
    }
}
