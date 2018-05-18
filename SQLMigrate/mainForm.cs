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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var loginForm = new loginForm();
            loginForm.ShowDialog();
            if (loginForm.exitFlag == 1)
            {
                System.Environment.Exit(0);
            }
            this.connectionString = loginForm.connectionString;
            loadDatabaseList(connectionString);
            loadTableList(/*connectionString, this.dbList.SelectedItem.ToString()*/);
        }

        private void updateConnectionStringWithDBName(string databaseName)
        {
            string[] items = this.connectionString.Split(';');
            items[1] = items[1].Split('=')[0] + "=" + databaseName;
            this.connectionString = "";
            foreach (var item in items)
            {
                connectionString += item + ";";
            }
        }

        private void loadDatabaseList(string connectionstring)
        {
            SqlConnection sqlConn = new SqlConnection(connectionstring);
            string sqlString = "select name from sys.databases";
            
            try
            {
                sqlConn.Open();
                SqlCommand sqlComm = new SqlCommand(sqlString, sqlConn);
                SqlDataReader reader = sqlComm.ExecuteReader();
                
                while(reader.Read())
                {
                    dbList.Items.Add(reader.GetValue(0));
                }
                if (dbList.Items.Count > 0)
                {
                    dbList.SelectedIndex = 0;
                }
                this.dbList.SelectedIndexChanged += new System.EventHandler(this.dbList_SelectedIndexChanged);
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

        private void dbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateConnectionStringWithDBName(dbList.SelectedItem.ToString());
            loadTableList();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadTableList()
        {
            SqlConnection sqlConn = new SqlConnection(connectionString);

            try
            {
                sqlConn.Open();
                string sqlString = "select TABLE_NAME from " + dbList.SelectedText + ".INFORMATION_SCHEMA.TABLES";
                SqlCommand sqlComm = new SqlCommand(sqlString, sqlConn);
                SqlDataReader reader = sqlComm.ExecuteReader();
                tableCheckedListBox.Items.Clear();
                while (reader.Read())
                {
                    tableCheckedListBox.Items.Add(reader.GetValue(0));
                }
                if (tableCheckedListBox.Items.Count > 0)
                {
                    tableCheckedListBox.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
