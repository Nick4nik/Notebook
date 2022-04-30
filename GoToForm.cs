using System;
using System.Linq;
using System.Windows.Forms;

namespace Notebook
{
    public partial class GoToForm : Form
    {
        public GoToForm()
        {
            InitializeComponent();
        }

        private void butGo_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                int lineNumber = Convert.ToInt32(tbLineNum.Text);
                if (lineNumber > 0 && lineNumber <= main.notebox.Lines.Count())
                {
                    main.notebox.SelectionStart = main.notebox.GetFirstCharIndexFromLine(Convert.ToInt32(tbLineNum.Text) - 1);
                    main.notebox.ScrollToCaret();
                    this.Close();
                }
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}