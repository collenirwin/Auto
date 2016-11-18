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
            this.spltMain = new System.Windows.Forms.SplitContainer();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.txtConsoleInput = new System.Windows.Forms.RichTextBox();
            this.btnOpenDir = new BoinBoxNS.BoinBox();
            this.explorer = new BoinEditNS.DirTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.spltSideBar)).BeginInit();
            this.spltSideBar.Panel1.SuspendLayout();
            this.spltSideBar.Panel2.SuspendLayout();
            this.spltSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).BeginInit();
            this.spltMain.Panel2.SuspendLayout();
            this.spltMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltSideBar
            // 
            this.spltSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltSideBar.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltSideBar.Location = new System.Drawing.Point(0, 24);
            this.spltSideBar.Name = "spltSideBar";
            // 
            // spltSideBar.Panel1
            // 
            this.spltSideBar.Panel1.Controls.Add(this.btnOpenDir);
            this.spltSideBar.Panel1.Controls.Add(this.explorer);
            this.spltSideBar.Panel1MinSize = 4;
            // 
            // spltSideBar.Panel2
            // 
            this.spltSideBar.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.spltSideBar.Panel2.Controls.Add(this.spltMain);
            this.spltSideBar.Size = new System.Drawing.Size(648, 362);
            this.spltSideBar.SplitterDistance = 172;
            this.spltSideBar.TabIndex = 1;
            // 
            // spltMain
            // 
            this.spltMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spltMain.Location = new System.Drawing.Point(0, 0);
            this.spltMain.Name = "spltMain";
            this.spltMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltMain.Panel2
            // 
            this.spltMain.Panel2.Controls.Add(this.txtConsole);
            this.spltMain.Panel2.Controls.Add(this.txtConsoleInput);
            this.spltMain.Size = new System.Drawing.Size(472, 362);
            this.spltMain.SplitterDistance = 204;
            this.spltMain.TabIndex = 0;
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.White;
            this.msMain.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.vIEWToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(648, 24);
            this.msMain.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirectoryToolStripMenuItem,
            this.extractArchiveToolStripMenuItem,
            this.organizeFilesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "FILE";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalSettingsToolStripMenuItem,
            this.organizeSettingsToolStripMenuItem,
            this.runSettingsToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openDirectoryToolStripMenuItem.Text = "Open Directory";
            this.openDirectoryToolStripMenuItem.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // extractArchiveToolStripMenuItem
            // 
            this.extractArchiveToolStripMenuItem.Name = "extractArchiveToolStripMenuItem";
            this.extractArchiveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.extractArchiveToolStripMenuItem.Text = "Extract Archive";
            this.extractArchiveToolStripMenuItem.Click += new System.EventHandler(this.extractArchiveToolStripMenuItem_Click);
            // 
            // organizeFilesToolStripMenuItem
            // 
            this.organizeFilesToolStripMenuItem.Name = "organizeFilesToolStripMenuItem";
            this.organizeFilesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.organizeFilesToolStripMenuItem.Text = "Organize";
            this.organizeFilesToolStripMenuItem.Click += new System.EventHandler(this.organizeFilesToolStripMenuItem_Click);
            // 
            // runSettingsToolStripMenuItem
            // 
            this.runSettingsToolStripMenuItem.Name = "runSettingsToolStripMenuItem";
            this.runSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.runSettingsToolStripMenuItem.Text = "Run Settings";
            // 
            // organizeSettingsToolStripMenuItem
            // 
            this.organizeSettingsToolStripMenuItem.Name = "organizeSettingsToolStripMenuItem";
            this.organizeSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.organizeSettingsToolStripMenuItem.Text = "Organize Settings";
            // 
            // generalSettingsToolStripMenuItem
            // 
            this.generalSettingsToolStripMenuItem.Name = "generalSettingsToolStripMenuItem";
            this.generalSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.generalSettingsToolStripMenuItem.Text = "All Settings";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.DetectUrls = false;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(472, 131);
            this.txtConsole.TabIndex = 2;
            this.txtConsole.TabStop = false;
            this.txtConsole.Text = "";
            // 
            // txtConsoleInput
            // 
            this.txtConsoleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.txtConsoleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsoleInput.DetectUrls = false;
            this.txtConsoleInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtConsoleInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsoleInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtConsoleInput.Location = new System.Drawing.Point(0, 131);
            this.txtConsoleInput.Multiline = false;
            this.txtConsoleInput.Name = "txtConsoleInput";
            this.txtConsoleInput.Size = new System.Drawing.Size(472, 23);
            this.txtConsoleInput.TabIndex = 0;
            this.txtConsoleInput.Text = ">:";
            this.txtConsoleInput.SelectionChanged += new System.EventHandler(this.txtConsoleInput_SelectionChanged);
            this.txtConsoleInput.Click += new System.EventHandler(this.txtConsoleInput_SelectionChanged);
            this.txtConsoleInput.TextChanged += new System.EventHandler(this.txtConsoleInput_TextChanged);
            this.txtConsoleInput.Enter += new System.EventHandler(this.txtConsoleInput_SelectionChanged);
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
            this.explorer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explorer.Location = new System.Drawing.Point(0, 0);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(172, 362);
            this.explorer.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 386);
            this.Controls.Add(this.spltSideBar);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "Auto";
            this.spltSideBar.Panel1.ResumeLayout(false);
            this.spltSideBar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltSideBar)).EndInit();
            this.spltSideBar.ResumeLayout(false);
            this.spltMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).EndInit();
            this.spltMain.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BoinEditNS.DirTreeView explorer;
        private System.Windows.Forms.SplitContainer spltSideBar;
        private BoinBoxNS.BoinBox btnOpenDir;
        private System.Windows.Forms.SplitContainer spltMain;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizeFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizeSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runSettingsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.RichTextBox txtConsoleInput;


    }
}