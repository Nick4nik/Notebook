namespace Notebook
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mFiloOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mFilePageParam = new System.Windows.Forms.ToolStripMenuItem();
            this.mFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditDel = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditGo = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditGiveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditTime = new System.Windows.Forms.ToolStripMenuItem();
            this.Size3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Size3mFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.Size3mFormatTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.Size3mFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.Size3mVIew = new System.Windows.Forms.ToolStripMenuItem();
            this.Size3mViewStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Size3mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.Size3mHelpAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.Size2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Size2mView = new System.Windows.Forms.ToolStripMenuItem();
            this.Size2mViewStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Size2mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.Size2mHelpAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mView = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Size1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Size1mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.Size1mHelpAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpAboutProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLab1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLinesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusWordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCharSpaceCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabEnc = new System.Windows.Forms.ToolStripStatusLabel();
            this.notebox = new System.Windows.Forms.TextBox();
            this.Pointer = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mEdit,
            this.Size3,
            this.mFormat,
            this.Size2,
            this.mView,
            this.Size1,
            this.mHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(725, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNew,
            this.mFiloOpen,
            this.mFileSave,
            this.mFileSaveAs,
            this.mFilePageParam,
            this.mFilePrint,
            this.mFileExit});
            this.mFile.Name = "mFile";
            this.mFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFile.Size = new System.Drawing.Size(48, 20);
            this.mFile.Text = "Файл";
            // 
            // mFileNew
            // 
            this.mFileNew.Name = "mFileNew";
            this.mFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFileNew.Size = new System.Drawing.Size(268, 22);
            this.mFileNew.Text = "Создать";
            this.mFileNew.Click += new System.EventHandler(this.mFileNew_Click);
            // 
            // mFiloOpen
            // 
            this.mFiloOpen.Name = "mFiloOpen";
            this.mFiloOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mFiloOpen.Size = new System.Drawing.Size(268, 22);
            this.mFiloOpen.Text = "Открыть";
            this.mFiloOpen.Click += new System.EventHandler(this.mFileOpen_Click);
            // 
            // mFileSave
            // 
            this.mFileSave.Name = "mFileSave";
            this.mFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mFileSave.Size = new System.Drawing.Size(268, 22);
            this.mFileSave.Text = "Сохранить";
            this.mFileSave.Click += new System.EventHandler(this.mFileSave_Click);
            // 
            // mFileSaveAs
            // 
            this.mFileSaveAs.Name = "mFileSaveAs";
            this.mFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mFileSaveAs.Size = new System.Drawing.Size(268, 22);
            this.mFileSaveAs.Text = "Сохранить как...";
            this.mFileSaveAs.Click += new System.EventHandler(this.mFileSaveAs_Click);
            // 
            // mFilePageParam
            // 
            this.mFilePageParam.Name = "mFilePageParam";
            this.mFilePageParam.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.mFilePageParam.Size = new System.Drawing.Size(268, 22);
            this.mFilePageParam.Text = "Параметры страницы";
            this.mFilePageParam.Click += new System.EventHandler(this.mFilePageParam_Click);
            // 
            // mFilePrint
            // 
            this.mFilePrint.Name = "mFilePrint";
            this.mFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mFilePrint.Size = new System.Drawing.Size(268, 22);
            this.mFilePrint.Text = "Печать...";
            this.mFilePrint.Click += new System.EventHandler(this.mFilePrint_Click);
            // 
            // mFileExit
            // 
            this.mFileExit.Name = "mFileExit";
            this.mFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mFileExit.Size = new System.Drawing.Size(268, 22);
            this.mFileExit.Text = "Выход";
            this.mFileExit.Click += new System.EventHandler(this.mFileExit_Click);
            // 
            // mEdit
            // 
            this.mEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditCancel,
            this.mEditCut,
            this.mEditCopy,
            this.mEditPaste,
            this.mEditDel,
            this.mEditFind,
            this.mEditGo,
            this.mEditGiveAll,
            this.mEditTime});
            this.mEdit.Name = "mEdit";
            this.mEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEdit.Size = new System.Drawing.Size(59, 20);
            this.mEdit.Text = "Правка";
            // 
            // mEditCancel
            // 
            this.mEditCancel.Name = "mEditCancel";
            this.mEditCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditCancel.Size = new System.Drawing.Size(212, 22);
            this.mEditCancel.Text = "Отменить";
            this.mEditCancel.Click += new System.EventHandler(this.mEditCancel_Click);
            // 
            // mEditCut
            // 
            this.mEditCut.Name = "mEditCut";
            this.mEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditCut.Size = new System.Drawing.Size(212, 22);
            this.mEditCut.Text = "Вырезать";
            this.mEditCut.Click += new System.EventHandler(this.mEditCut_Click);
            // 
            // mEditCopy
            // 
            this.mEditCopy.Name = "mEditCopy";
            this.mEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditCopy.Size = new System.Drawing.Size(212, 22);
            this.mEditCopy.Text = "Копировать";
            this.mEditCopy.Click += new System.EventHandler(this.mEditCopy_Click);
            // 
            // mEditPaste
            // 
            this.mEditPaste.Name = "mEditPaste";
            this.mEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditPaste.Size = new System.Drawing.Size(212, 22);
            this.mEditPaste.Text = "Вставить";
            this.mEditPaste.Click += new System.EventHandler(this.mEditPaste_Click);
            // 
            // mEditDel
            // 
            this.mEditDel.Name = "mEditDel";
            this.mEditDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mEditDel.Size = new System.Drawing.Size(212, 22);
            this.mEditDel.Text = "Удалить";
            this.mEditDel.Click += new System.EventHandler(this.mEditDel_Click);
            // 
            // mEditFind
            // 
            this.mEditFind.Name = "mEditFind";
            this.mEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mEditFind.Size = new System.Drawing.Size(212, 22);
            this.mEditFind.Text = "Найти и заменить";
            this.mEditFind.Click += new System.EventHandler(this.mEditFind_Click);
            // 
            // mEditGo
            // 
            this.mEditGo.Name = "mEditGo";
            this.mEditGo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mEditGo.Size = new System.Drawing.Size(212, 22);
            this.mEditGo.Text = "Перейти";
            this.mEditGo.Click += new System.EventHandler(this.mEditGo_Click);
            // 
            // mEditGiveAll
            // 
            this.mEditGiveAll.Name = "mEditGiveAll";
            this.mEditGiveAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mEditGiveAll.Size = new System.Drawing.Size(212, 22);
            this.mEditGiveAll.Text = "Выделить всё";
            this.mEditGiveAll.Click += new System.EventHandler(this.mEditGiveAll_Click);
            // 
            // mEditTime
            // 
            this.mEditTime.Name = "mEditTime";
            this.mEditTime.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mEditTime.Size = new System.Drawing.Size(212, 22);
            this.mEditTime.Text = "Время и дата";
            this.mEditTime.Click += new System.EventHandler(this.mEditTime_Click);
            // 
            // Size3
            // 
            this.Size3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size3mFormat,
            this.Size3mVIew,
            this.Size3mHelp});
            this.Size3.Name = "Size3";
            this.Size3.Padding = new System.Windows.Forms.Padding(0);
            this.Size3.Size = new System.Drawing.Size(14, 20);
            this.Size3.Text = ":";
            this.Size3.Visible = false;
            // 
            // Size3mFormat
            // 
            this.Size3mFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size3mFormatTransfer,
            this.Size3mFormatFont});
            this.Size3mFormat.Name = "Size3mFormat";
            this.Size3mFormat.Size = new System.Drawing.Size(120, 22);
            this.Size3mFormat.Text = "Формат";
            // 
            // Size3mFormatTransfer
            // 
            this.Size3mFormatTransfer.CheckOnClick = true;
            this.Size3mFormatTransfer.Name = "Size3mFormatTransfer";
            this.Size3mFormatTransfer.Size = new System.Drawing.Size(183, 22);
            this.Size3mFormatTransfer.Text = "Перенос по словам";
            this.Size3mFormatTransfer.CheckStateChanged += new System.EventHandler(this.mFormatTransfer_CheckStateChanged);
            // 
            // Size3mFormatFont
            // 
            this.Size3mFormatFont.Name = "Size3mFormatFont";
            this.Size3mFormatFont.Size = new System.Drawing.Size(183, 22);
            this.Size3mFormatFont.Text = "Шрифт";
            this.Size3mFormatFont.Click += new System.EventHandler(this.mFormatFont_Click);
            // 
            // Size3mVIew
            // 
            this.Size3mVIew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size3mViewStatusStrip});
            this.Size3mVIew.Name = "Size3mVIew";
            this.Size3mVIew.Size = new System.Drawing.Size(120, 22);
            this.Size3mVIew.Text = "Вид";
            // 
            // Size3mViewStatusStrip
            // 
            this.Size3mViewStatusStrip.Checked = true;
            this.Size3mViewStatusStrip.CheckOnClick = true;
            this.Size3mViewStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Size3mViewStatusStrip.Name = "Size3mViewStatusStrip";
            this.Size3mViewStatusStrip.Size = new System.Drawing.Size(173, 22);
            this.Size3mViewStatusStrip.Text = "Строка состояния";
            this.Size3mViewStatusStrip.CheckStateChanged += new System.EventHandler(this.mViewStatusStrip_CheckStateChanged);
            // 
            // Size3mHelp
            // 
            this.Size3mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size3mHelpAboutProgram});
            this.Size3mHelp.Name = "Size3mHelp";
            this.Size3mHelp.Size = new System.Drawing.Size(120, 22);
            this.Size3mHelp.Text = "Справка";
            // 
            // Size3mHelpAboutProgram
            // 
            this.Size3mHelpAboutProgram.Name = "Size3mHelpAboutProgram";
            this.Size3mHelpAboutProgram.Size = new System.Drawing.Size(149, 22);
            this.Size3mHelpAboutProgram.Text = "О программе";
            this.Size3mHelpAboutProgram.Click += new System.EventHandler(this.mHelpAboutProgram_Click);
            // 
            // mFormat
            // 
            this.mFormat.CheckOnClick = true;
            this.mFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatTransfer,
            this.mFormatFont});
            this.mFormat.Name = "mFormat";
            this.mFormat.Size = new System.Drawing.Size(62, 20);
            this.mFormat.Text = "Формат";
            // 
            // mFormatTransfer
            // 
            this.mFormatTransfer.CheckOnClick = true;
            this.mFormatTransfer.Name = "mFormatTransfer";
            this.mFormatTransfer.Size = new System.Drawing.Size(183, 22);
            this.mFormatTransfer.Text = "Перенос по словам";
            this.mFormatTransfer.CheckStateChanged += new System.EventHandler(this.mFormatTransfer_CheckStateChanged);
            // 
            // mFormatFont
            // 
            this.mFormatFont.Name = "mFormatFont";
            this.mFormatFont.Size = new System.Drawing.Size(183, 22);
            this.mFormatFont.Text = "Шрифт";
            this.mFormatFont.Click += new System.EventHandler(this.mFormatFont_Click);
            // 
            // Size2
            // 
            this.Size2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size2mView,
            this.Size2mHelp});
            this.Size2.Name = "Size2";
            this.Size2.Size = new System.Drawing.Size(22, 20);
            this.Size2.Text = ":";
            this.Size2.Visible = false;
            // 
            // Size2mView
            // 
            this.Size2mView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size2mViewStatusStrip});
            this.Size2mView.Name = "Size2mView";
            this.Size2mView.Size = new System.Drawing.Size(120, 22);
            this.Size2mView.Text = "Вид";
            // 
            // Size2mViewStatusStrip
            // 
            this.Size2mViewStatusStrip.Checked = true;
            this.Size2mViewStatusStrip.CheckOnClick = true;
            this.Size2mViewStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Size2mViewStatusStrip.Name = "Size2mViewStatusStrip";
            this.Size2mViewStatusStrip.Size = new System.Drawing.Size(173, 22);
            this.Size2mViewStatusStrip.Text = "Строка состояния";
            this.Size2mViewStatusStrip.CheckStateChanged += new System.EventHandler(this.mViewStatusStrip_CheckStateChanged);
            // 
            // Size2mHelp
            // 
            this.Size2mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size2mHelpAboutProgram});
            this.Size2mHelp.Name = "Size2mHelp";
            this.Size2mHelp.Size = new System.Drawing.Size(120, 22);
            this.Size2mHelp.Text = "Справка";
            // 
            // Size2mHelpAboutProgram
            // 
            this.Size2mHelpAboutProgram.Name = "Size2mHelpAboutProgram";
            this.Size2mHelpAboutProgram.Size = new System.Drawing.Size(149, 22);
            this.Size2mHelpAboutProgram.Text = "О программе";
            this.Size2mHelpAboutProgram.Click += new System.EventHandler(this.mHelpAboutProgram_Click);
            // 
            // mView
            // 
            this.mView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mViewStatusStrip});
            this.mView.Name = "mView";
            this.mView.Size = new System.Drawing.Size(39, 20);
            this.mView.Text = "Вид";
            // 
            // mViewStatusStrip
            // 
            this.mViewStatusStrip.Checked = true;
            this.mViewStatusStrip.CheckOnClick = true;
            this.mViewStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewStatusStrip.Name = "mViewStatusStrip";
            this.mViewStatusStrip.Size = new System.Drawing.Size(173, 22);
            this.mViewStatusStrip.Text = "Строка состояния";
            this.mViewStatusStrip.CheckStateChanged += new System.EventHandler(this.mViewStatusStrip_CheckStateChanged);
            // 
            // Size1
            // 
            this.Size1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size1mHelp});
            this.Size1.Name = "Size1";
            this.Size1.Size = new System.Drawing.Size(22, 20);
            this.Size1.Text = ":";
            this.Size1.Visible = false;
            // 
            // Size1mHelp
            // 
            this.Size1mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size1mHelpAboutProgram});
            this.Size1mHelp.Name = "Size1mHelp";
            this.Size1mHelp.Size = new System.Drawing.Size(120, 22);
            this.Size1mHelp.Text = "Справка";
            // 
            // Size1mHelpAboutProgram
            // 
            this.Size1mHelpAboutProgram.Name = "Size1mHelpAboutProgram";
            this.Size1mHelpAboutProgram.Size = new System.Drawing.Size(149, 22);
            this.Size1mHelpAboutProgram.Text = "О программе";
            this.Size1mHelpAboutProgram.Click += new System.EventHandler(this.mHelpAboutProgram_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpAboutProgramm});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(65, 20);
            this.mHelp.Text = "Справка";
            // 
            // mHelpAboutProgramm
            // 
            this.mHelpAboutProgramm.Name = "mHelpAboutProgramm";
            this.mHelpAboutProgramm.Size = new System.Drawing.Size(149, 22);
            this.mHelpAboutProgramm.Text = "О программе";
            this.mHelpAboutProgramm.Click += new System.EventHandler(this.mHelpAboutProgram_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLab1,
            this.statusLinesCount,
            this.statusLab2,
            this.statusWordsCount,
            this.statusLab3,
            this.statusCharSpaceCount,
            this.statusLab4,
            this.statusCharCount,
            this.Label,
            this.LabEnc});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(725, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLab1
            // 
            this.statusLab1.Name = "statusLab1";
            this.statusLab1.Size = new System.Drawing.Size(109, 17);
            this.statusLab1.Text = "Количество строк:";
            // 
            // statusLinesCount
            // 
            this.statusLinesCount.Name = "statusLinesCount";
            this.statusLinesCount.Size = new System.Drawing.Size(13, 17);
            this.statusLinesCount.Text = "0";
            // 
            // statusLab2
            // 
            this.statusLab2.Name = "statusLab2";
            this.statusLab2.Size = new System.Drawing.Size(104, 17);
            this.statusLab2.Text = "Количество слов:";
            // 
            // statusWordsCount
            // 
            this.statusWordsCount.Name = "statusWordsCount";
            this.statusWordsCount.Size = new System.Drawing.Size(13, 17);
            this.statusWordsCount.Text = "0";
            // 
            // statusLab3
            // 
            this.statusLab3.Name = "statusLab3";
            this.statusLab3.Size = new System.Drawing.Size(142, 17);
            this.statusLab3.Text = "Символов с пробелами:";
            // 
            // statusCharSpaceCount
            // 
            this.statusCharSpaceCount.Name = "statusCharSpaceCount";
            this.statusCharSpaceCount.Size = new System.Drawing.Size(13, 17);
            this.statusCharSpaceCount.Text = "0";
            // 
            // statusLab4
            // 
            this.statusLab4.Name = "statusLab4";
            this.statusLab4.Size = new System.Drawing.Size(145, 17);
            this.statusLab4.Text = "Символов без пробелов:";
            // 
            // statusCharCount
            // 
            this.statusCharCount.Name = "statusCharCount";
            this.statusCharCount.Size = new System.Drawing.Size(13, 17);
            this.statusCharCount.Text = "0";
            // 
            // Label
            // 
            this.Label.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(10, 20);
            this.Label.Text = "|";
            // 
            // LabEnc
            // 
            this.LabEnc.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LabEnc.Name = "LabEnc";
            this.LabEnc.Size = new System.Drawing.Size(33, 21);
            this.LabEnc.Text = "UTF8";
            // 
            // notebox
            // 
            this.notebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notebox.Location = new System.Drawing.Point(0, 24);
            this.notebox.Multiline = true;
            this.notebox.Name = "notebox";
            this.notebox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.notebox.Size = new System.Drawing.Size(725, 404);
            this.notebox.TabIndex = 2;
            this.notebox.TextChanged += new System.EventHandler(this.notebox_TextChanged);
            // 
            // Pointer
            // 
            this.Pointer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Pointer.AutoSize = true;
            this.Pointer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pointer.Location = new System.Drawing.Point(706, 431);
            this.Pointer.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.Pointer.Name = "Pointer";
            this.Pointer.Size = new System.Drawing.Size(18, 16);
            this.Pointer.TabIndex = 3;
            this.Pointer.Text = "->";
            this.Pointer.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.Pointer);
            this.Controls.Add(this.notebox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(155, 39);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Notebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mFileNew;
        private System.Windows.Forms.ToolStripMenuItem mFiloOpen;
        private System.Windows.Forms.ToolStripMenuItem mFileSave;
        private System.Windows.Forms.ToolStripMenuItem mFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mFilePageParam;
        private System.Windows.Forms.ToolStripMenuItem mFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mFileExit;
        private System.Windows.Forms.ToolStripMenuItem mEdit;
        private System.Windows.Forms.ToolStripMenuItem mEditCancel;
        private System.Windows.Forms.ToolStripMenuItem mEditCut;
        private System.Windows.Forms.ToolStripMenuItem mEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mEditPaste;
        private System.Windows.Forms.ToolStripMenuItem mEditDel;
        private System.Windows.Forms.ToolStripMenuItem mEditFind;
        private System.Windows.Forms.ToolStripMenuItem mEditGo;
        private System.Windows.Forms.ToolStripMenuItem mEditGiveAll;
        private System.Windows.Forms.ToolStripMenuItem mEditTime;
        private System.Windows.Forms.ToolStripMenuItem mFormat;
        private System.Windows.Forms.ToolStripMenuItem mFormatTransfer;
        private System.Windows.Forms.ToolStripMenuItem mFormatFont;
        private System.Windows.Forms.ToolStripMenuItem mView;
        private System.Windows.Forms.ToolStripMenuItem mViewStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mHelpAboutProgramm;
        private System.Windows.Forms.ToolStripMenuItem Size3;
        private System.Windows.Forms.ToolStripMenuItem Size3mFormat;
        private System.Windows.Forms.ToolStripMenuItem Size2;
        private System.Windows.Forms.ToolStripMenuItem Size1;
        private System.Windows.Forms.ToolStripMenuItem Size3mFormatTransfer;
        private System.Windows.Forms.ToolStripMenuItem Size3mFormatFont;
        private System.Windows.Forms.ToolStripMenuItem Size3mVIew;
        private System.Windows.Forms.ToolStripMenuItem Size3mViewStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem Size3mHelp;
        private System.Windows.Forms.ToolStripMenuItem Size3mHelpAboutProgram;
        private System.Windows.Forms.ToolStripMenuItem Size2mView;
        private System.Windows.Forms.ToolStripMenuItem Size2mViewStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem Size2mHelp;
        private System.Windows.Forms.ToolStripMenuItem Size2mHelpAboutProgram;
        private System.Windows.Forms.ToolStripMenuItem Size1mHelp;
        private System.Windows.Forms.ToolStripMenuItem Size1mHelpAboutProgram;
        private System.Windows.Forms.ToolStripStatusLabel statusLab1;
        private System.Windows.Forms.ToolStripStatusLabel statusLinesCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab2;
        private System.Windows.Forms.ToolStripStatusLabel statusWordsCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab3;
        private System.Windows.Forms.ToolStripStatusLabel statusCharSpaceCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab4;
        private System.Windows.Forms.ToolStripStatusLabel statusCharCount;
        private System.Windows.Forms.ToolStripStatusLabel Label;
        private System.Windows.Forms.ToolStripStatusLabel LabEnc;
        public System.Windows.Forms.TextBox notebox;
        private System.Windows.Forms.Label Pointer;
    }
}

