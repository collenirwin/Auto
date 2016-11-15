namespace AutoNS {
    partial class frmTestSeparateDirs {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnTest = new System.Windows.Forms.Button();
            this.txtDirPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutDirPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegEx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(326, 157);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtDirPath
            // 
            this.txtDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirPath.Location = new System.Drawing.Point(12, 26);
            this.txtDirPath.Name = "txtDirPath";
            this.txtDirPath.Size = new System.Drawing.Size(389, 20);
            this.txtDirPath.TabIndex = 14;
            this.txtDirPath.Text = "\\TestSepDirs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Directory Path";
            // 
            // txtOutDirPath
            // 
            this.txtOutDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutDirPath.Location = new System.Drawing.Point(12, 65);
            this.txtOutDirPath.Name = "txtOutDirPath";
            this.txtOutDirPath.Size = new System.Drawing.Size(389, 20);
            this.txtOutDirPath.TabIndex = 16;
            this.txtOutDirPath.Text = "\\TestSepDirs\\NewDir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Output Directory Path";
            // 
            // txtRegEx
            // 
            this.txtRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegEx.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegEx.Location = new System.Drawing.Point(12, 105);
            this.txtRegEx.Name = "txtRegEx";
            this.txtRegEx.Size = new System.Drawing.Size(389, 20);
            this.txtRegEx.TabIndex = 18;
            this.txtRegEx.Text = "[^_]*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "RegEx Match String";
            // 
            // frmTestSeparateDirs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 192);
            this.Controls.Add(this.txtRegEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutDirPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDirPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Name = "frmTestSeparateDirs";
            this.Text = "frmTestSeparateDirs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtDirPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutDirPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegEx;
        private System.Windows.Forms.Label label3;
    }
}