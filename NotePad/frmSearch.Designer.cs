namespace NotePad
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            txtSearchTerm=new TextBox();
            btnSearch=new Button();
            groupBox1=new GroupBox();
            rbnMatchCase=new RadioButton();
            rbnWholeWord=new RadioButton();
            groupBox2=new GroupBox();
            rbnDownUp=new RadioButton();
            rbnUpDown=new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            label1.AutoSize=true;
            label1.Location=new Point(2, 26);
            label1.Name="label1";
            label1.Size=new Size(34, 14);
            label1.TabIndex=0;
            label1.Text="متن :";
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            txtSearchTerm.Location=new Point(40, 22);
            txtSearchTerm.Name="txtSearchTerm";
            txtSearchTerm.Size=new Size(410, 22);
            txtSearchTerm.TabIndex=1;
            // 
            // btnSearch
            // 
            btnSearch.Location=new Point(463, 22);
            btnSearch.Name="btnSearch";
            btnSearch.Size=new Size(75, 23);
            btnSearch.TabIndex=2;
            btnSearch.Text="جستجو";
            btnSearch.UseVisualStyleBackColor=true;
            btnSearch.Click+=btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbnMatchCase);
            groupBox1.Controls.Add(rbnWholeWord);
            groupBox1.Location=new Point(2, 59);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(214, 82);
            groupBox1.TabIndex=3;
            groupBox1.TabStop=false;
            groupBox1.Text="نحوه جستجو";
            // 
            // rbnMatchCase
            // 
            rbnMatchCase.AutoSize=true;
            rbnMatchCase.Location=new Point(70, 55);
            rbnMatchCase.Name="rbnMatchCase";
            rbnMatchCase.Size=new Size(133, 18);
            rbnMatchCase.TabIndex=1;
            rbnMatchCase.Text="شامل این کلمه باشد";
            rbnMatchCase.UseVisualStyleBackColor=true;
            // 
            // rbnWholeWord
            // 
            rbnWholeWord.AutoSize=true;
            rbnWholeWord.Checked=true;
            rbnWholeWord.Location=new Point(93, 27);
            rbnWholeWord.Name="rbnWholeWord";
            rbnWholeWord.Size=new Size(110, 18);
            rbnWholeWord.TabIndex=0;
            rbnWholeWord.TabStop=true;
            rbnWholeWord.Text="دقیقا همین کلمه";
            rbnWholeWord.UseVisualStyleBackColor=true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbnDownUp);
            groupBox2.Controls.Add(rbnUpDown);
            groupBox2.Location=new Point(222, 59);
            groupBox2.Name="groupBox2";
            groupBox2.Size=new Size(214, 82);
            groupBox2.TabIndex=4;
            groupBox2.TabStop=false;
            groupBox2.Text="جهت جستحو";
            // 
            // rbnDownUp
            // 
            rbnDownUp.AutoSize=true;
            rbnDownUp.Location=new Point(125, 55);
            rbnDownUp.Name="rbnDownUp";
            rbnDownUp.Size=new Size(80, 18);
            rbnDownUp.TabIndex=3;
            rbnDownUp.Text="پایین به بالا";
            rbnDownUp.UseVisualStyleBackColor=true;
            // 
            // rbnUpDown
            // 
            rbnUpDown.AutoSize=true;
            rbnUpDown.Checked=true;
            rbnUpDown.Location=new Point(125, 27);
            rbnUpDown.Name="rbnUpDown";
            rbnUpDown.Size=new Size(80, 18);
            rbnUpDown.TabIndex=2;
            rbnUpDown.TabStop=true;
            rbnUpDown.Text="بالا به پایین";
            rbnUpDown.UseVisualStyleBackColor=true;
            // 
            // frmSearch
            // 
            AutoScaleDimensions=new SizeF(7F, 14F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(550, 142);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchTerm);
            Controls.Add(label1);
            Font=new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle=FormBorderStyle.FixedToolWindow;
            Name="frmSearch";
            RightToLeft=RightToLeft.Yes;
            RightToLeftLayout=true;
            StartPosition=FormStartPosition.CenterScreen;
            Text="فرم جستجو";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearchTerm;
        private Button btnSearch;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbnMatchCase;
        private RadioButton rbnWholeWord;
        private RadioButton rbnDownUp;
        private RadioButton rbnUpDown;
    }
}