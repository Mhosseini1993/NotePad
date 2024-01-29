using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class frmSearch : Form
    {
        private readonly frmMainWindow frmMainWindow;
        int startIndex = 0;
        public frmSearch(frmMainWindow frmMainWindow)
        {
            InitializeComponent();
            this.frmMainWindow=frmMainWindow;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmMainWindow.txtDocument.SelectionBackColor=Color.White;
            startIndex=Search(txtSearchTerm.Text, startIndex);

        }
        private int Search(string term, int startIndex)
        {
            int occuranceIndex = 0;
            if (startIndex>=0 &&
                startIndex<frmMainWindow.txtDocument.Text.Length &&
                (occuranceIndex=frmMainWindow.txtDocument.Find(term, startIndex, (rbnWholeWord.Checked) ? RichTextBoxFinds.WholeWord : RichTextBoxFinds.MatchCase))>=0)
            {
                frmMainWindow.txtDocument.SelectionStart= occuranceIndex;
                frmMainWindow.txtDocument.SelectionLength=term.Length;
                frmMainWindow.txtDocument.SelectionBackColor=Color.Yellow;
                startIndex=occuranceIndex+term.Length;
                startIndex+=1;
            }
            else
            {
                startIndex=0;
            }
            return startIndex;
        }
    }
}
