using System;
using System.IO;
using System.Windows.Forms;

namespace SQLGUIProject
{
    public partial class ChangeLog : Form
    {
        public ChangeLog()
        {
            InitializeComponent();

            if (Properties.Settings.Default.customThemeSet)
                themeClass.customTheme(this);//Sets the custom theme for the form
        }

        private void ChangeLog_Load(object sender, EventArgs e)
        {
            changeLogTxt.Text = File.ReadAllText(Properties.Settings.Default.PathToChangelog);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the Form
        }
    }
}
