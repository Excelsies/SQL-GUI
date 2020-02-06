using System;
using System.Deployment.Application;
using System.Reflection;
using System.Windows.Forms;

namespace SQLGUIProject
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            string name = Assembly.GetExecutingAssembly().GetName().Name;
            string culture = Assembly.GetExecutingAssembly().GetName().ContentType.ToString();
            string version = null;
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                version = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }

            nameLbl.Text = "Name: " + name;
            versionLbl.Text = "Version: " + version;
            cultureLbl.Text = "Culture: " + culture;

            if (Properties.Settings.Default.customThemeSet)
                themeClass.customTheme(this);//Sets the custom theme for the form
        }

        private void changeLogBtn_Click(object sender, EventArgs e)
        {
            var changeLog = new ChangeLog();
            changeLog.Show();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the Form
        }
    }
}
