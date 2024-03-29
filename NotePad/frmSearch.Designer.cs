﻿namespace NotePad
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
            label1 = new Label();
            txtSearchTerm = new TextBox();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            rbnMatchCase = new RadioButton();
            rbnWholeWord = new RadioButton();
            groupBox2 = new GroupBox();
            rbnDownUp = new RadioButton();
            rbnUpDown = new RadioButton();
            statusStrip1 = new StatusStrip();
            label = new ToolStripStatusLabel();
            lblFindCount = new ToolStripStatusLabel();
            btnReplace = new Button();
            btnReplaceAll = new Button();
            btnCancel = new Button();
            txtReplace = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 26);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 0;
            label1.Text = "&Find what:";
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Location = new Point(102, 22);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.Size = new Size(353, 26);
            txtSearchTerm.TabIndex = 1;
            txtSearchTerm.TextChanged += txtSearchTerm_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(460, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 26);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "S&earch";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbnMatchCase);
            groupBox1.Controls.Add(rbnWholeWord);
            groupBox1.Location = new Point(2, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 82);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Type";
            // 
            // rbnMatchCase
            // 
            rbnMatchCase.AutoSize = true;
            rbnMatchCase.Location = new Point(7, 55);
            rbnMatchCase.Name = "rbnMatchCase";
            rbnMatchCase.Size = new Size(114, 22);
            rbnMatchCase.TabIndex = 1;
            rbnMatchCase.Text = "W&rap around";
            rbnMatchCase.UseVisualStyleBackColor = true;
            // 
            // rbnWholeWord
            // 
            rbnWholeWord.AutoSize = true;
            rbnWholeWord.Checked = true;
            rbnWholeWord.Location = new Point(7, 27);
            rbnWholeWord.Name = "rbnWholeWord";
            rbnWholeWord.Size = new Size(106, 22);
            rbnWholeWord.TabIndex = 0;
            rbnWholeWord.TabStop = true;
            rbnWholeWord.Text = "Match C&ase";
            rbnWholeWord.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbnDownUp);
            groupBox2.Controls.Add(rbnUpDown);
            groupBox2.Location = new Point(222, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(214, 82);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Direction";
            // 
            // rbnDownUp
            // 
            rbnDownUp.AutoSize = true;
            rbnDownUp.Location = new Point(8, 54);
            rbnDownUp.Name = "rbnDownUp";
            rbnDownUp.Size = new Size(106, 22);
            rbnDownUp.TabIndex = 3;
            rbnDownUp.Text = "Down to &Up";
            rbnDownUp.UseVisualStyleBackColor = true;
            // 
            // rbnUpDown
            // 
            rbnUpDown.AutoSize = true;
            rbnUpDown.Checked = true;
            rbnUpDown.Location = new Point(8, 26);
            rbnUpDown.Name = "rbnUpDown";
            rbnUpDown.Size = new Size(106, 22);
            rbnUpDown.TabIndex = 2;
            rbnUpDown.TabStop = true;
            rbnUpDown.Text = "Up to Down";
            rbnUpDown.UseVisualStyleBackColor = true;
            rbnUpDown.CheckedChanged += rbnUpDown_CheckedChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { label, lblFindCount });
            statusStrip1.Location = new Point(0, 195);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(586, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // label
            // 
            label.Name = "label";
            label.Size = new Size(92, 20);
            label.Text = "Total Count :";
            // 
            // lblFindCount
            // 
            lblFindCount.Name = "lblFindCount";
            lblFindCount.Size = new Size(17, 20);
            lblFindCount.Text = "0";
            // 
            // btnReplace
            // 
            btnReplace.Location = new Point(460, 56);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(94, 26);
            btnReplace.TabIndex = 6;
            btnReplace.Text = "&Replace";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // btnReplaceAll
            // 
            btnReplaceAll.Location = new Point(460, 87);
            btnReplaceAll.Name = "btnReplaceAll";
            btnReplaceAll.Size = new Size(94, 26);
            btnReplaceAll.TabIndex = 7;
            btnReplaceAll.Text = "Replace &All";
            btnReplaceAll.UseVisualStyleBackColor = true;
            btnReplaceAll.Click += btnReplaceAll_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(460, 119);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 26);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Can&cel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtReplace
            // 
            txtReplace.Location = new Point(102, 56);
            txtReplace.Name = "txtReplace";
            txtReplace.Size = new Size(353, 26);
            txtReplace.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 60);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 9;
            label2.Text = "Rep&lace with:";
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 221);
            Controls.Add(txtReplace);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnReplaceAll);
            Controls.Add(btnReplace);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchTerm);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblFindCount;
        private ToolStripStatusLabel label;
        private Button btnReplace;
        private Button btnReplaceAll;
        private Button btnCancel;
        private TextBox txtReplace;
        private Label label2;
    }
}