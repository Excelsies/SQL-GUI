using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SQLGUIProject
{
    public partial class CreateNewQuery : Form
    {
        public XDocument XML;
        private bool editing;
        private List<SQLGUIProject.Common.Query> queries = SQLGUIProject.Common.Query.LoadAllFromXML(Properties.Settings.Default.PathToXML);
        private SQLGUIProject.Common.Query Query;
        private string queryN;
        private int index = 1;
        private List<int> indexes = new List<int>();
        private List<int> removedIndexes = new List<int>();
        private string origQuery = null;

        public CreateNewQuery(XDocument xml, ListBox.ObjectCollection servers, SQLGUIProject.Common.Query q)
        {
            InitializeComponent();

            XML = xml;
            editing = false;
            uxServerListBx.Items.AddRange(servers);
            Query = q;

            if (Properties.Settings.Default.customThemeSet)
                themeClass.customTheme(this);//Sets the custom theme for the form
        }

        public CreateNewQuery(XDocument xml, string name, string query, List<string> parameters, ListBox.ObjectCollection servers, List<string> chckedServers, bool dataBase, SQLGUIProject.Common.Query q)
        {
            InitializeComponent();

            XML = xml;
            editing = true;
            uxQueryNameTextBox.Text = name;
            uxQueryTextTextBox.Text = query;
            uxDBChckBx.Checked = dataBase;
            queryN = name;
            uxServerListBx.Items.AddRange(servers);
            Query = q;
            origQuery = name;

            for (int i = 0; i <= (uxServerListBx.Items.Count - 1); i++)
            {
                if (chckedServers.Contains(uxServerListBx.Items[i].ToString()))
                {
                    uxServerListBx.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    uxServerListBx.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            indexes = new List<int>();


            for (int i = 0; i < parameters.Count; i++)
            {
                if (parameters[i] != null)
                {
                    uxParameterGrid.Rows.Add(i + 1, parameters[i]);
                    if (i == 0)
                    {
                        uxQueryTextTextBox.Text = uxQueryTextTextBox.Text.Insert(uxQueryTextTextBox.Text.IndexOf("[P]") + 2, (i + 1).ToString());
                        indexes.Add(uxQueryTextTextBox.Text.IndexOf("[P" + (i + 1) + "]"));
                    }
                    else
                    {
                        uxQueryTextTextBox.Text = uxQueryTextTextBox.Text.Insert(uxQueryTextTextBox.Text.IndexOf("[P]"), (i + 1).ToString());
                        indexes.Add(uxQueryTextTextBox.Text.IndexOf("[P" + (i + 1) + "]", indexes[i - 1] + 1));
                    }
                }

            }

            index = parameters.Count + 1;

            if (Properties.Settings.Default.customThemeSet)
                themeClass.customTheme(this);//Sets the custom theme for the form
        }

        private void updateIndexes()
        {
            for (int x = 0; x < indexes.Count; x++)
            {
                indexes[x] = uxQueryTextTextBox.Text.IndexOf("[P" + (x + 1) + "]");
            }
        }

        private void uxAddParamBtn_Click(object sender, EventArgs e)
        {
            int i = index;
            if (removedIndexes.Count > 0)
            {
                i = removedIndexes[0] + 1;
                removedIndexes.RemoveAt(0);
            }

            //Changing the txt feild will reset caret location
            int caretLocation = this.uxQueryTextTextBox.SelectionStart; //Grabs the initail caret location
            uxQueryTextTextBox.Text = uxQueryTextTextBox.Text.Insert(uxQueryTextTextBox.SelectionStart, "[P" + i + "]");
            this.uxQueryTextTextBox.SelectionStart = caretLocation + (int)Math.Log10(i) + 4; //Sets the caret after the parameter placeholder

            updateIndexes();

            int newIndex = uxQueryTextTextBox.Text.IndexOf("[P" + i + "]");

            uxParameterGrid.Rows.Add(i, "");

            if (i == index)
                indexes.Add(newIndex);
            else
                indexes.Insert(i, newIndex);

            uxParameterGrid.Sort(uxParameterGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

            index++;
        }

        private void uxTestQueryButton_Click(object sender, EventArgs e)
        {
            queryNameError.Dispose();
            queryTextError.Dispose();
            serverError.Dispose();
            emptyParameterError.Dispose();

            if (uxQueryNameTextBox.Text == null || uxQueryNameTextBox.Text == "")
            {
                queryNameError.SetError(queryLbl, "You need to name your Query!");
                return;
            }
            if (uxQueryTextTextBox.Text == null || uxQueryTextTextBox.Text == "")
            {
                queryTextError.SetError(queryTextlbl, "You need to write your Query!");
                return;
            }
            if (uxServerListBx.CheckedItems.Count == 0)
            {
                serverError.SetError(serverlbl, "You need to select the associated servers!");
                return;
            }

            List<string> parameters = new List<string>();
            int count = 1;

            string querytext = uxQueryTextTextBox.Text;

            foreach (DataGridViewRow row in uxParameterGrid.Rows)
            {

                if (row.Cells[1].Value.ToString() == "")
                {
                    emptyParameterError.SetError(lblParamters, "You need to name each parameter!");
                    return;
                }
                else
                    emptyParameterError.Clear();

                string[] querySplit = querytext.Split(new[] { "[P" + count + "]" }, StringSplitOptions.None);

                string tempQuery = null;
                tempQuery += querySplit[0] + "[P]" + querySplit[1];
                querytext = tempQuery;

                parameters.Add(row.Cells[1].Value.ToString());
                count++;
            }

            List<string> servers = new List<string>();

            foreach (SQLGUIProject.Common.SQLServer item in uxServerListBx.CheckedItems)
            {
                servers.Add(item.ServerName);
            }

            var testForm = new QueryTest(querytext, parameters, servers, uxDBChckBx.Checked);
            testForm.ShowDialog();
        }

        private void uxSaveQueryButton_Click(object sender, EventArgs e)
        {

            queryNameError.Dispose();
            queryTextError.Dispose();
            serverError.Dispose();
            emptyParameterError.Dispose();

            for (int i = 0; i < queries.Count; i++)
            {
                if (queries[i].queryName == uxQueryNameTextBox.Text && !editing)
                {
                    DialogResult warning = MessageBox.Show("You cannot add a query with the same name!", "Important!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (queries[i].queryName == uxQueryNameTextBox.Text && editing && queryN != uxQueryNameTextBox.Text)
                {
                    DialogResult warning = MessageBox.Show("You cannot add a query with the same name!", "Important!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (uxQueryNameTextBox.Text == null || uxQueryNameTextBox.Text == "")
            {
                queryNameError.SetError(queryLbl, "You need to name your Query!");
                return;
            }
            if (uxQueryTextTextBox.Text == null || uxQueryTextTextBox.Text == "")
            {
                queryTextError.SetError(queryTextlbl, "You need to write your Query!");
                return;
            }
            if (uxServerListBx.CheckedItems == null)
            {
                serverError.SetError(serverlbl, "You need to select the associated servers!");
                return;
            }

            List<string> parameters = new List<string>();
            int count = 1;

            string querytext = uxQueryTextTextBox.Text;

            foreach (DataGridViewRow row in uxParameterGrid.Rows)
            {

                if (row.Cells[1].Value.ToString() == "")
                {
                    emptyParameterError.SetError(lblParamters, "You need to name each parameter!");
                    return;
                }
                else
                    emptyParameterError.Clear();

                string[] querySplit = querytext.Split(new[] { "[P" + count + "]" }, StringSplitOptions.None);

                string tempQuery = null;
                tempQuery += querySplit[0] + "[P]" + querySplit[1];
                querytext = tempQuery;

                parameters.Add(row.Cells[1].Value.ToString());
                count++;
            }

            List<string> servers = new List<string>();

            foreach (SQLGUIProject.Common.SQLServer item in uxServerListBx.CheckedItems)
            {
                servers.Add(item.ServerName);
            }

            string useDB = null;

            if (uxDBChckBx.Checked)
            {
                useDB = "Y";
            }

            //*
            if (!editing)
            {
                Query.SaveNewQuery(XML, uxQueryNameTextBox.Text, querytext, servers, parameters, useDB);
                XML.Save(Properties.Settings.Default.PathToXML);
                this.Close(); //closes the Form
            }
            else
            {
                Query.DeleteFromXML(XML, origQuery);
                Query.SaveNewQuery(XML, uxQueryNameTextBox.Text, querytext, servers, parameters, useDB);
                XML.Save(Properties.Settings.Default.PathToXML);
                this.Close(); //closes the Form
            }
        }

        private void uxCancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxQueryTextTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            List<string> charCombinations = new List<string>();
            foreach (DataGridViewRow i in uxParameterGrid.Rows)
            {
                charCombinations.Add("[P" + i.Cells[0].Value + "]");
            }
            string txt = this.uxQueryTextTextBox.Text;
            int caretLocation = this.uxQueryTextTextBox.SelectionStart;
            if (e.KeyCode == Keys.Delete)
            {
                //get text in front
                string s = txt.Substring(caretLocation);
                string notChecking = txt.Substring(0, caretLocation);
                foreach (string combo in charCombinations)
                {
                    if (s.StartsWith(combo))
                    {
                        txt = notChecking + s.Substring(combo.Length - 1);
                        removeParameter(charCombinations.IndexOf(combo));
                        break;
                    }
                }
            }
            if (e.KeyCode == Keys.Back)
            {
                //get text in behind
                string s = txt.Substring(0, caretLocation);
                string notChecking = txt.Substring(caretLocation);
                foreach (string combo in charCombinations)
                {
                    if (s.EndsWith(combo))
                    {
                        txt = s.Substring(0, s.Length - combo.Length + 1) + notChecking;
                        caretLocation -= combo.Length - 1;
                        removeParameter(charCombinations.IndexOf(combo));
                        break;
                    }
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                //get text in front
                string s = txt.Substring(caretLocation);
                string notChecking = txt.Substring(0, caretLocation);
                foreach (string combo in charCombinations)
                {
                    if (s.StartsWith(combo))
                    {
                        uxQueryTextTextBox.SelectionStart = caretLocation + combo.Length - 1;
                        caretLocation = uxQueryTextTextBox.SelectionStart;
                    }
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                //get text in behind
                string s = txt.Substring(0, caretLocation);
                string notChecking = txt.Substring(caretLocation);
                foreach (string combo in charCombinations)
                {
                    if (s.EndsWith(combo))
                    {
                        uxQueryTextTextBox.SelectionStart = caretLocation - combo.Length + 1;
                        caretLocation = uxQueryTextTextBox.SelectionStart;
                    }
                }
            }
            this.uxQueryTextTextBox.Text = txt;
            //changing the txt feild will reset caret location
            this.uxQueryTextTextBox.SelectionStart = caretLocation;
        }

        private void removeParameter(int i)
        {
            index--;
            indexes.RemoveAt(i);
            uxParameterGrid.Rows.RemoveAt(i);
            removedIndexes.Insert(0, i);
        }

        private void uxParameterGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (uxParameterGrid.CurrentRow.Cells[e.ColumnIndex].ReadOnly)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void uxQueryTextTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            int cursorPosition = uxQueryTextTextBox.SelectionStart;

            try
            {
                if (uxQueryTextTextBox.Text[cursorPosition] == '[')
                    return;
            }
            catch (Exception) { }

            try
            {
                if (uxQueryTextTextBox.Text[cursorPosition - 1] == ']')
                    return;
            }
            catch (Exception) { }


            List<string> charCombinations = new List<string>();

            foreach (DataGridViewRow i in uxParameterGrid.Rows)
            {
                charCombinations.Add("[P" + i.Cells[0].Value + "]");
            }

            int nextSpace = uxQueryTextTextBox.Text.IndexOf(' ', cursorPosition);
            int selectionStart = 0;
            string trimmedString = string.Empty;
            // Strip everything after the next space...
            if (nextSpace != -1)
            {
                trimmedString = uxQueryTextTextBox.Text.Substring(0, nextSpace);
            }
            else
            {
                trimmedString = uxQueryTextTextBox.Text;
            }


            if (trimmedString.LastIndexOf(' ') != -1)
            {
                selectionStart = 1 + trimmedString.LastIndexOf(' ');
                trimmedString = trimmedString.Substring(1 + trimmedString.LastIndexOf(' '));
            }

            if (charCombinations.Contains(trimmedString))
            {
                uxQueryTextTextBox.SelectionStart = selectionStart;
                uxQueryTextTextBox.SelectionLength = trimmedString.Length;
                return;
            }

            int c = 0;
            foreach (string combo in charCombinations)
            {
                if (trimmedString.Contains(combo))
                    c++;

                if (c > 1)
                    break;
            }

            if (c > 1)
            {
                nextSpace = uxQueryTextTextBox.Text.IndexOf(']', cursorPosition) + 1;

                if (nextSpace != -1)
                {
                    trimmedString = uxQueryTextTextBox.Text.Substring(0, nextSpace);
                }
                else
                {
                    trimmedString = uxQueryTextTextBox.Text;
                }


                if (trimmedString.LastIndexOf('[') != -1)
                {
                    selectionStart = trimmedString.LastIndexOf('[');
                    trimmedString = trimmedString.Substring(trimmedString.LastIndexOf('['));
                }

                if (!trimmedString.Contains(" ") && charCombinations.Contains(trimmedString))
                {
                    uxQueryTextTextBox.SelectionStart = selectionStart;
                    uxQueryTextTextBox.SelectionLength = trimmedString.Length;
                    return;
                }
            }

        }

        private void uxParameterGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            uxParameterGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
