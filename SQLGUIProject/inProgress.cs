using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SQLGUIProject
{
    public class inProgress
    {
        private List<string> warnings = new List<string>();

        private void setWarnings()
        {
            warnings.Add("Nothing happened! \n Perhaps Garet doesn't care about this yet...");
            warnings.Add("This is still being worked on.");
            warnings.Add("I'm taking a break. \n ...Don't come back.");
            warnings.Add("Try again later.");
            warnings.Add("This is Under Construction");
            warnings.Add("Why would you try this now?");
            warnings.Add("For all you know, this could be a virus.");
            warnings.Add("An Error occured while pulling this warning.");
            warnings.Add("Message.");
            warnings.Add("Whatever.");
        }

        private string getMessage()
        {
            setWarnings();
            var random = new Random();
            return warnings[random.Next(warnings.Count)];
        }

        public static bool uxInProgressMessage()
        {
            inProgress progress = new inProgress();
            DialogResult warning = MessageBox.Show(progress.getMessage(), "In Progress...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            if (warning == DialogResult.Retry)
                return true;
            else
                return false;
        }
    }
}


/*
            if (inProgress.uxInProgressMessage())
            {
                uxEditQueryBtn_Click(sender, e);
            } //*/
