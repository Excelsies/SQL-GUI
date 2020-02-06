using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SQLGUIProject
{
    public partial class QueryTest : Form
    {
        string queryText;
        bool db;
        static string XMLPath = Properties.Settings.Default.PathToXML;
        List<SQLGUIProject.Common.SQLServer> servers = SQLGUIProject.Common.SQLServer.LoadAllFromXML(XMLPath);
        int parameterCount;

        public QueryTest(string query, List<string> parameters, List<string> servers, bool database)
        {
            InitializeComponent();

            if (Properties.Settings.Default.customThemeSet)
                themeClass.customTheme(this);//Sets the custom theme for the form

            queryText = query;
            db = database;
            parameterCount = parameters.Count;

            try
            {
                foreach (string s in servers)
                {
                    uxServersListBox.Items.Add(s);

                }

                if (database)
                    this.uxValueGrid.Rows.Add("Database", "");

                if (parameterCount > 0)
                {
                    for (int i = 0; i < parameterCount; i++)
                    {
                        this.uxValueGrid.Rows.Add(parameters[i], "");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void uxGoButton_Click(object sender, EventArgs e)
        {
            /*
            if (inProgress.uxInProgressMessage())
            {
                uxGoButton_Click(sender, e);
            } //*/

            string database;
            if (!db)
                database = null;
            else
                database = uxValueGrid.Rows[0].Cells[1].Value.ToString();

            List<string> parameters = new List<string>();
            if (parameterCount > 0)
            {
                for (int i = 0; i < parameterCount; i++)
                {
                    if (parameterCount > i && db)
                        parameters.Add(uxValueGrid.Rows[i + 1].Cells[1].Value.ToString());
                    else if (parameterCount > i)
                        parameters.Add(uxValueGrid.Rows[i].Cells[1].Value.ToString());
                }
            }

            var server = servers[0];

            for (int i = 0; i < servers.Count; i++)
            {
                if (servers[i].ServerName == uxServersListBox.SelectedItem.ToString())
                {
                    server = servers[i];
                }

            }


            runSQLQuery run = new runSQLQuery();

            uxOutputDataGrid.Visible = true;
            uxOutputDataGrid.DataSource = run.runQuery(queryText, server, database, parameters);
        }

        private void uxValueGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            uxValueGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void uxOutputDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            uxOutputDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
