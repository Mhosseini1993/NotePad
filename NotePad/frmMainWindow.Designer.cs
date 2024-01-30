namespace NotePad
{
    partial class frmMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            MainMenu = new MenuStrip();
            فایلToolStripMenuItem = new ToolStripMenuItem();
            btnNewDocument = new ToolStripMenuItem();
            btnOpenDocument = new ToolStripMenuItem();
            btnOpenNewForm = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btnSave = new ToolStripMenuItem();
            btnSaveAs = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            btnPrint = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            btnExit = new ToolStripMenuItem();
            ویرایشToolStripMenuItem = new ToolStripMenuItem();
            btnUndo = new ToolStripMenuItem();
            btnPaste = new ToolStripMenuItem();
            btnCopy = new ToolStripMenuItem();
            btnCut = new ToolStripMenuItem();
            btnDelete = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            btnSearch = new ToolStripMenuItem();
            جایگزینToolStripMenuItem = new ToolStripMenuItem();
            btnSelectAll = new ToolStripMenuItem();
            btnInsertDate = new ToolStripMenuItem();
            قالببندیToolStripMenuItem = new ToolStripMenuItem();
            btnChangeFont = new ToolStripMenuItem();
            نماToolStripMenuItem = new ToolStripMenuItem();
            btnShowStatusBar = new ToolStripMenuItem();
            btnShowToolStrip = new ToolStripMenuItem();
            راهنماToolStripMenuItem = new ToolStripMenuItem();
            راهنمایاستفادهازبرنامهToolStripMenuItem = new ToolStripMenuItem();
            گزارشخطاToolStripMenuItem = new ToolStripMenuItem();
            دربارهماToolStripMenuItem = new ToolStripMenuItem();
            StatusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblCharCount = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            lblWordCount = new ToolStripStatusLabel();
            txtDocument = new RichTextBox();
            toolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripButton();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            fontDialog = new FontDialog();
            printDialog = new PrintDialog();
            printDocument = new System.Drawing.Printing.PrintDocument();
            MainMenu.SuspendLayout();
            StatusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.ImageScalingSize = new Size(20, 20);
            MainMenu.Items.AddRange(new ToolStripItem[] { فایلToolStripMenuItem, ویرایشToolStripMenuItem, قالببندیToolStripMenuItem, نماToolStripMenuItem, راهنماToolStripMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Padding = new Padding(7, 3, 0, 3);
            MainMenu.Size = new Size(880, 30);
            MainMenu.TabIndex = 0;
            MainMenu.Text = "menuStrip1";
            // 
            // فایلToolStripMenuItem
            // 
            فایلToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnNewDocument, btnOpenDocument, btnOpenNewForm, toolStripSeparator1, btnSave, btnSaveAs, toolStripSeparator2, btnPrint, toolStripSeparator3, btnExit });
            فایلToolStripMenuItem.Name = "فایلToolStripMenuItem";
            فایلToolStripMenuItem.Size = new Size(46, 24);
            فایلToolStripMenuItem.Text = "File";
            // 
            // btnNewDocument
            // 
            btnNewDocument.Image = Properties.Resources._new;
            btnNewDocument.Name = "btnNewDocument";
            btnNewDocument.ShortcutKeys = Keys.Control | Keys.N;
            btnNewDocument.Size = new Size(274, 26);
            btnNewDocument.Text = "New";
            btnNewDocument.Click += btnNewDocument_Click;
            // 
            // btnOpenDocument
            // 
            btnOpenDocument.Image = Properties.Resources.open_file_button;
            btnOpenDocument.Name = "btnOpenDocument";
            btnOpenDocument.ShortcutKeys = Keys.Control | Keys.O;
            btnOpenDocument.Size = new Size(274, 26);
            btnOpenDocument.Text = "Open Document";
            btnOpenDocument.Click += btnOpenDocument_Click;
            // 
            // btnOpenNewForm
            // 
            btnOpenNewForm.Image = Properties.Resources.new_window;
            btnOpenNewForm.Name = "btnOpenNewForm";
            btnOpenNewForm.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            btnOpenNewForm.Size = new Size(274, 26);
            btnOpenNewForm.Text = "New Window";
            btnOpenNewForm.Click += btnOpenNewForm_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(271, 6);
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.floppy_disk;
            btnSave.Name = "btnSave";
            btnSave.ShortcutKeys = Keys.Control | Keys.S;
            btnSave.Size = new Size(274, 26);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnSaveAs
            // 
            btnSaveAs.Image = Properties.Resources.save_as;
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            btnSaveAs.Size = new Size(274, 26);
            btnSaveAs.Text = "Save As...";
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(271, 6);
            // 
            // btnPrint
            // 
            btnPrint.Image = Properties.Resources.printing;
            btnPrint.Name = "btnPrint";
            btnPrint.ShortcutKeys = Keys.Control | Keys.P;
            btnPrint.Size = new Size(274, 26);
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(271, 6);
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.exit;
            btnExit.Name = "btnExit";
            btnExit.ShortcutKeys = Keys.F4;
            btnExit.Size = new Size(274, 26);
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // ویرایشToolStripMenuItem
            // 
            ویرایشToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnUndo, btnPaste, btnCopy, btnCut, btnDelete, toolStripSeparator4, btnSearch, جایگزینToolStripMenuItem, btnSelectAll, btnInsertDate });
            ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            ویرایشToolStripMenuItem.Size = new Size(49, 24);
            ویرایشToolStripMenuItem.Text = "Edit";
            // 
            // btnUndo
            // 
            btnUndo.Image = Properties.Resources.undo;
            btnUndo.Name = "btnUndo";
            btnUndo.ShortcutKeys = Keys.Control | Keys.Z;
            btnUndo.Size = new Size(287, 26);
            btnUndo.Text = "Undo";
            // 
            // btnPaste
            // 
            btnPaste.Image = Properties.Resources.paste;
            btnPaste.Name = "btnPaste";
            btnPaste.ShortcutKeys = Keys.Control | Keys.V;
            btnPaste.Size = new Size(287, 26);
            btnPaste.Text = "Paste";
            btnPaste.Click += btnPaste_Click;
            // 
            // btnCopy
            // 
            btnCopy.Image = Properties.Resources.copy;
            btnCopy.Name = "btnCopy";
            btnCopy.ShortcutKeys = Keys.Control | Keys.C;
            btnCopy.Size = new Size(287, 26);
            btnCopy.Text = "Copy";
            btnCopy.Click += btnCopy_Click;
            // 
            // btnCut
            // 
            btnCut.Image = Properties.Resources.scissors;
            btnCut.Name = "btnCut";
            btnCut.ShortcutKeys = Keys.Control | Keys.X;
            btnCut.Size = new Size(287, 26);
            btnCut.Text = "Cut";
            btnCut.Click += btnCut_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.trash;
            btnDelete.Name = "btnDelete";
            btnDelete.ShortcutKeys = Keys.Delete;
            btnDelete.Size = new Size(287, 26);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(284, 6);
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.magnifying_glass;
            btnSearch.Name = "btnSearch";
            btnSearch.ShortcutKeys = Keys.Control | Keys.F;
            btnSearch.Size = new Size(287, 26);
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // جایگزینToolStripMenuItem
            // 
            جایگزینToolStripMenuItem.Image = Properties.Resources.replace__1_;
            جایگزینToolStripMenuItem.Name = "جایگزینToolStripMenuItem";
            جایگزینToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            جایگزینToolStripMenuItem.Size = new Size(287, 26);
            جایگزینToolStripMenuItem.Text = "Replace";
            // 
            // btnSelectAll
            // 
            btnSelectAll.Image = Properties.Resources.selection;
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.ShortcutKeys = Keys.Control | Keys.A;
            btnSelectAll.Size = new Size(287, 26);
            btnSelectAll.Text = "select All";
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // btnInsertDate
            // 
            btnInsertDate.Name = "btnInsertDate";
            btnInsertDate.ShortcutKeys = Keys.Control | Keys.Shift | Keys.T;
            btnInsertDate.Size = new Size(287, 26);
            btnInsertDate.Text = "Insert DateTime";
            btnInsertDate.Click += btnInsertDate_Click;
            // 
            // قالببندیToolStripMenuItem
            // 
            قالببندیToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnChangeFont });
            قالببندیToolStripMenuItem.Name = "قالببندیToolStripMenuItem";
            قالببندیToolStripMenuItem.Size = new Size(70, 24);
            قالببندیToolStripMenuItem.Text = "Format";
            // 
            // btnChangeFont
            // 
            btnChangeFont.Image = Properties.Resources.font;
            btnChangeFont.Name = "btnChangeFont";
            btnChangeFont.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            btnChangeFont.Size = new Size(219, 26);
            btnChangeFont.Text = "Font...";
            btnChangeFont.Click += btnChangeFont_Click;
            // 
            // نماToolStripMenuItem
            // 
            نماToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnShowStatusBar, btnShowToolStrip });
            نماToolStripMenuItem.Name = "نماToolStripMenuItem";
            نماToolStripMenuItem.Size = new Size(55, 24);
            نماToolStripMenuItem.Text = "View";
            // 
            // btnShowStatusBar
            // 
            btnShowStatusBar.Checked = true;
            btnShowStatusBar.CheckState = CheckState.Checked;
            btnShowStatusBar.Name = "btnShowStatusBar";
            btnShowStatusBar.Size = new Size(194, 26);
            btnShowStatusBar.Text = "Show Statusbar";
            btnShowStatusBar.Click += btnShowStatusBar_Click;
            // 
            // btnShowToolStrip
            // 
            btnShowToolStrip.Checked = true;
            btnShowToolStrip.CheckState = CheckState.Checked;
            btnShowToolStrip.Name = "btnShowToolStrip";
            btnShowToolStrip.Size = new Size(194, 26);
            btnShowToolStrip.Text = "Show Toolbox";
            btnShowToolStrip.Click += btnShowToolStrip_Click;
            // 
            // راهنماToolStripMenuItem
            // 
            راهنماToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { راهنمایاستفادهازبرنامهToolStripMenuItem, گزارشخطاToolStripMenuItem, دربارهماToolStripMenuItem });
            راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            راهنماToolStripMenuItem.Size = new Size(55, 24);
            راهنماToolStripMenuItem.Text = "Help";
            // 
            // راهنمایاستفادهازبرنامهToolStripMenuItem
            // 
            راهنمایاستفادهازبرنامهToolStripMenuItem.Image = Properties.Resources.question;
            راهنمایاستفادهازبرنامهToolStripMenuItem.Name = "راهنمایاستفادهازبرنامهToolStripMenuItem";
            راهنمایاستفادهازبرنامهToolStripMenuItem.ShortcutKeys = Keys.F1;
            راهنمایاستفادهازبرنامهToolStripMenuItem.Size = new Size(172, 26);
            راهنمایاستفادهازبرنامهToolStripMenuItem.Text = "Help";
            // 
            // گزارشخطاToolStripMenuItem
            // 
            گزارشخطاToolStripMenuItem.Name = "گزارشخطاToolStripMenuItem";
            گزارشخطاToolStripMenuItem.Size = new Size(172, 26);
            گزارشخطاToolStripMenuItem.Text = "Report Logs";
            // 
            // دربارهماToolStripMenuItem
            // 
            دربارهماToolStripMenuItem.Image = Properties.Resources.contract;
            دربارهماToolStripMenuItem.Name = "دربارهماToolStripMenuItem";
            دربارهماToolStripMenuItem.Size = new Size(172, 26);
            دربارهماToolStripMenuItem.Text = "About";
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(20, 20);
            StatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblCharCount, toolStripStatusLabel3, lblWordCount });
            StatusStrip.Location = new Point(0, 490);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Padding = new Padding(16, 0, 1, 0);
            StatusStrip.Size = new Size(880, 26);
            StatusStrip.TabIndex = 1;
            StatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(122, 20);
            toolStripStatusLabel1.Text = "Character Count :";
            // 
            // lblCharCount
            // 
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(17, 20);
            lblCharCount.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(95, 20);
            toolStripStatusLabel3.Text = "Word Count :";
            // 
            // lblWordCount
            // 
            lblWordCount.Name = "lblWordCount";
            lblWordCount.Size = new Size(17, 20);
            lblWordCount.Text = "0";
            // 
            // txtDocument
            // 
            txtDocument.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDocument.Location = new Point(0, 69);
            txtDocument.Margin = new Padding(3, 4, 3, 4);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(879, 416);
            txtDocument.TabIndex = 2;
            txtDocument.Text = " ";
            txtDocument.TextChanged += txtDocument_TextChanged;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripSeparator5, toolStripButton5, toolStripButton6, toolStripSeparator6, toolStripComboBox1, toolStripSeparator7, toolStripButton7 });
            toolStrip.Location = new Point(0, 30);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(880, 28);
            toolStrip.TabIndex = 3;
            toolStrip.Text = " ";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.copy;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 25);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.paste;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 25);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.scissors;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 25);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.undo;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 25);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 28);
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.replace__1_;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 25);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = Properties.Resources.magnifying_glass;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(29, 25);
            toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 28);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(138, 28);
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 28);
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = Properties.Resources.printing;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(29, 25);
            toolStripButton7.Text = "toolStripButton7";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "*.txt";
            saveFileDialog.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.Title = "ذخیره سند دفترچه یادداشت";
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "*.txt";
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog.Title = "باز کردن سند";
            // 
            // fontDialog
            // 
            fontDialog.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // printDialog
            // 
            printDialog.UseEXDialog = true;
            // 
            // frmMainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 516);
            Controls.Add(toolStrip);
            Controls.Add(txtDocument);
            Controls.Add(StatusStrip);
            Controls.Add(MainMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MainMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotePad";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMainWindow_FormClosing;
            Load += frmMainWindow_Load;
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenu;
        private StatusStrip StatusStrip;
        private ToolStripMenuItem فایلToolStripMenuItem;
        private ToolStripMenuItem btnNewDocument;
        private ToolStripMenuItem btnOpenDocument;
        private ToolStripMenuItem btnOpenNewForm;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem btnSave;
        private ToolStripMenuItem btnSaveAs;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem btnPrint;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem btnExit;
        private ToolStripMenuItem ویرایشToolStripMenuItem;
        private ToolStripMenuItem btnUndo;
        private ToolStripMenuItem btnPaste;
        private ToolStripMenuItem رونوشتToolStripMenuItem;
        private ToolStripMenuItem btnCut;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem btnSearch;
        private ToolStripMenuItem جایگزینToolStripMenuItem;
        private ToolStripMenuItem btnSelectAll;
        private ToolStripMenuItem btnInsertDate;
        private ToolStripMenuItem قالببندیToolStripMenuItem;
        private ToolStripMenuItem btnChangeFont;
        private ToolStripMenuItem نماToolStripMenuItem;
        private ToolStripMenuItem btnShowStatusBar;
        private ToolStripMenuItem btnShowToolStrip;
        private ToolStripMenuItem راهنماToolStripMenuItem;
        private ToolStripMenuItem راهنمایاستفادهازبرنامهToolStripMenuItem;
        private ToolStripMenuItem گزارشخطاToolStripMenuItem;
        private ToolStripMenuItem دربارهماToolStripMenuItem;
        private ToolStripMenuItem btnCopy;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblCharCount;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblWordCount;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButton7;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private FontDialog fontDialog;
        private ToolStripMenuItem btnDelete;
        private PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        public RichTextBox txtDocument;
    }
}