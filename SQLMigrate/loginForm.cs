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

namespace SQLMigrate
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            loadConfigFile();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter the SQl Server name");
                textBox1.Focus();
            }
            scsb.DataSource = this.textBox1.Text;
            scsb.InitialCatalog = "master";
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Please enter the user name");
                textBox2.Focus();
            }
            scsb.UserID = this.textBox2.Text;
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Please enter the password");
                textBox3.Focus();
            }
            scsb.Password = this.textBox3.Text;

            connectionString = scsb.ToString();

            SqlConnection sqlConn = new SqlConnection(connectionString);
            try
            {
                sqlConn.Open();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (textBox1.Text.Length == 0)
                {
                    MessageBox.Show("Please enter the SQl Server name...");
                }
                else
                {
                    comboBox1.Focus();
                }
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (textBox2.Text.Length == 0)
                {
                    MessageBox.Show("Please enter the user name");
                }
                else
                {
                    textBox3.Focus();
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (textBox3.Text.Length == 0)
                {
                    MessageBox.Show("Please enter the password");
                }
                else
                {
                    connectBtn.Focus();
                }
            }
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            exitFlag = 1;
        }

        private void loginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void loadConfigFile()
        {
            string runmode = ConfigurationManager.AppSettings["runmode"];
            if (runmode == "0")
            {
                textBox1.Text = ".";
                textBox2.Text = "sa";
                textBox3.Text = "TestAdmin123";
            }

            comboBox1.Items.Add("Windows Authentication");
            comboBox1.Items.Add("SQL Server Authentication");
            comboBox1.SelectedIndex = 1;
        }
    }
}
