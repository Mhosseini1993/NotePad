using NotePad.Utilities;
using System.Diagnostics;

namespace NotePad
{
    public partial class frmMainWindow : Form
    {
        private bool isDocumentChanged = false;
        private string savePath = string.Empty;
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            txtDocument.Font=fontDialog.Font;
        }
        private void btnNewDocument_Click(object sender, EventArgs e)
        {
            if (isDocumentChanged)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "information",
                          MessageBoxButtons.YesNoCancel,
                          MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1);

                if (dialogResult == DialogResult.Yes)
                {
                    SaveAs();
                }
                else if (dialogResult==DialogResult.No)
                {
                    txtDocument.Clear();
                    isDocumentChanged=false;
                }
                else
                {

                }
            }
        }

        private void SaveAs()
        {
            var saveResult = saveFileDialog.ShowDialog();
            if (saveResult==DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    streamWriter.Write(txtDocument.Text);
                    savePath=saveFileDialog.FileName;
                }
                txtDocument.Clear();
                isDocumentChanged=false;
            }
        }

        private void txtDocument_TextChanged(object sender, EventArgs e)
        {
            isDocumentChanged=true;
            lblCharCount.Text=txtDocument.Text.Length.ToString();
            lblWordCount.Text=(txtDocument.Text.Split(' ').Length-1).ToString();
            
        }

        private void btnOpenDocument_Click(object sender, EventArgs e)
        {
            DialogResult openResult = openFileDialog.ShowDialog();
            if (openResult==DialogResult.OK)
            {
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    txtDocument.Text=streamReader.ReadToEnd();
                    isDocumentChanged=false;
                }
            }
        }

        private void btnOpenNewForm_Click(object sender, EventArgs e)
        {
            //new frmMainWindow().Show();
            Process.Start(Process.GetCurrentProcess().ProcessName);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(savePath))
            {
                SaveAs();
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(savePath))
                {
                    streamWriter.Write(txtDocument.Text);
                }
            }

        }
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            DialogResult fontResult = fontDialog.ShowDialog();
            if (fontResult==DialogResult.OK)
            {
                txtDocument.Font=fontDialog.Font;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void frmMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDocumentChanged)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "Information",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1);

                if (dialogResult == DialogResult.Yes)
                {
                    SaveAs();
                }
            }
        }

        private void btnShowStatusBar_Click(object sender, EventArgs e)
        {
            btnShowStatusBar.Checked=!btnShowStatusBar.Checked;
            StatusStrip.Visible=btnShowStatusBar.Checked;
        }

        private void btnShowToolStrip_Click(object sender, EventArgs e)
        {
            btnShowToolStrip.Checked=!btnShowToolStrip.Checked;
            toolStrip.Visible=btnShowToolStrip.Checked;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDocument.SelectedText))
                Clipboard.SetText(txtDocument.SelectedText);
            else
                Clipboard.SetText(txtDocument.Text);

            //txtDocument.Copy();
        }
        private void btnCut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDocument.SelectedText))
            {
                //txtDocument.Cut();
                Clipboard.SetText(txtDocument.SelectedText);
                txtDocument.Text=txtDocument.Text.Replace(txtDocument.SelectedText, "");
            }
            else
            {
                Clipboard.SetText(txtDocument.Text);
                txtDocument.Text=txtDocument.Text.Replace(txtDocument.Text, "");
            }
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            //txtDocument.Paste();
            if (Clipboard.ContainsText())
                txtDocument.Text+=Clipboard.GetText(TextDataFormat.UnicodeText).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDocument.SelectedText))
                txtDocument.Text=txtDocument.Text.Replace(txtDocument.SelectedText, "");
            else
                txtDocument.Text=txtDocument.Text.Replace(txtDocument.Text, "");
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            txtDocument.SelectAll();
        }

        private void btnInsertDate_Click(object sender, EventArgs e)
        {
            txtDocument.Text+=$" {DateTime.Now.MiladiToShamsi()}";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog.Document=printDocument;
            if (printDialog.ShowDialog()==DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch(this);
            frm.ShowDialog();
            txtDocument.SelectionBackColor = Color.White;   
        }
    }
}