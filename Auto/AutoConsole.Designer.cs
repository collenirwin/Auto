namespace AutoNS {
    partial class AutoConsole {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.txtConsoleInput = new System.Windows.Forms.RichTextBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnReset = new BoinBoxNS.BoinBox();
            this.btnClear = new BoinBoxNS.BoinBox();
            this.btnOptions = new BoinBoxNS.BoinBox();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.DetectUrls = false;
            this.txtConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(453, 187);
            this.txtConsole.TabIndex = 4;
            this.txtConsole.TabStop = false;
            this.txtConsole.Text = "";
            this.txtConsole.Click += new System.EventHandler(this.txtConsole_Click);
            // 
            // txtConsoleInput
            // 
            this.txtConsoleInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsoleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtConsoleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsoleInput.DetectUrls = false;
            this.txtConsoleInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsoleInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtConsoleInput.Location = new System.Drawing.Point(0, 187);
            this.txtConsoleInput.Multiline = false;
            this.txtConsoleInput.Name = "txtConsoleInput";
            this.txtConsoleInput.Size = new System.Drawing.Size(378, 23);
            this.txtConsoleInput.TabIndex = 3;
            this.txtConsoleInput.Text = ">:";
            this.txtConsoleInput.SelectionChanged += new System.EventHandler(this.txtConsoleInput_SelectionChanged);
            this.txtConsoleInput.Click += new System.EventHandler(this.txtConsoleInput_SelectionChanged);
            this.txtConsoleInput.TextChanged += new System.EventHandler(this.txtConsoleInput_TextChanged);
            this.txtConsoleInput.Enter += new System.EventHandler(this.txtConsoleInput_SelectionChanged);
            this.txtConsoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsoleInput_KeyDown);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.pnlOptions.Controls.Add(this.btnReset);
            this.pnlOptions.Controls.Add(this.btnClear);
            this.pnlOptions.Location = new System.Drawing.Point(348, 129);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(105, 58);
            this.pnlOptions.TabIndex = 6;
            this.pnlOptions.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.AntiAliased = false;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnReset.BorderColor = System.Drawing.Color.Empty;
            this.btnReset.BorderSize = 0;
            this.btnReset.FakeDisabled = false;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnReset.Location = new System.Drawing.Point(3, 32);
            this.btnReset.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnReset.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnReset.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnReset.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.btnClear.AntiAliased = false;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClear.BorderColor = System.Drawing.Color.Empty;
            this.btnClear.BorderSize = 0;
            this.btnClear.FakeDisabled = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnClear.Location = new System.Drawing.Point(3, 3);
            this.btnClear.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnClear.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnClear.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnClear.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.AntiAliased = false;
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnOptions.BorderColor = System.Drawing.Color.Empty;
            this.btnOptions.BorderSize = 0;
            this.btnOptions.FakeDisabled = false;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOptions.Location = new System.Drawing.Point(378, 187);
            this.btnOptions.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnOptions.MouseDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOptions.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnOptions.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // AutoConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.txtConsoleInput);
            this.Name = "AutoConsole";
            this.Size = new System.Drawing.Size(453, 210);
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox txtConsole;
        public System.Windows.Forms.RichTextBox txtConsoleInput;
        private BoinBoxNS.BoinBox btnOptions;
        private System.Windows.Forms.Panel pnlOptions;
        private BoinBoxNS.BoinBox btnReset;
        private BoinBoxNS.BoinBox btnClear;

    }
}
