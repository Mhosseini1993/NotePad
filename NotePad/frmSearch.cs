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
        List<SearchResult> results;
        int currentIndex = 0;
        public frmSearch(frmMainWindow frmMainWindow)
        {
            InitializeComponent();
            this.frmMainWindow=frmMainWindow;
            results= new List<SearchResult>();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //frmMainWindow.txtDocument.SelectionBackColor=Color.White;
            //startIndex=Search(txtSearchTerm.Text, startIndex);

            if (!results.Any())
            {
                results= Search(txtSearchTerm.Text);
            }
            if (!results.Any())
            {
                currentIndex=0;
                MessageBox.Show("Not found!!");
            }
            else
            {
                HighLightSelectedText();
            }
        }

        private void HighLightSelectedText()
        {
            try
            {
                frmMainWindow.txtDocument.SelectionBackColor=Color.White;
                frmMainWindow.txtDocument.SelectionStart= results[currentIndex].SelectionStart;
                frmMainWindow.txtDocument.SelectionLength=results[currentIndex].SelectionLength;
                frmMainWindow.txtDocument.SelectionBackColor=Color.Yellow;
                currentIndex=(rbnUpDown.Checked ? (currentIndex+1) : (currentIndex-1))%results.Count;
            }
            catch (Exception)
            {
                if (currentIndex<0)
                    currentIndex=results.Count-1;
            }
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
        private List<SearchResult> Search(string term)
        {
            List<SearchResult> results = new List<SearchResult>();
            int startIndex = 0;
            while (startIndex<frmMainWindow.txtDocument.Text.Length &&
                (startIndex=frmMainWindow.txtDocument.Find(term, startIndex,
                                                                (rbnWholeWord.Checked) ?
                                                                RichTextBoxFinds.WholeWord :
                                                                RichTextBoxFinds.MatchCase))>=0)
            {
                results.Add(new SearchResult()
                {
                    SelectionStart=startIndex,
                    SelectionLength=term.Length,
                });
                startIndex=startIndex+term.Length;
            }
            return results;
        }

        private void rbnUpDown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnUpDown.Checked)
            {
                currentIndex=0;
            }
            else
            {
                currentIndex=results.Count-1;
            }
            HighLightSelectedText();

        }
    }
}
