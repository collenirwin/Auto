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
            this.pnlOrganize = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatchString = new System.Windows.Forms.TextBox();
            this.chkSameDir = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDirectorytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectionHack = new System.Windows.Forms.Button();
            this.topLine = new System.Windows.Forms.Label();
            this.radCopy = new System.Windows.Forms.RadioButton();
            this.radMove = new System.Windows.Forms.RadioButton();
            this.btnNavCompare = new BoinBoxNS.BoinBox();
            this.btnNavCompileRun = new BoinBoxNS.BoinBox();
            this.btnNavOrganize = new BoinBoxNS.BoinBox();
            this.btnNavHome = new BoinBoxNS.BoinBox();
            this.btnOpenDir = new BoinBoxNS.BoinBox();
            this.explorer = new BoinEditNS.DirTreeView();
            this.btnOpenInExplorerOrganize = new BoinBoxNS.BoinBox();
            this.btnOpenInDBOrganize = new BoinBoxNS.BoinBox();
            this.btnOrganizeGo = new BoinBoxNS.BoinBox();
            this.btnTemplate = new BoinBoxNS.BoinBox();
            this.btnHelpOrganize = new BoinBoxNS.BoinBox();
            this.btnBrowseOutput = new BoinBoxNS.BoinBox();
            this.btnBrowseStart = new BoinBoxNS.BoinBox();
            this.boinBox1 = new BoinBoxNS.BoinBox();
            this.btnCompare = new BoinBoxNS.BoinBox();
            this.btnCompileRun = new BoinBoxNS.BoinBox();
            this.btnOrganize = new BoinBoxNS.BoinBox();
            this.console = new AutoNS.AutoConsole();
            ((System.ComponentModel.ISupportInitialize)(this.spltSideBar)).BeginInit();
            this.spltSideBar.Panel1.SuspendLayout();
            this.spltSideBar.Panel2.SuspendLayout();
            this.spltSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).BeginInit();
            this.spltMain.Panel1.SuspendLayout();
            this.spltMain.Panel2.SuspendLayout();
            this.spltMain.SuspendLayout();
            this.pnlOrganize.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltSideBar
            // 
            this.spltSideBar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.spltSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltSideBar.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltSideBar.Location = new System.Drawing.Point(0, 24);
            this.spltSideBar.Name = "spltSideBar";
            // 
            // spltSideBar.Panel1
            // 
            this.spltSideBar.Panel1.Controls.Add(this.btnOpenDir);
            this.spltSideBar.Panel1.Controls.Add(this.explorer);
            this.spltSideBar.Panel1Collapsed = true;
            this.spltSideBar.Panel1MinSize = 4;
            // 
            // spltSideBar.Panel2
            // 
            this.spltSideBar.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.spltSideBar.Panel2.Controls.Add(this.spltMain);
            this.spltSideBar.Size = new System.Drawing.Size(684, 338);
            this.spltSideBar.SplitterDistance = 172;
            this.spltSideBar.TabIndex = 1;
            this.spltSideBar.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.spltSideBar_SplitterMoved);
            // 
            // spltMain
            // 
            this.spltMain.BackColor = System.Drawing.Color.LightSkyBlue;
            this.spltMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spltMain.Location = new System.Drawing.Point(0, 0);
            this.spltMain.Name = "spltMain";
            this.spltMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltMain.Panel1
            // 
            this.spltMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.spltMain.Panel1.Controls.Add(this.pnlOrganize);
            this.spltMain.Panel1.Controls.Add(this.pnlHome);
            // 
            // spltMain.Panel2
            // 
            this.spltMain.Panel2.Controls.Add(this.console);
            this.spltMain.Panel2Collapsed = true;
            this.spltMain.Size = new System.Drawing.Size(684, 338);
            this.spltMain.SplitterDistance = 180;
            this.spltMain.TabIndex = 0;
            this.spltMain.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.spltSideBar_SplitterMoved);
            // 
            // pnlOrganize
            // 
            this.pnlOrganize.AutoScroll = true;
            this.pnlOrganize.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.pnlOrganize.BackColor = System.Drawing.Color.White;
            this.pnlOrganize.Controls.Add(this.radMove);
            this.pnlOrganize.Controls.Add(this.radCopy);
            this.pnlOrganize.Controls.Add(this.btnOpenInExplorerOrganize);
            this.pnlOrganize.Controls.Add(this.btnOpenInDBOrganize);
            this.pnlOrganize.Controls.Add(this.btnOrganizeGo);
            this.pnlOrganize.Controls.Add(this.label5);
            this.pnlOrganize.Controls.Add(this.btnTemplate);
            this.pnlOrganize.Controls.Add(this.txtMatchString);
            this.pnlOrganize.Controls.Add(this.btnHelpOrganize);
            this.pnlOrganize.Controls.Add(this.chkSameDir);
            this.pnlOrganize.Controls.Add(this.label4);
            this.pnlOrganize.Controls.Add(this.btnBrowseOutput);
            this.pnlOrganize.Controls.Add(this.txtOutputDir);
            this.pnlOrganize.Controls.Add(this.label3);
            this.pnlOrganize.Controls.Add(this.btnBrowseStart);
            this.pnlOrganize.Controls.Add(this.txtStartDir);
            this.pnlOrganize.Controls.Add(this.label1);
            this.pnlOrganize.Controls.Add(this.label2);
            this.pnlOrganize.Location = new System.Drawing.Point(137, 17);
            this.pnlOrganize.Name = "pnlOrganize";
            this.pnlOrganize.Size = new System.Drawing.Size(508, 321);
            this.pnlOrganize.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(29, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "RegEx match string";
            // 
            // txtMatchString
            // 
            this.txtMatchString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatchString.BackColor = System.Drawing.Color.White;
            this.txtMatchString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatchString.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatchString.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtMatchString.Location = new System.Drawing.Point(108, 220);
            this.txtMatchString.MaximumSize = new System.Drawing.Size(500, 20);
            this.txtMatchString.Name = "txtMatchString";
            this.txtMatchString.Size = new System.Drawing.Size(359, 20);
            this.txtMatchString.TabIndex = 17;
            // 
            // chkSameDir
            // 
            this.chkSameDir.AutoSize = true;
            this.chkSameDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkSameDir.Location = new System.Drawing.Point(135, 137);
            this.chkSameDir.Name = "chkSameDir";
            this.chkSameDir.Size = new System.Drawing.Size(180, 20);
            this.chkSameDir.TabIndex = 2;
            this.chkSameDir.Text = "same as starting directory";
            this.chkSameDir.UseVisualStyleBackColor = true;
            this.chkSameDir.CheckedChanged += new System.EventHandler(this.chkSameDir_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(29, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Output directory";
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDir.BackColor = System.Drawing.Color.White;
            this.txtOutputDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtOutputDir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtOutputDir.Location = new System.Drawing.Point(108, 162);
            this.txtOutputDir.MaximumSize = new System.Drawing.Size(500, 20);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(359, 20);
            this.txtOutputDir.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(29, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Starting directory";
            // 
            // txtStartDir
            // 
            this.txtStartDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartDir.BackColor = System.Drawing.Color.White;
            this.txtStartDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtStartDir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtStartDir.Location = new System.Drawing.Point(108, 103);
            this.txtStartDir.MaximumSize = new System.Drawing.Size(500, 20);
            this.txtStartDir.Name = "txtStartDir";
            this.txtStartDir.Size = new System.Drawing.Size(359, 20);
            this.txtStartDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Move files into their own directories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(14, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Organize";
            // 
            // pnlHome
            // 
            this.pnlHome.AutoScroll = true;
            this.pnlHome.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.pnlHome.BackColor = System.Drawing.Color.White;
            this.pnlHome.Controls.Add(this.boinBox1);
            this.pnlHome.Controls.Add(this.lblSubTitle);
            this.pnlHome.Controls.Add(this.lblTitle);
            this.pnlHome.Controls.Add(this.btnCompare);
            this.pnlHome.Controls.Add(this.btnCompileRun);
            this.pnlHome.Controls.Add(this.btnOrganize);
            this.pnlHome.Location = new System.Drawing.Point(41, 48);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(481, 278);
            this.pnlHome.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSubTitle.Location = new System.Drawing.Point(27, 41);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(299, 25);
            this.lblSubTitle.TabIndex = 5;
            this.lblSubTitle.Text = "Select an option to get started";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(14, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 37);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Welcome to Auto";
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
            this.msMain.Size = new System.Drawing.Size(684, 24);
            this.msMain.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirectoryToolStripMenuItem,
            this.closeDirectorytoolStripMenuItem,
            this.extractArchiveToolStripMenuItem,
            this.organizeFilesToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.openDirectoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openDirectoryToolStripMenuItem.Text = "Open Directory";
            this.openDirectoryToolStripMenuItem.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // closeDirectorytoolStripMenuItem
            // 
            this.closeDirectorytoolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.closeDirectorytoolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.closeDirectorytoolStripMenuItem.Name = "closeDirectorytoolStripMenuItem";
            this.closeDirectorytoolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeDirectorytoolStripMenuItem.Text = "Close Directory";
            this.closeDirectorytoolStripMenuItem.Click += new System.EventHandler(this.closeDirectorytoolStripMenuItem_Click);
            // 
            // extractArchiveToolStripMenuItem
            // 
            this.extractArchiveToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.extractArchiveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.extractArchiveToolStripMenuItem.Name = "extractArchiveToolStripMenuItem";
            this.extractArchiveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.extractArchiveToolStripMenuItem.Text = "Extract Archive";
            this.extractArchiveToolStripMenuItem.Click += new System.EventHandler(this.extractArchiveToolStripMenuItem_Click);
            // 
            // organizeFilesToolStripMenuItem
            // 
            this.organizeFilesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.organizeFilesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.organizeFilesToolStripMenuItem.Name = "organizeFilesToolStripMenuItem";
            this.organizeFilesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.organizeFilesToolStripMenuItem.Text = "Organize";
            this.organizeFilesToolStripMenuItem.Click += new System.EventHandler(this.organizeFilesToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalSettingsToolStripMenuItem,
            this.organizeSettingsToolStripMenuItem,
            this.runSettingsToolStripMenuItem});
            this.eDITToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.eDITToolStripMenuItem.Text = "Edit";
            // 
            // generalSettingsToolStripMenuItem
            // 
            this.generalSettingsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.generalSettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.generalSettingsToolStripMenuItem.Name = "generalSettingsToolStripMenuItem";
            this.generalSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.generalSettingsToolStripMenuItem.Text = "All Settings";
            // 
            // organizeSettingsToolStripMenuItem
            // 
            this.organizeSettingsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.organizeSettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.organizeSettingsToolStripMenuItem.Name = "organizeSettingsToolStripMenuItem";
            this.organizeSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.organizeSettingsToolStripMenuItem.Text = "Organize Settings";
            // 
            // runSettingsToolStripMenuItem
            // 
            this.runSettingsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.runSettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.runSettingsToolStripMenuItem.Name = "runSettingsToolStripMenuItem";
            this.runSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.runSettingsToolStripMenuItem.Text = "Run Settings";
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.vIEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleToolStripMenuItem,
            this.directoryBrowserToolStripMenuItem});
            this.vIEWToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.vIEWToolStripMenuItem.Text = "View";
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.consoleToolStripMenuItem.CheckOnClick = true;
            this.consoleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // directoryBrowserToolStripMenuItem
            // 
            this.directoryBrowserToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.directoryBrowserToolStripMenuItem.CheckOnClick = true;
            this.directoryBrowserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.directoryBrowserToolStripMenuItem.Name = "directoryBrowserToolStripMenuItem";
            this.directoryBrowserToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.directoryBrowserToolStripMenuItem.Text = "Directory Browser";
            this.directoryBrowserToolStripMenuItem.Click += new System.EventHandler(this.directoryBrowserToolStripMenuItem_Click);
            // 
            // btnSelectionHack
            // 
            this.btnSelectionHack.Location = new System.Drawing.Point(83, -30);
            this.btnSelectionHack.Name = "btnSelectionHack";
            this.btnSelectionHack.Size = new System.Drawing.Size(75, 23);
            this.btnSelectionHack.TabIndex = 7;
            this.btnSelectionHack.TabStop = false;
            this.btnSelectionHack.UseVisualStyleBackColor = true;
            // 
            // topLine
            // 
            this.topLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topLine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.topLine.Location = new System.Drawing.Point(0, 22);
            this.topLine.Name = "topLine";
            this.topLine.Size = new System.Drawing.Size(685, 2);
            this.topLine.TabIndex = 8;
            // 
            // radCopy
            // 
            this.radCopy.AutoSize = true;
            this.radCopy.Checked = true;
            this.radCopy.Location = new System.Drawing.Point(41, 247);
            this.radCopy.Name = "radCopy";
            this.radCopy.Size = new System.Drawing.Size(49, 17);
            this.radCopy.TabIndex = 22;
            this.radCopy.TabStop = true;
            this.radCopy.Text = "Copy";
            this.radCopy.UseVisualStyleBackColor = true;
            // 
            // radMove
            // 
            this.radMove.AutoSize = true;
            this.radMove.Location = new System.Drawing.Point(96, 247);
            this.radMove.Name = "radMove";
            this.radMove.Size = new System.Drawing.Size(52, 17);
            this.radMove.TabIndex = 23;
            this.radMove.Text = "Move";
            this.radMove.UseVisualStyleBackColor = true;
            // 
            // btnNavCompare
            // 
            this.btnNavCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavCompare.AntiAliased = false;
            this.btnNavCompare.BackColor = System.Drawing.Color.White;
            this.btnNavCompare.BorderColor = System.Drawing.Color.Empty;
            this.btnNavCompare.BorderSize = 0;
            this.btnNavCompare.FakeDisabled = false;
            this.btnNavCompare.FlatAppearance.BorderSize = 0;
            this.btnNavCompare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNavCompare.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNavCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCompare.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnNavCompare.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNavCompare.Location = new System.Drawing.Point(581, 0);
            this.btnNavCompare.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNavCompare.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNavCompare.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNavCompare.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNavCompare.Name = "btnNavCompare";
            this.btnNavCompare.Size = new System.Drawing.Size(103, 24);
            this.btnNavCompare.TabIndex = 6;
            this.btnNavCompare.Text = "Compare";
            this.btnNavCompare.UseVisualStyleBackColor = false;
            this.btnNavCompare.Click += new System.EventHandler(this.btnNavCompare_Click);
            // 
            // btnNavCompileRun
            // 
            this.btnNavCompileRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavCompileRun.AntiAliased = false;
            this.btnNavCompileRun.BackColor = System.Drawing.Color.White;
            this.btnNavCompileRun.BorderColor = System.Drawing.Color.Empty;
            this.btnNavCompileRun.BorderSize = 0;
            this.btnNavCompileRun.FakeDisabled = false;
            this.btnNavCompileRun.FlatAppearance.BorderSize = 0;
            this.btnNavCompileRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNavCompileRun.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNavCompileRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCompileRun.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnNavCompileRun.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNavCompileRun.Location = new System.Drawing.Point(478, 0);
            this.btnNavCompileRun.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNavCompileRun.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNavCompileRun.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNavCompileRun.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNavCompileRun.Name = "btnNavCompileRun";
            this.btnNavCompileRun.Size = new System.Drawing.Size(103, 24);
            this.btnNavCompileRun.TabIndex = 5;
            this.btnNavCompileRun.Text = "Compile / Run";
            this.btnNavCompileRun.UseVisualStyleBackColor = false;
            this.btnNavCompileRun.Click += new System.EventHandler(this.btnNavCompileRun_Click);
            // 
            // btnNavOrganize
            // 
            this.btnNavOrganize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavOrganize.AntiAliased = false;
            this.btnNavOrganize.BackColor = System.Drawing.Color.White;
            this.btnNavOrganize.BorderColor = System.Drawing.Color.Empty;
            this.btnNavOrganize.BorderSize = 0;
            this.btnNavOrganize.FakeDisabled = false;
            this.btnNavOrganize.FlatAppearance.BorderSize = 0;
            this.btnNavOrganize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNavOrganize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNavOrganize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOrganize.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnNavOrganize.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNavOrganize.Location = new System.Drawing.Point(375, 0);
            this.btnNavOrganize.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNavOrganize.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNavOrganize.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNavOrganize.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNavOrganize.Name = "btnNavOrganize";
            this.btnNavOrganize.Size = new System.Drawing.Size(103, 24);
            this.btnNavOrganize.TabIndex = 4;
            this.btnNavOrganize.Text = "Organize";
            this.btnNavOrganize.UseVisualStyleBackColor = false;
            this.btnNavOrganize.Click += new System.EventHandler(this.btnNavOrganize_Click);
            // 
            // btnNavHome
            // 
            this.btnNavHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavHome.AntiAliased = false;
            this.btnNavHome.BackColor = System.Drawing.Color.White;
            this.btnNavHome.BorderColor = System.Drawing.Color.Empty;
            this.btnNavHome.BorderSize = 0;
            this.btnNavHome.FakeDisabled = false;
            this.btnNavHome.FlatAppearance.BorderSize = 0;
            this.btnNavHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNavHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHome.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnNavHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNavHome.Location = new System.Drawing.Point(272, 0);
            this.btnNavHome.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNavHome.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNavHome.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNavHome.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(103, 24);
            this.btnNavHome.TabIndex = 2;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.UseVisualStyleBackColor = false;
            this.btnNavHome.Click += new System.EventHandler(this.btnNavHome_Click);
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDir.AntiAliased = false;
            this.btnOpenDir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOpenDir.BorderColor = System.Drawing.Color.Empty;
            this.btnOpenDir.BorderSize = 0;
            this.btnOpenDir.FakeDisabled = false;
            this.btnOpenDir.FlatAppearance.BorderSize = 0;
            this.btnOpenDir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOpenDir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDir.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnOpenDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOpenDir.Location = new System.Drawing.Point(14, 12);
            this.btnOpenDir.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOpenDir.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOpenDir.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenDir.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
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
            this.explorer.fileColor = System.Drawing.SystemColors.Highlight;
            this.explorer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explorer.LineColor = System.Drawing.Color.LightSkyBlue;
            this.explorer.Location = new System.Drawing.Point(0, 0);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(172, 100);
            this.explorer.Sorted = true;
            this.explorer.TabIndex = 0;
            // 
            // btnOpenInExplorerOrganize
            // 
            this.btnOpenInExplorerOrganize.AntiAliased = false;
            this.btnOpenInExplorerOrganize.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOpenInExplorerOrganize.BorderColor = System.Drawing.Color.Empty;
            this.btnOpenInExplorerOrganize.BorderSize = 0;
            this.btnOpenInExplorerOrganize.FakeDisabled = false;
            this.btnOpenInExplorerOrganize.FlatAppearance.BorderSize = 0;
            this.btnOpenInExplorerOrganize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOpenInExplorerOrganize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenInExplorerOrganize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenInExplorerOrganize.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnOpenInExplorerOrganize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOpenInExplorerOrganize.Location = new System.Drawing.Point(321, 270);
            this.btnOpenInExplorerOrganize.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOpenInExplorerOrganize.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOpenInExplorerOrganize.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenInExplorerOrganize.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOpenInExplorerOrganize.Name = "btnOpenInExplorerOrganize";
            this.btnOpenInExplorerOrganize.Size = new System.Drawing.Size(112, 27);
            this.btnOpenInExplorerOrganize.TabIndex = 21;
            this.btnOpenInExplorerOrganize.Text = "Open in Explorer";
            this.btnOpenInExplorerOrganize.UseVisualStyleBackColor = false;
            this.btnOpenInExplorerOrganize.Visible = false;
            this.btnOpenInExplorerOrganize.Click += new System.EventHandler(this.btnOpenInExplorerOrganize_Click);
            // 
            // btnOpenInDBOrganize
            // 
            this.btnOpenInDBOrganize.AntiAliased = false;
            this.btnOpenInDBOrganize.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOpenInDBOrganize.BorderColor = System.Drawing.Color.Empty;
            this.btnOpenInDBOrganize.BorderSize = 0;
            this.btnOpenInDBOrganize.FakeDisabled = false;
            this.btnOpenInDBOrganize.FlatAppearance.BorderSize = 0;
            this.btnOpenInDBOrganize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOpenInDBOrganize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenInDBOrganize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenInDBOrganize.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnOpenInDBOrganize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOpenInDBOrganize.Location = new System.Drawing.Point(158, 270);
            this.btnOpenInDBOrganize.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOpenInDBOrganize.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOpenInDBOrganize.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenInDBOrganize.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOpenInDBOrganize.Name = "btnOpenInDBOrganize";
            this.btnOpenInDBOrganize.Size = new System.Drawing.Size(157, 27);
            this.btnOpenInDBOrganize.TabIndex = 20;
            this.btnOpenInDBOrganize.Text = "Open in Directory Browser";
            this.btnOpenInDBOrganize.UseVisualStyleBackColor = false;
            this.btnOpenInDBOrganize.Visible = false;
            this.btnOpenInDBOrganize.Click += new System.EventHandler(this.btnOpenInDBOrganize_Click);
            // 
            // btnOrganizeGo
            // 
            this.btnOrganizeGo.AntiAliased = false;
            this.btnOrganizeGo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOrganizeGo.BorderColor = System.Drawing.Color.Empty;
            this.btnOrganizeGo.BorderSize = 0;
            this.btnOrganizeGo.FakeDisabled = false;
            this.btnOrganizeGo.FlatAppearance.BorderSize = 0;
            this.btnOrganizeGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOrganizeGo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOrganizeGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganizeGo.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnOrganizeGo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOrganizeGo.Location = new System.Drawing.Point(32, 270);
            this.btnOrganizeGo.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOrganizeGo.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOrganizeGo.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOrganizeGo.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOrganizeGo.Name = "btnOrganizeGo";
            this.btnOrganizeGo.Size = new System.Drawing.Size(120, 27);
            this.btnOrganizeGo.TabIndex = 19;
            this.btnOrganizeGo.Text = "Organize";
            this.btnOrganizeGo.UseVisualStyleBackColor = false;
            this.btnOrganizeGo.Click += new System.EventHandler(this.btnOrganizeGo_Click);
            // 
            // btnTemplate
            // 
            this.btnTemplate.AntiAliased = false;
            this.btnTemplate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTemplate.BorderColor = System.Drawing.Color.Empty;
            this.btnTemplate.BorderSize = 0;
            this.btnTemplate.FakeDisabled = false;
            this.btnTemplate.FlatAppearance.BorderSize = 0;
            this.btnTemplate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTemplate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplate.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnTemplate.Location = new System.Drawing.Point(32, 218);
            this.btnTemplate.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTemplate.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnTemplate.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTemplate.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(70, 23);
            this.btnTemplate.TabIndex = 16;
            this.btnTemplate.Text = "Template";
            this.btnTemplate.UseVisualStyleBackColor = false;
            // 
            // btnHelpOrganize
            // 
            this.btnHelpOrganize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpOrganize.AntiAliased = false;
            this.btnHelpOrganize.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHelpOrganize.BorderColor = System.Drawing.Color.Empty;
            this.btnHelpOrganize.BorderSize = 0;
            this.btnHelpOrganize.FakeDisabled = false;
            this.btnHelpOrganize.FlatAppearance.BorderSize = 0;
            this.btnHelpOrganize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHelpOrganize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHelpOrganize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpOrganize.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnHelpOrganize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnHelpOrganize.Location = new System.Drawing.Point(444, 6);
            this.btnHelpOrganize.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHelpOrganize.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnHelpOrganize.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHelpOrganize.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnHelpOrganize.Name = "btnHelpOrganize";
            this.btnHelpOrganize.Size = new System.Drawing.Size(58, 23);
            this.btnHelpOrganize.TabIndex = 15;
            this.btnHelpOrganize.TabStop = false;
            this.btnHelpOrganize.Text = "Help";
            this.btnHelpOrganize.UseVisualStyleBackColor = false;
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.AntiAliased = false;
            this.btnBrowseOutput.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBrowseOutput.BorderColor = System.Drawing.Color.Empty;
            this.btnBrowseOutput.BorderSize = 0;
            this.btnBrowseOutput.FakeDisabled = false;
            this.btnBrowseOutput.FlatAppearance.BorderSize = 0;
            this.btnBrowseOutput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBrowseOutput.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBrowseOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseOutput.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnBrowseOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnBrowseOutput.Location = new System.Drawing.Point(32, 160);
            this.btnBrowseOutput.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBrowseOutput.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnBrowseOutput.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBrowseOutput.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(70, 23);
            this.btnBrowseOutput.TabIndex = 3;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = false;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // btnBrowseStart
            // 
            this.btnBrowseStart.AntiAliased = false;
            this.btnBrowseStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBrowseStart.BorderColor = System.Drawing.Color.Empty;
            this.btnBrowseStart.BorderSize = 0;
            this.btnBrowseStart.FakeDisabled = false;
            this.btnBrowseStart.FlatAppearance.BorderSize = 0;
            this.btnBrowseStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBrowseStart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBrowseStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseStart.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnBrowseStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnBrowseStart.Location = new System.Drawing.Point(32, 101);
            this.btnBrowseStart.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBrowseStart.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnBrowseStart.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBrowseStart.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnBrowseStart.Name = "btnBrowseStart";
            this.btnBrowseStart.Size = new System.Drawing.Size(70, 23);
            this.btnBrowseStart.TabIndex = 0;
            this.btnBrowseStart.Text = "Browse";
            this.btnBrowseStart.UseVisualStyleBackColor = false;
            this.btnBrowseStart.Click += new System.EventHandler(this.btnBrowseStart_Click);
            // 
            // boinBox1
            // 
            this.boinBox1.AntiAliased = false;
            this.boinBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.boinBox1.BorderColor = System.Drawing.Color.Empty;
            this.boinBox1.BorderSize = 0;
            this.boinBox1.FakeDisabled = false;
            this.boinBox1.FlatAppearance.BorderSize = 0;
            this.boinBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.boinBox1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.boinBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boinBox1.Font = new System.Drawing.Font("Calibri", 9F);
            this.boinBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.boinBox1.Location = new System.Drawing.Point(156, 81);
            this.boinBox1.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.boinBox1.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.boinBox1.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.boinBox1.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.boinBox1.Name = "boinBox1";
            this.boinBox1.Size = new System.Drawing.Size(118, 23);
            this.boinBox1.TabIndex = 7;
            this.boinBox1.Text = "Open Directory";
            this.boinBox1.UseVisualStyleBackColor = false;
            this.boinBox1.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.AntiAliased = false;
            this.btnCompare.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCompare.BorderColor = System.Drawing.Color.Empty;
            this.btnCompare.BorderSize = 0;
            this.btnCompare.FakeDisabled = false;
            this.btnCompare.FlatAppearance.BorderSize = 0;
            this.btnCompare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCompare.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnCompare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCompare.Location = new System.Drawing.Point(32, 139);
            this.btnCompare.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCompare.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCompare.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCompare.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(118, 23);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "Compare Files";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnCompileRun
            // 
            this.btnCompileRun.AntiAliased = false;
            this.btnCompileRun.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCompileRun.BorderColor = System.Drawing.Color.Empty;
            this.btnCompileRun.BorderSize = 0;
            this.btnCompileRun.FakeDisabled = false;
            this.btnCompileRun.FlatAppearance.BorderSize = 0;
            this.btnCompileRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCompileRun.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCompileRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompileRun.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnCompileRun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCompileRun.Location = new System.Drawing.Point(32, 110);
            this.btnCompileRun.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCompileRun.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCompileRun.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCompileRun.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCompileRun.Name = "btnCompileRun";
            this.btnCompileRun.Size = new System.Drawing.Size(118, 23);
            this.btnCompileRun.TabIndex = 2;
            this.btnCompileRun.Text = "Compile / Run Files";
            this.btnCompileRun.UseVisualStyleBackColor = false;
            this.btnCompileRun.Click += new System.EventHandler(this.btnCompileRun_Click);
            // 
            // btnOrganize
            // 
            this.btnOrganize.AntiAliased = false;
            this.btnOrganize.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOrganize.BorderColor = System.Drawing.Color.Empty;
            this.btnOrganize.BorderSize = 0;
            this.btnOrganize.FakeDisabled = false;
            this.btnOrganize.FlatAppearance.BorderSize = 0;
            this.btnOrganize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOrganize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOrganize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganize.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnOrganize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOrganize.Location = new System.Drawing.Point(32, 81);
            this.btnOrganize.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOrganize.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOrganize.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOrganize.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOrganize.Name = "btnOrganize";
            this.btnOrganize.Size = new System.Drawing.Size(118, 23);
            this.btnOrganize.TabIndex = 1;
            this.btnOrganize.Text = "Organize Files";
            this.btnOrganize.UseVisualStyleBackColor = false;
            this.btnOrganize.Click += new System.EventHandler(this.btnOrganize_Click);
            // 
            // console
            // 
            this.console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console.errorColor = System.Drawing.Color.LightCoral;
            this.console.Location = new System.Drawing.Point(0, 0);
            this.console.Name = "console";
            this.console.outputColor = System.Drawing.Color.LightBlue;
            this.console.Size = new System.Drawing.Size(150, 46);
            this.console.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.topLine);
            this.Controls.Add(this.btnSelectionHack);
            this.Controls.Add(this.btnNavCompare);
            this.Controls.Add(this.btnNavCompileRun);
            this.Controls.Add(this.btnNavOrganize);
            this.Controls.Add(this.btnNavHome);
            this.Controls.Add(this.spltSideBar);
            this.Controls.Add(this.msMain);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "frmMain";
            this.Text = "Auto";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.spltSideBar.Panel1.ResumeLayout(false);
            this.spltSideBar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltSideBar)).EndInit();
            this.spltSideBar.ResumeLayout(false);
            this.spltMain.Panel1.ResumeLayout(false);
            this.spltMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).EndInit();
            this.spltMain.ResumeLayout(false);
            this.pnlOrganize.ResumeLayout(false);
            this.pnlOrganize.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
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
        private AutoConsole console;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryBrowserToolStripMenuItem;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private BoinBoxNS.BoinBox btnCompare;
        private BoinBoxNS.BoinBox btnCompileRun;
        private BoinBoxNS.BoinBox btnOrganize;
        private System.Windows.Forms.Panel pnlOrganize;
        private System.Windows.Forms.Label label2;
        private BoinBoxNS.BoinBox btnNavHome;
        private BoinBoxNS.BoinBox btnNavOrganize;
        private BoinBoxNS.BoinBox btnNavCompileRun;
        private BoinBoxNS.BoinBox btnNavCompare;
        private System.Windows.Forms.Button btnSelectionHack;
        private BoinBoxNS.BoinBox boinBox1;
        private System.Windows.Forms.ToolStripMenuItem closeDirectorytoolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private BoinBoxNS.BoinBox btnBrowseStart;
        private System.Windows.Forms.TextBox txtStartDir;
        private System.Windows.Forms.CheckBox chkSameDir;
        private System.Windows.Forms.Label label4;
        private BoinBoxNS.BoinBox btnBrowseOutput;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Label label3;
        private BoinBoxNS.BoinBox btnHelpOrganize;
        private System.Windows.Forms.Label label5;
        private BoinBoxNS.BoinBox btnTemplate;
        private System.Windows.Forms.TextBox txtMatchString;
        private System.Windows.Forms.Label topLine;
        private BoinBoxNS.BoinBox btnOrganizeGo;
        private BoinBoxNS.BoinBox btnOpenInDBOrganize;
        private BoinBoxNS.BoinBox btnOpenInExplorerOrganize;
        private System.Windows.Forms.RadioButton radMove;
        private System.Windows.Forms.RadioButton radCopy;


    }
}