using System.IO;
using System.Windows.Forms;
using System.Text;

namespace Notebook
{
    internal class FileWork
    {
        public static void CreateFile(ref TextBox notebox, ref bool tbChange, ref string docPath)
        {
            string newDocName = Properties.Settings.Default.newDocName;
            string programmName = Properties.Settings.Default.programmName;
            notebox.Clear();
            docPath = "";
            tbChange = false;
            MainForm.ActiveForm.Text = newDocName + " — " + programmName;
        }

        public static void OpenFile(ref TextBox notebox, ref bool tbChange, ref string docPath)
        {
            string programmName = Properties.Settings.Default.programmName;
            OpenFileDialog openDocument = new OpenFileDialog();
            openDocument.Title = "Открыть текстовый документ";
            openDocument.Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы (*.*)|*.*";
            if (openDocument.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(openDocument.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file, Encoding.UTF8);
                notebox.Text = reader.ReadToEnd();
                reader.Close();
                docPath = openDocument.FileName;
                tbChange = false;
                MainForm.ActiveForm.Text = openDocument.SafeFileName + " — " + programmName;
            }
        }

        public static void SaveFile(ref TextBox notebox, ref bool tbChange, ref string docPath)
        {
            FileStream file = new FileStream(docPath, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file, Encoding.UTF8);
            writer.Write(notebox.Text);
            writer.Close();
            tbChange = false;
        }

        public static void SaveAsFile(ref TextBox notebox, ref bool tbChange, ref string docPath)
        {
            string programmName = Properties.Settings.Default.programmName;
            SaveFileDialog saveAsDocument = new SaveFileDialog();
            saveAsDocument.Title = "Сохранить документ как...";
            saveAsDocument.FileName = "Текстовый документ";
            saveAsDocument.Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы (*.*)|*.*";

            if (saveAsDocument.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(saveAsDocument.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file, Encoding.UTF8);
                writer.Write(notebox.Text);
                writer.Close();
                tbChange = false;
                docPath = saveAsDocument.FileName;
                MainForm.ActiveForm.Text = Path.GetFileName(saveAsDocument.FileName) + " — " + programmName;
            }
            else
            {
                tbChange = true;
                return;
            }
        }
    }
}
