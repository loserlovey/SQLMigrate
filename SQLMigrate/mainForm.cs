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
using System.IO;

namespace SQLMigrate
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            
            comboBoxSvrType.SelectedIndex = 0;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.currentStep = 1;
            initConnectionForm();
            updateScreenStatus(currentStep);
        }

        private void initConnectionForm()
        {
            comboBoxSvrType.SelectedIndex = 0;
            textBoxIP.Text = ".";
            comboBoxAuthType.SelectedIndex = 0;
        }

        private void updateConnectionStringWithDBName(string databaseName)
        {
            string[] items = this.sourceConnectionString.Split(';');
            items[1] = items[1].Split('=')[0] + "=" + databaseName;
            this.sourceConnectionString = "";
            foreach (var item in items)
            {
                sourceConnectionString += item + ";";
            }
        }

        private string buildConnectionString()
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            if (this.textBoxIP.Text.Length == 0)
            {
                MessageBox.Show("Please enter the Server name or ip");
                this.textBoxIP.Focus();
            }
            scsb.DataSource = this.textBoxIP.Text;
            scsb.InitialCatalog = "master";
            if (this.textBoxUserID.Text.Length == 0)
            {
                MessageBox.Show("Please enter the user name");
                this.textBoxUserID.Focus();
            }
            scsb.UserID = this.textBoxUserID.Text;
            if (this.textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter the password");
                this.textBoxPassword.Focus();
            }
            scsb.Password = this.textBoxPassword.Text;

            return scsb.ToString();
        }

        private void tryConnect(int currentStep)
        {
            SqlConnection sqlConn;
            if (currentStep == 1)
            {
                sqlConn = new SqlConnection(sourceConnectionString);
            }
            else
            {
                sqlConn = new SqlConnection(targetConnectionString);
            }
            try
            {
                sqlConn.Open();
                MessageBox.Show("Connected!");
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

        private void updateScreenStatus(int currentStep)
        {
            if (currentStep == 1)
            {
                panelDataConnection.Visible = true;
                panelDataSource.Visible = false;
                panelMigrate.Visible = false;
                btnPreStep.Enabled = false;
                btnNexStep.Enabled = false;
                this.Text = "SQL Migration Tool - Select Source Server";
            }
            else if (currentStep == 2)
            {
                panelDataConnection.Visible = false;
                panelDataSource.Visible = true;
                panelMigrate.Visible = false;
                btnPreStep.Enabled = true;
                btnNexStep.Enabled = true;
                this.Text = "SQL Migration Tool - Select Source Data";
            }
            else if (currentStep == 3)
            {
                panelDataConnection.Visible = true;
                panelDataSource.Visible = false;
                panelMigrate.Visible = false;
                btnPreStep.Enabled = true;
                btnNexStep.Enabled = false;
                this.Text = "SQL Migration Tool - Select Target Server";
            }
            else if (currentStep == 4)
            {
                panelDataConnection.Visible = false;
                panelDataSource.Visible = false;
                panelMigrate.Visible = true;
                btnPreStep.Enabled = true;
                btnNexStep.Enabled = false;
                this.Text = "SQL Migration Tool - Migration";
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

        private void loadTableList()
        {
            SqlConnection sqlConn = new SqlConnection(this.sourceConnectionString);

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

        private void btnNexStep_Click(object sender, EventArgs e)
        {
            if (currentStep == 1) // source server connection
            {
                loadDatabaseList(this.sourceConnectionString);
                loadTableList();
            }
            else if (currentStep == 3) // target server connection
            {

            }
            currentStep++;
            updateScreenStatus(currentStep);
        }

        private void btnPreStep_Click(object sender, EventArgs e)
        {
            //string tempFile = Path.GetTempFileName();
            //MessageBox.Show(tempFile);

            currentStep--;
            updateScreenStatus(currentStep);
        }

        private void comboBoxSvrType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSvrType.SelectedIndex == 0) //SQl
            {
                comboBoxAuthType.Enabled = true;
                comboBoxAuthType.SelectedIndex = 0;
                textBoxPort.Enabled = false;
            }
            else if (comboBoxSvrType.SelectedIndex == 1) //PostgreSQL
            {
                comboBoxAuthType.Enabled = false;
                textBoxPort.Enabled = true;
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (currentStep == 1)
            {
                this.sourceConnectionString = buildConnectionString();
            }
            else
            {
                this.targetConnectionString = buildConnectionString();
            }
            try
            {
                tryConnect(currentStep);
                this.btnNexStep.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                throw ex;
            }
            
        }
    }
}
