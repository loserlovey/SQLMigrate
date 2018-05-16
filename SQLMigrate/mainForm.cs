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
            loadDatabaseList(loginForm.connectionString);
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
