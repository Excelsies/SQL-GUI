using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLGUIProject
{
    public partial class ServerLookup : Form
    {

        List<SQLGUI.Common.SQLServer> servers;
        DataTable table = new DataTable();
        BindingSource bs = new BindingSource();


        public ServerLookup(List<SQLGUI.Common.SQLServer> s)
        {
            InitializeComponent();

            if (Properties.Settings.Default.customThemeSet)
                themeClass.customTheme(this);//Sets the custom theme for the form

            table.Columns.Add("Database");
            table.Columns.Add("SQL Server");

            servers = s;
            pullServersAndDBs();
        }

        private void pullServersAndDBs()
        {
            table.Clear();
            foreach (var server in servers)
            {
                SqlConnection myConnection;

                //sets up the connection to the database
                if (!server.WindowsAuthentication)
                {
                    myConnection = new SqlConnection("user id=" + server.ServerCredentials[0] +
                                                   ";password=" + server.ServerCredentials[1] + ";server=" + server.ServerName +
                                                   ";connection timeout=3");
                }
                else
                {
                    myConnection = new SqlConnection("server=" + server.ServerName + "; Integrated Security=SSPI; connection timeout=3");

                }

                using (myConnection)
                {
                    myConnection.Open();

                    // Set up a command with the given query and associate
                    // this with the current connection.
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", myConnection))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                table.Rows.Add(dr[0].ToString(), server.ServerName);
                            }
                        }
                    }
                    myConnection.Close();
                }


            }

            bs.DataSource = table;

            dbServerGrid.DataSource = bs;
        }

        private void filterTxtBx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //filterTxtBx dbServerGrid
                bs.Filter = string.Format("Database LIKE '%{0}%'", filterTxtBx.Text);
            }
            catch (Exception)
            {

            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            pullServersAndDBs();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the Form
        }

        private void dbServerGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dbServerGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
