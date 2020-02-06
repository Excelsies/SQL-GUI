using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;

namespace SQLGUIProject
{
    public partial class main : Form
    {
        static string XMLPath = Properties.Settings.Default.PathToXML; //sets the path to the XML

        public main()
        {
            InitializeComponent();

            if (Properties.Settings.Default.customThemeSet)
                themeClass.customTheme(this);//Sets the custom theme for the form

            XDocument defaultXML = XDocument.Load(Properties.Settings.Default.PathToDefaultXML);

            if (File.Exists(XMLPath))
            {
                // check queries and servers
                List<SQLGUI.Common.Query> defQueries = SQLGUI.Common.Query.LoadAllFromXML(Properties.Settings.Default.PathToDefaultXML);
                List<SQLGUI.Common.SQLServer> defServers = SQLGUI.Common.SQLServer.LoadAllFromXML(Properties.Settings.Default.PathToDefaultXML);
                List<SQLGUI.Common.Query> curQueries = SQLGUI.Common.Query.LoadAllFromXML(XMLPath);
                List<SQLGUI.Common.SQLServer> curServers = SQLGUI.Common.SQLServer.LoadAllFromXML(XMLPath);

                foreach (var q in defQueries)
                {
                    if (!curQueries.Contains(q))
                    {
                        q.SaveNewQuery(defaultXML, q.queryName, q.queryText, q.sqlServers, q.paramList, q.database);
                        defaultXML.Save(Properties.Settings.Default.PathToXML);
                    }
                }

                foreach (var s in defServers)
                {
                    if (!curServers.Contains(s))
                    {
                        s.SaveNewServer(defaultXML, s.ServerName, s.WindowsAuthentication.ToString(), s.ServerCredentials[0], s.ServerCredentials[1]);
                        defaultXML.Save(Properties.Settings.Default.PathToXML);
                    }
                }

            }
            else
            {
                defaultXML.Save(XMLPath);
            }

        }


        //creates a list for the servers and the queries
        List<SQLGUI.Common.Query> queries = SQLGUI.Common.Query.LoadAllFromXML(XMLPath);
        List<SQLGUI.Common.SQLServer> servers = SQLGUI.Common.SQLServer.LoadAllFromXML(XMLPath);
        XDocument theXML = XDocument.Load(XMLPath);
        List<string> queryNames = new List<string>();
        int selectedQuery;

        private void main_Load(object sender, EventArgs e)
        {
            //populates the appropriate list boxes with the servers and queries
            PopulateDBServers();

        }

        public override string ToString()
        {
            return this.Name;
        }

        public void PopulateDBServers()
        {
            queryNames.Clear();

            foreach (var s in servers)
            {
                uxServersListBox.Items.Add(s);

            }

            foreach (var q in queries)
            {
                queryNames.Add(q.queryName);
            }
        }

        public void PopulateQueries()
        {
            uxQueryListBox.Items.Clear();

            foreach (var q in queries)
            {
                if (q.sqlServers.Contains(uxServersListBox.SelectedItem.ToString()))
                    uxQueryListBox.Items.Add(q.queryName);
            }
        }

        private void uxQueryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedQuery = queryNames.IndexOf(uxQueryListBox.SelectedItem.ToString());
                uxNullQueryError.Clear();
                uxQueryTxt.Text = "";

                //Displays the selected query in the query text box
                string query = null;

                for (int i = 0; i < queries.Count; i++)
                {
                    if (queries[i].queryName == uxQueryListBox.SelectedItem.ToString())
                        query = queries[i].queryText;
                }

                string[] querySplit = query.Split(new[] { "[P]" }, StringSplitOptions.None);

