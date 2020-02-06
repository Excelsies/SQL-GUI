using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SQLGUIProject
{
    public partial class ServerForm : Form
    {
        private bool editing;
        public XDocument XML;
        private SQLGUIProject.Common.SQLServer Server;
        private string serverN;
        private List<SQLGUIProject.Common.SQLServer> servers = SQLGUIProject.Common.SQLServer.LoadAllFromXML(Properties.Settings.Default.PathToXML);

        public ServerForm(XDocument xml, SQLGUIProject.Common.SQLServer server)
        {
            InitializeComponent();

            this.Text = "New Server";

            //centers the form
            this.CenterToParent();

            XML = xml;
            Server = server;
            editing = false;

            if (Properties.Settings.Default.customThemeSet)
            {
                themeClass.customTheme(this);//Sets the custom theme for the form
            }
        }

        public ServerForm(string serverName, bool WindowsAuthentication, string Username, string Password, XDocument xml, SQLGUIProject.Common.SQLServer server)
        {
            InitializeComponent();

            this.Text = "New Server";

            //centers the form
            this.CenterToParent();

            XML = xml;
            Server = server;
            editing = true;
            uxServerNameTxt.Text = serverName;
            serverN = serverName;
            uxWAChckBx.Checked = WindowsAuthentication;
            uxUsernameTxt.Text = Username;
            uxPasswordTxt.Text = Password;

            if (Properties.Settings.Default.customThemeSet)
            {
                themeClass.customTheme(this);//Sets the custom theme for the form
            }
        }

        private void uxOKBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < servers.Count; i++)
            {
                if (servers[i].ServerName == uxServerNameTxt.Text && !editing)
                {
                    DialogResult warning = MessageBox.Show("You cannot add a server that already exists!", "Important!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (servers[i].ServerName == uxServerNameTxt.Text && editing && serverN != uxServerNameTxt.Text)
                {
                    DialogResult warning = MessageBox.Show("You cannot add a server that already exists!", "Important!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (uxServerNameTxt.Text == null || uxServerNameTxt.Text == "")
            {
                uxNullUsername.SetError(lblServerName, "You need to set the Server Name!");
                return;
            }
            else
                uxNullServerName.Dispose();

            if (!uxWAChckBx.Checked)
            {
                if ((uxUsernameTxt.Text == null && uxPasswordTxt.Text == null) || (uxUsernameTxt.Text == "" && uxPasswordTxt.Text == ""))
                {
                    uxNullUsername.SetError(lblUsername, "You need to set the username!");
                    uxNullPassword.SetError(lblPassword, "You need to set the Password!");
                    return;
                }
                else if (uxUsernameTxt.Text == null || uxUsernameTxt.Text == "")
                {
                    uxNullUsername.SetError(lblUsername, "You need to set the username!");
                    uxNullPassword.Dispose();
                    return;
                }

                else if (uxPasswordTxt.Text == null || uxPasswordTxt.Text == "")
                {
                    uxNullPassword.SetError(lblPassword, "You need to set the Password!");
                    uxNullUsername.Dispose();
                    return;
                }
                else
                {
                    uxNullUsername.Dispose();
                    uxNullPassword.Dispose();
                }

            }

            if (!editing)
            {
                Server.SaveNewServer(XML, uxServerNameTxt.Text, uxWAChckBx.Checked.ToString(), uxUsernameTxt.Text, uxPasswordTxt.Text);
                XML.Save(Properties.Settings.Default.PathToXML);
                this.Close(); //closes the Form
            }
            else
            {
                Server.SaveAdjustedServer(XML, uxServerNameTxt.Text, uxWAChckBx.Checked.ToString(), serverN, uxUsernameTxt.Text, uxPasswordTxt.Text);
                XML.Save(Properties.Settings.Default.PathToXML);
                this.Close(); //closes the Form
            }
        }

        private void uxCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the Form
        }

        private void uxWAChckBx_CheckedChanged(object sender, EventArgs e)
        {
            if (uxWAChckBx.Checked)
            {
                uxUsernameTxt.ReadOnly = true;
                uxPasswordTxt.ReadOnly = true;

                uxNullUsername.Dispose();
                uxNullPassword.Dispose();
            }
            else
            {
                uxUsernameTxt.ReadOnly = false;
                uxPasswordTxt.ReadOnly = false;

                uxNullUsername.Dispose();
                uxNullPassword.Dispose();
            }
        }

        private void uxUsernameTxt_TextChanged(object sender, EventArgs e)
        {
            uxNullUsername.Dispose();
        }

        private void uxPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            uxNullPassword.Dispose();
        }
    }
}
