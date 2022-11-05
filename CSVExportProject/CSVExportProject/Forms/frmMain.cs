using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CSVExportProject
{
    public partial class frmMain : Form
    {
        string DataSource; //used to save the datasource from the dsnNames
        string InitialCatalog; //used to save the InitialCatalog        
        SQLConnectionClass SQLConnect = new SQLConnectionClass("", "", "", "", false);

        public frmMain()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            cmbDelimiter.SelectedItem = "comma (,)";
            cmbQuoted.SelectedItem = "Yes";
            dgvGridPreview.RowHeadersVisible = false;
            dgvGridPreview.ReadOnly = true;

#if DEBUG
            txtInstance.Text = @"COMPUTER46";
            txtDatabase.Text = @"Database";
            txtLogin.Text = @"sa";
            txtPassword.Text = @"password";
#endif
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtInstance.Text != "" && txtDatabase.Text != "" && txtLogin.Text != "" && txtPassword.Text != "")
            {
                btnConnect.Enabled = false;
                txtDatabase.Enabled = false;
                txtInstance.Enabled = false;
                txtLogin.Enabled = false;
                txtPassword.Enabled = false;
                ckbxSQL_DirectIP.Enabled = false;
                btnConnect.Text = "Please wait";

                SQLConnect.dataSource = txtInstance.Text;
                SQLConnect.initialCatalog = txtDatabase.Text;
                SQLConnect.userID = txtLogin.Text;
                SQLConnect.password = txtPassword.Text;
                SQLConnect.useIPAdress = ckbxSQL_DirectIP.Checked;

                try
                {
                    DataSource = txtInstance.Text;
                    InitialCatalog = txtDatabase.Text;

                    SqlConnection sqlConnString = new SqlConnection("Data Source=" + SQLConnect.dataSource + ";Initial Catalog=" + SQLConnect.initialCatalog + ";User ID=" + SQLConnect.userID + ";Password=" + SQLConnect.password + ";Connect Timeout = 120;");

                    if (SQLConnect.useIPAdress == true)
                    {
                        IPAddress ip = new IPHelper().get_ip_from_host_name(SQLConnect.dataSource);
                        sqlConnString = new SqlConnection("Data Source=" + ip.ToString() + ";Initial Catalog=" + SQLConnect.initialCatalog + ";User ID=" + SQLConnect.userID + ";Password=" + SQLConnect.password + ";Connect Timeout = 120;");

                        //MessageBox.Show(ip.ToString());
                    }

                    //version
                    SqlDataAdapter read_version = new SqlDataAdapter("select top 1 TABLE_NAME from INFORMATION_SCHEMA.TABLES", sqlConnString);
                    DataTable version_table = new DataTable();

                    sqlConnString.Open();
                    read_version.Fill(version_table);
                    sqlConnString.Close();

                    btnConnect.Text = "Valid";
                    grpExtract.Enabled = true;
                    grpBoxExportType.Enabled = true;
                    version_table.Dispose();

                    //SQLGBSCustomProcess Tables = new SQLGBSCustomProcess();
                    //Tables.CreateTables();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error connecting to database");
                    btnConnect.Enabled = true;
                    btnConnect.Text = "Connect";
                }
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {                       
            btnExtract.Enabled = false;
            //dgvGridPreview.ClearSelect

            if (!txtCommandString.Text.ToUpper().Contains("UPDATE") && !txtCommandString.Text.ToUpper().Contains("DELETE") && !txtCommandString.Text.ToUpper().Contains("INSERT"))
            {
                try
                {
                    DataTable returnTable = new DataTable();
                    string _commandString = txtCommandString.Text;

                    SQLGBSCustomProcess sqlReadData = new SQLGBSCustomProcess();
                    returnTable.Clear();
                    returnTable = sqlReadData.databaseReturnDataTable(txtInstance.Text, txtDatabase.Text, txtLogin.Text, txtPassword.Text, ckbxSQL_DirectIP.Enabled, _commandString);

                    if (chkBoxPreview.Checked == true)
                    {
                        dgvGridPreview.DataSource = returnTable;
                    }

                    else
                    {
                        CSVExportClass exportToFile = new CSVExportClass();

                        exportToFile.Export(returnTable, txtFolder.Text, cmbDelimiter.SelectedItem.ToString(), cmbQuoted.SelectedItem.ToString());
                        MessageBox.Show("Extraction Complete.");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                finally
                {
                    btnExtract.Enabled = true;
                }
            }

            else
            {
                MessageBox.Show("You cannot include \"update\", \"insert\", or \"delete\" in your statement.");
                btnExtract.Enabled = true;
            }
        }
    }
}
