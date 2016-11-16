namespace AutoNS {
    partial class frmMain {
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
            this.spltSideBar = new System.Windows.Forms.SplitContainer();
            this.btnOpenDir = new BoinBoxNS.BoinBox();
            this.explorer = new BoinEditNS.DirTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.spltSideBar)).BeginInit();
            this.spltSideBar.Panel1.SuspendLayout();
            this.spltSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltSideBar
            // 
            this.spltSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltSideBar.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltSideBar.Location = new System.Drawing.Point(0, 0);
            this.spltSideBar.Name = "spltSideBar";
            // 
            // spltSideBar.Panel1
            // 
            this.spltSideBar.Panel1.Controls.Add(this.btnOpenDir);
            this.spltSideBar.Panel1.Controls.Add(this.explorer);
            this.spltSideBar.Panel1MinSize = 4;
            this.spltSideBar.Size = new System.Drawing.Size(648, 386);
            this.spltSideBar.SplitterDistance = 172;
            this.spltSideBar.TabIndex = 1;
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDir.AntiAliased = false;
            this.btnOpenDir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOpenDir.BorderColor = System.Drawing.Color.Empty;
            this.btnOpenDir.BorderSize = 0;
            this.btnOpenDir.FlatAppearance.BorderSize = 0;
            this.btnOpenDir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDir.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnOpenDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOpenDir.Location = new System.Drawing.Point(14, 12);
            this.btnOpenDir.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnOpenDir.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(145, 23);
            this.btnOpenDir.TabIndex = 0;
            this.btnOpenDir.Text = "Open Directory";
            this.btnOpenDir.UseVisualStyleBackColor = false;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // explorer
            // 
            this.explorer.BackColor = System.Drawing.Color.White;
            this.explorer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explorer.dirBackColor = System.Drawing.Color.White;
            this.explorer.dirColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.explorer.directory = null;
            this.explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorer.fileColor = System.Drawing.SystemColors.MenuHighlight;
            this.explorer.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explorer.Location = new System.Drawing.Point(0, 0);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(172, 386);
            this.explorer.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 386);
            this.Controls.Add(this.spltSideBar);
            this.Name = "frmMain";
            this.Text = "Auto";
            this.spltSideBar.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltSideBar)).EndInit();
            this.spltSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BoinEditNS.DirTreeView explorer;
        private System.Windows.Forms.SplitContainer spltSideBar;
        private BoinBoxNS.BoinBox btnOpenDir;


    }
}