using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notebook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = Properties.Settings.Default.newDocName + " - " + Properties.Settings.Default.programmName;
            TextWork.mEditEnableds(ref notebox, ref mEditGiveAll, ref mEditCancel, ref mEditCopy, ref mEditCut, ref mEditDel, ref mEditFind, ref mEditGo);
        }

        public MainForm(string fileName)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
            {
                try
                {
                    string programmName = Properties.Settings.Default.programmName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file, Encoding.UTF8);
                    notebox.Text = reader.ReadToEnd();
                    reader.Close();
                    docPath = fileName;
                    tbChange = false;
                    this.Text = Path.GetFileName(fileName) + " — " + programmName;
                    notebox.Select(0, 0);
                    TextWork.mEditEnableds(ref notebox, ref mEditGiveAll, ref mEditCancel, ref mEditCopy, ref mEditCut, ref mEditDel, ref mEditFind, ref mEditGo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        bool tbChange = false;
        string docPath = "";

        public void MainForm_Resize(object sender, EventArgs e)
        {
            if (Width <= 626 && statusLab1.Visible == true)
            {
                Pointer.Visible = true;
            }
            else if (Width <= 455 && statusLab1.Visible != true)
            {
                Pointer.Visible = true;
            }
            else
            {
                Pointer.Visible = false;
            }
            if (this.Width <= 294 && this.Width >= 252)
            {
                mHelp.Visible = false;
                mView.Visible = true;
                mFormat.Visible = true;
                Size1.Visible = true;
                Size2.Visible = false;
                Size3.Visible = false;

            }
            else if (this.Width <= 251 && this.Width >= 213)
            {
                mHelp.Visible = false;
                mView.Visible = false;
                mFormat.Visible = true;
                Size1.Visible = false;
                Size2.Visible = true;
                Size3.Visible = false;
            }
            else if (this.Width <= 212)
            {
                mHelp.Visible = false;
                mView.Visible = false;
                mFormat.Visible = false;
                Size1.Visible = false;
                Size2.Visible = false;
                Size3.Visible = true;
            }
            else if (this.Width >= 317)
            {
                mHelp.Visible = true;
                mView.Visible = true;
                mFormat.Visible = true;
                Size1.Visible = false;
                Size2.Visible = false;
                Size3.Visible = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Width = Properties.Settings.Default.formWidth;
            this.Height = Properties.Settings.Default.formHeight;
            notebox.Font = Properties.Settings.Default.textFont;
            if (Properties.Settings.Default.statusStripVisible == true)
                mViewStatusStrip.CheckState = CheckState.Checked;
            else
                mViewStatusStrip.CheckState = CheckState.Unchecked;
            if (Properties.Settings.Default.textTransfer == true)
                mFormatTransfer.CheckState = CheckState.Checked;
            else
                mFormatTransfer.CheckState = CheckState.Unchecked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.formWidth = this.Width;
            Properties.Settings.Default.formHeight = this.Height;
            Properties.Settings.Default.textTransfer = notebox.WordWrap;
            Properties.Settings.Default.textFont = notebox.Font;
            Properties.Settings.Default.statusStripVisible = statusStrip.Visible;
            Properties.Settings.Default.Save();
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед выходом?", "Выход из программы", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                }
                else if (message == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void notebox_TextChanged(object sender, EventArgs e)
        {
            tbChange = true;
            TextWork.StatusAnalize(ref notebox, ref statusLinesCount, ref statusWordsCount, ref statusCharSpaceCount, ref statusCharCount);
            TextWork.mEditEnableds(ref notebox, ref mEditGiveAll, ref mEditCancel, ref mEditCopy, ref mEditCut, ref mEditDel, ref mEditFind, ref mEditGo);
        }

        private void mFileNew_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед созданием нового?", "Создание документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                }
            }
            else
            {
                MessageBox.Show("Невозможно создать новый файл, так как этот пуст", "Создание файла...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mFileOpen_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед открытием нового?", "Открытие документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                }
                else
                {
                    return;
                }
            }
            else
            {
                FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
            }
        }

        private void mFileSave_Click(object sender, EventArgs e)
        {
            if (docPath != "")
            {
                FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
            }
            else
            {
                FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
            }
        }

        private void mFileSaveAs_Click(object sender, EventArgs e)
        {
            FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
        }

        private void mFilePageParam_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
            }
        }

        private void mFilePrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка параметров печати.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void mFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mEditCancel_Click(object sender, EventArgs e)
        {
            notebox.Undo();
        }

        private void mEditCut_Click(object sender, EventArgs e)
        {
            if (notebox.SelectionLength > 0)
            {
                notebox.Cut();
            }
        }

        private void mEditCopy_Click(object sender, EventArgs e)
        {
            if (notebox.SelectionLength > 0)
            {
                notebox.Copy();
            }
        }

        private void mEditPaste_Click(object sender, EventArgs e)
        {
            notebox.Paste();
        }

        private void mEditDel_Click(object sender, EventArgs e)
        {
            if (notebox.SelectionLength > 0)
            {
                notebox.SelectedText = "";
            }
        }

        private void mEditGiveAll_Click(object sender, EventArgs e)
        {
            notebox.SelectAll();
        }

        private void mEditTime_Click(object sender, EventArgs e)
        {
            notebox.AppendText(Environment.NewLine + Convert.ToString(System.DateTime.Now));
        }

        private void mEditFind_Click(object sender, EventArgs e)
        {
            SearchForm findText = new SearchForm();
            findText.Owner = this;
            findText.Show();
        }

        private void mEditGo_Click(object sender, EventArgs e)
        {
            GoToForm gotoform = new GoToForm();
            gotoform.Owner = this;
            gotoform.tbLineNum.Minimum = 0;
            gotoform.tbLineNum.Maximum = notebox.Lines.Count();
            gotoform.ShowDialog();
        }

        private void mFormatFont_Click(object sender, EventArgs e)
        {
            fontDialog.Font = notebox.Font;
            DialogResult = fontDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                notebox.Font = fontDialog.Font;
            }
        }

        private void mFormatTransfer_CheckStateChanged(object sender, EventArgs e)
        {
            if (mFormat.Visible == true)
            {
                if (mFormatTransfer.CheckState == CheckState.Checked)
                {
                    notebox.WordWrap = true;
                    notebox.ScrollBars = ScrollBars.Vertical;
                    mEditGo.Enabled = false;
                    statusLab1.Visible = false;
                    statusLinesCount.Visible = false;
                }
                else
                {
                    notebox.WordWrap = false;
                    notebox.ScrollBars = ScrollBars.Both;
                    mEditGo.Enabled = true;
                    statusLab1.Visible = true;
                    statusLinesCount.Visible = true;
                }
                if (mFormatTransfer.CheckState == Size3mFormatTransfer.CheckState)
                {
                    return;
                }
                else
                    Size3mFormatTransfer.CheckState = mFormatTransfer.CheckState;
            }
            else
            {
                if (Size3mFormatTransfer.CheckState == CheckState.Checked)
                {
                    notebox.WordWrap = true;
                    notebox.ScrollBars = ScrollBars.Vertical;
                    mEditGo.Enabled = false;
                    statusLab1.Visible = false;
                    statusLinesCount.Visible = false;
                }
                else
                {
                    notebox.WordWrap = false;
                    notebox.ScrollBars = ScrollBars.Both;
                    mEditGo.Enabled = true;
                    statusLab1.Visible = true;
                    statusLinesCount.Visible = true;
                }
                if (mFormatTransfer.CheckState == Size3mFormatTransfer.CheckState)
                {
                    return;
                }
                else
                    mFormatTransfer.CheckState = Size3mFormatTransfer.CheckState;
            }
        }

        private void mViewStatusStrip_CheckStateChanged(object sender, EventArgs e)
        {
            if (mView.Visible == true)
            {
                if (mViewStatusStrip.CheckState == CheckState.Checked)
                {
                    statusStrip.Visible = true;
                    Pointer.Visible = true;
                }
                else
                {
                    statusStrip.Visible = false;
                    Pointer.Visible = false;
                }
                if (mViewStatusStrip.CheckState == Size3mViewStatusStrip.CheckState && mViewStatusStrip.CheckState == Size2mViewStatusStrip.CheckState)
                {
                    return;
                }
                else
                {
                    Size3mViewStatusStrip.CheckState = mViewStatusStrip.CheckState;
                    Size2mViewStatusStrip.CheckState = mViewStatusStrip.CheckState;
                }
            }
            else if (Size3.Visible == true)
            {
                if (Size3mViewStatusStrip.CheckState == CheckState.Checked)
                {
                    statusStrip.Visible = true;
                    Pointer.Visible = true;
                }
                else
                {
                    statusStrip.Visible = false;
                    Pointer.Visible = false;
                }
                if (Size3mViewStatusStrip.CheckState == mViewStatusStrip.CheckState && Size3mViewStatusStrip.CheckState == Size2mViewStatusStrip.CheckState)
                {
                    return;
                }
                else
                {
                    mViewStatusStrip.CheckState = Size3mViewStatusStrip.CheckState;
                    Size2mViewStatusStrip.CheckState = Size3mViewStatusStrip.CheckState;
                }
            }

            else if (Size2.Visible == true)
            {
                if (Size2mViewStatusStrip.CheckState == CheckState.Checked)
                {
                    statusStrip.Visible = true;
                    Pointer.Visible = true;
                }
                else
                {
                    statusStrip.Visible = false;
                    Pointer.Visible = false;
                }
                if (Size2mViewStatusStrip.CheckState == mViewStatusStrip.CheckState && Size2mViewStatusStrip.CheckState == Size2mViewStatusStrip.CheckState)
                {
                    return;
                }
                else
                {
                    mViewStatusStrip.CheckState = Size2mViewStatusStrip.CheckState;
                    Size3mViewStatusStrip.CheckState = Size2mViewStatusStrip.CheckState;
                }
            }
        }

        private void mHelpAboutProgram_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }
    }
}
