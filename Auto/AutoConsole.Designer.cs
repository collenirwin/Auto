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
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.DetectUrls = false;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(453, 187);
            this.txtConsole.TabIndex = 4;
            this.txtConsole.TabStop = false;
            this.txtConsole.Text = "";
            // 
            // txtConsoleInput
            // 
            this.txtConsoleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtConsoleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsoleInput.DetectUrls = false;
            this.txtConsoleInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtConsoleInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsoleInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtConsoleInput.Location = new System.Drawing.Point(0, 187);
            this.txtConsoleInput.Multiline = false;
            this.txtConsoleInput.Name = "txtConsoleInput";
            this.txtConsoleInput.Size = new System.Drawing.Size(453, 23);
            this.txtConsoleInput.TabIndex = 3;
            this.txtConsoleInput.Text = ">:";
            this.txtConsoleInput.SelectionChanged += new System.EventHandler(this.txtConsoleInput_SelectionChanged);
            this.txtConsoleInput.Click += new System.EventHandler(this.txtConsoleInput_SelectionChanged);
            this.txtConsoleInput.TextChanged += new System.EventHandler(this.txtConsoleInput_TextChanged);
            this.txtConsoleInput.Enter += new System.EventHandler(this.txtConsoleInput_SelectionChanged);
            this.txtConsoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsoleInput_KeyDown);
            // 
            // AutoConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.txtConsoleInput);
            this.Name = "AutoConsole";
            this.Size = new System.Drawing.Size(453, 210);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox txtConsole;
        public System.Windows.Forms.RichTextBox txtConsoleInput;

    }
}
