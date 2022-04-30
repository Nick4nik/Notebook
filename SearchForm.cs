using System;
using System.Windows.Forms;

namespace Notebook
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Shown(object sender, EventArgs e)
        {
            tbFind.Focus();
        }

        int findCutLength = 0;

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            findCutLength = 0;
        }

        private void tbReplace_TextChanged(object sender, EventArgs e)
        {
            findCutLength = 0;
        }

        private void cbReg_CheckStateChanged(object sender, EventArgs e)
        {
            findCutLength = 0;
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            findCutLength = 0;
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (cbReg.CheckState == CheckState.Checked)
                {
                    TextWork.FindTextBox(ref main.notebox, tbFind.Text, ref findCutLength, true);
                }
                else
                {
                    TextWork.FindTextBox(ref main.notebox, tbFind.Text, ref findCutLength, false);
                }
            }
        }

        private void butReplace_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (cbReg.CheckState == CheckState.Checked)
                {
                    TextWork.ReplaceTextBox(ref main.notebox, tbFind.Text, tbReplace.Text, ref findCutLength, true);
                }
                else
                {
                    TextWork.ReplaceTextBox(ref main.notebox, tbFind.Text, tbReplace.Text, ref findCutLength, false);
                }
            }
        }

        private void butReplaceAll_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (cbReg.CheckState == CheckState.Checked)
                {
                    TextWork.ReplaceAllTextBox(ref main.notebox, tbFind.Text, tbReplace.Text, true);
                }
                else
                {
                    TextWork.ReplaceAllTextBox(ref main.notebox, tbFind.Text, tbReplace.Text, false);
                }
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}