                for (int i = 0; i < querySplit.Length; i++)
                {
                    if (queries[selectedQuery].paramList.Count > i)
                        uxQueryTxt.Text += querySplit[i] + queries[selectedQuery].paramList[i];
                    else
                        uxQueryTxt.Text += querySplit[i];
                }
                updateValues();
            }
            catch (Exception except)
            {
                Console.WriteLine(except);
            }
        }

        private void uxServersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxNullServerError.Clear();
            uxNullQueryError.Clear();
            PopulateQueries();
            updateValues();
        }

        private void uxGoButton_Click(object sender, EventArgs e)
        {

            if (this.uxOutputDataGrid.DataSource != null)
            {
                this.uxOutputDataGrid.DataSource = null;
            }
            else
            {
                this.uxOutputDataGrid.Rows.Clear();
            }



            //check if server and query is selected
            if (uxServersListBox.SelectedItem == null && uxQueryListBox.SelectedItem == null)
            {
                uxNullServerError.SetError(lblSQLServers, "You need to select a server!");
                uxNullQueryError.SetError(lblQueries, "You need to select a Query!");
                return;
            }
            else if (uxServersListBox.SelectedItem == null)
            {
                uxNullQueryError.Dispose(); //removes Query error if displayed
                uxNullServerError.SetError(lblSQLServers, "You need to select a server!");
                return;
            }
            else if (uxQueryListBox.SelectedItem == null)
            {
                uxNullServerError.Dispose(); //removes Server error if displayed
                uxNullQueryError.SetError(lblQueries, "You need to select a Query!");
                return;
            }
            else
            {
                uxNullQueryError.Dispose(); //removes Query error if displayed
                uxNullServerError.Dispose(); //removes Server error if displayed
            }

            //checks for the values
            for (int i = 0; i < (uxValueGrid.Rows.Count - 1); i++)
            {
                if (uxValueGrid.Rows[i].Cells[1].Value.ToString() == "" || uxValueGrid.Rows[i].Cells[1].Value == null)
                {
                    uxNullValue.SetError(lblValue, "Insert some values!");
                    return;
                }
                else
                {
                    uxNullValue.Dispose(); //removes value error if displayed
                }
            }

            var query = queries[0];

            for (int i = 0; i < queries.Count; i++)
            {
                if (queries[i].queryName == uxQueryListBox.SelectedItem.ToString())
                {
                    query = queries[i];
                }

            }

            runSQLQuery run = new runSQLQuery();

            string database = null;

            if (!servers[uxServersListBox.SelectedIndex].WindowsAuthentication)
            {
                database = uxValueGrid.Rows[0].Cells[1].Value.ToString();
            }

            List<string> parameters = new List<string>();
            if (query.paramList.Count > 0)
            {
                for (int i = 0; i < query.paramList.Count; i++)
                {
                    if (query.paramList.Count > i && query.database != null)
                        parameters.Add(uxValueGrid.Rows[i + 1].Cells[1].Value.ToString());
                    else if (query.paramList.Count > i)
                        parameters.Add(uxValueGrid.Rows[i].Cells[1].Value.ToString());
                }
            }

            uxOutputDataGrid.Visible = true;
            uxOutputDataGrid.DataSource = run.runQuery(query.queryText, servers[uxServersListBox.SelectedIndex], database, parameters);
        }

        public void updateValues()
        {
            uxValueGrid.Rows.Clear();

            if (uxQueryListBox.SelectedItem != null)
            {
                var query = queries[0];

                for (int i = 0; i < queries.Count; i++)
                {
                    if (queries[i].queryName == uxQueryListBox.SelectedItem.ToString())
                        query = queries[i];
                }

                try
                {
                    if (query.database != null)
                        this.uxValueGrid.Rows.Add("Database", "");

                    if (query.paramList.Count > 0)
                    {
                        for (int i = 0; i < query.paramList.Count; i++)
                        {
                            this.uxValueGrid.Rows.Add(query.paramList[i], "");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var themeForm = new ThemeCreator();
            themeForm.ShowDialog();

            //checks if the theme is set
            if (Properties.Settings.Default.customThemeSet)
            {
                themeClass.customTheme(this);//calls the function to change the colors to the custom theme
            }
            else
            {
                themeClass.resetTheme(this);//calls the function to change the colors to default
            }
            Refresh();
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void uxLaunchSQLBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sqlProcess;
            if (!servers[uxServersListBox.SelectedIndex].WindowsAuthentication)
            {
                try
                {
                    if (uxValueGrid.Rows[0].Cells[1].Value.ToString() != "")
                    {
                        try
                        {
                            sqlProcess = new ProcessStartInfo { FileName = "ssms.exe", Arguments = "-S " + uxServersListBox.SelectedItem + "-D" + uxValueGrid.Rows[0].Cells[1].Value.ToString() + "_MPICore_Data -U " + servers[uxServersListBox.SelectedIndex].ServerCredentials[0] + " -P " + servers[uxServersListBox.SelectedIndex].ServerCredentials[1] };
                        }
                        catch (Exception)
                        {
                            sqlProcess = new ProcessStartInfo { FileName = "ssms.exe", Arguments = "-S " + uxServersListBox.SelectedItem + "  -U " + servers[uxServersListBox.SelectedIndex].ServerCredentials[0] + " -P " + servers[uxServersListBox.SelectedIndex].ServerCredentials[1] };
                            Process.Start(sqlProcess);
                        }
                    }
                    else
                    {
                        sqlProcess = new ProcessStartInfo { FileName = "ssms.exe", Arguments = "-S " + uxServersListBox.SelectedItem + "  -U " + servers[uxServersListBox.SelectedIndex].ServerCredentials[0] + " -P " + servers[uxServersListBox.SelectedIndex].ServerCredentials[1] };
                        Process.Start(sqlProcess);
                    }
                }
                catch (Exception)
                {
                    sqlProcess = new ProcessStartInfo { FileName = "ssms.exe", Arguments = "-S " + uxServersListBox.SelectedItem + "  -U " + servers[uxServersListBox.SelectedIndex].ServerCredentials[0] + " -P " + servers[uxServersListBox.SelectedIndex].ServerCredentials[1] };
                    Process.Start(sqlProcess);
                }
            }
            else
            {
                sqlProcess = new ProcessStartInfo { FileName = "ssms.exe", Arguments = "-S " + uxServersListBox.SelectedItem + " -E" };
                Process.Start(sqlProcess);
            }
        }

        private void uxCreateNewServer_Click(object sender, EventArgs e)
        {
            uxNullServerError.Clear();
            var serverForm = new ServerForm(theXML, servers[0]);
            serverForm.ShowDialog();
            reloadData();

        }

        private void uxEditServerBtn_Click(object sender, EventArgs e)
        {
            if (uxServersListBox.SelectedItem == null)
            {
                uxNullQueryError.Dispose(); //removes Query error if displayed
                uxNullServerError.SetError(lblSQLServers, "You need to select a server!");
                return;
            }
            else
                uxNullServerError.Clear();


            var serverForm = new ServerForm(uxServersListBox.SelectedItem.ToString(), servers[uxServersListBox.SelectedIndex].WindowsAuthentication, servers[uxServersListBox.SelectedIndex].ServerCredentials[0], servers[uxServersListBox.SelectedIndex].ServerCredentials[1], theXML, servers[uxServersListBox.SelectedIndex]);
            serverForm.ShowDialog();
            reloadData();

        }

        private void uxDeleteServerBtn_Click(object sender, EventArgs e)
        {
            if (uxServersListBox.SelectedItem == null)
            {
                uxNullQueryError.Dispose(); //removes Query error if displayed
                uxNullServerError.SetError(lblSQLServers, "You need to select a server!");
                return;
            }
            else
                uxNullServerError.Clear();

            DialogResult warning = MessageBox.Show("Are you sure you want to delete this server?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                XDocument newXML = XDocument.Load(XMLPath);

                newXML = servers[uxServersListBox.SelectedIndex].DeleteFromXML(newXML, servers[uxServersListBox.SelectedIndex].ServerName);

                newXML.Save(XMLPath);
                reloadData();
            }
        }

        private void uxCreateNewQuery_Click(object sender, EventArgs e)
        {
            uxNullQueryError.Clear();
            var newQuery = new CreateNewQuery(theXML, uxServersListBox.Items, queries[0]);
            newQuery.ShowDialog();
            reloadData();
        }

        private void uxEditQueryBtn_Click(object sender, EventArgs e)
        {
            if (uxQueryListBox.SelectedItem == null)
            {
                uxNullQueryError.Dispose(); //removes Query error if displayed
                uxNullQueryError.SetError(lblQueries, "You need to select a query!");
                return;
            }
            else
                uxNullQueryError.Clear();

            var query = queries[0];

            for (int i = 0; i < queries.Count; i++)
            {
                if (queries[i].queryName == uxQueryListBox.SelectedItem.ToString())
                    query = queries[i];
            }

            List<string> param = new List<string>();
            List<string> chckedServers = new List<string>();

            for (int i = 0; i < query.paramList.Count; i++)
            {
                param.Add(query.paramList[i]);
            }

            for (int i = 0; i < query.sqlServers.Count; i++)
            {
                chckedServers.Add(query.sqlServers[i]);
            }

            bool database;
            if (query.database != null)
                database = true;
            else
                database = false;

            var editQuery = new CreateNewQuery(theXML, uxQueryListBox.SelectedItem.ToString(), query.queryText, param, uxServersListBox.Items, chckedServers, database, query);
            editQuery.ShowDialog();
            reloadData();
        }

        private void uxDeleteQueryBtn_Click(object sender, EventArgs e)
        {
            if (uxQueryListBox.SelectedItem == null)
            {
                uxNullQueryError.Dispose(); //removes Query error if displayed
                uxNullQueryError.SetError(lblQueries, "You need to select a query!");
                return;
            }
            else
                uxNullQueryError.Clear();

            DialogResult warning = MessageBox.Show("Are you sure you want to delete this query?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                var query = queries[0];

                for (int i = 0; i < queries.Count; i++)
                {
                    if (queries[i].queryName == uxQueryListBox.SelectedItem.ToString())
                        query = queries[i];
                }

                XDocument newXML = XDocument.Load(XMLPath);

                newXML = query.DeleteFromXML(newXML, query.queryName);

                newXML.Save(XMLPath);
                reloadData();
            }
        }

        private void importXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument importXML;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "XML files(.xml)|*.xml|all Files(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                importXML = XDocument.Load(openFileDialog1.FileName);

                DialogResult warning = MessageBox.Show("Are you sure you want to replace ALL of the queries and servers?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (warning == DialogResult.Yes)
                {
                    importXML.Save(XMLPath);
                    reloadData();
                }
            }

        }

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument exportXML = XDocument.Load(XMLPath);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "XML files (*.XML)|*.xml";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Save the servers and queries as an XML";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    // Code to write the stream goes here.
                    exportXML.Save(saveFileDialog1.FileName);
                }
            }

        }

        private void resetServersQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument defaultXML = XDocument.Load(Properties.Settings.Default.PathToDefaultXML);

            DialogResult warning = MessageBox.Show("Are you sure you want to replace ALL of the queries and servers with the defaults?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                defaultXML.Save(XMLPath);
                reloadData();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult closeDialog = MessageBox.Show("Are you sure you want to exit the program?", "In Progress...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (closeDialog == DialogResult.Yes)
                this.Close();
        }

        private void reloadData()
        {
            queries = SQLGUI.Common.Query.LoadAllFromXML(XMLPath);
            servers = SQLGUI.Common.SQLServer.LoadAllFromXML(XMLPath);
            theXML = XDocument.Load(XMLPath);
            uxQueryListBox.Items.Clear();
            uxServersListBox.Items.Clear();
            PopulateDBServers();
        }

        private void serverLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serverLookup = new ServerLookup(servers);
            serverLookup.Show();
        }

        private void uxOutputDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            uxOutputDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void uxValueGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            uxValueGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
