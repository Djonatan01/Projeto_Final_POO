namespace AgendaProvas
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLogar = new AgendaProvas.RJButton();
            this.txtEmailLogin = new CustomControls.RJControls.RJTextBox();
            this.txtSenhaLogin = new CustomControls.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btLogar
            // 
            this.btLogar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btLogar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btLogar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btLogar.BorderRadius = 5;
            this.btLogar.BorderSize = 0;
            this.btLogar.FlatAppearance.BorderSize = 0;
            this.btLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogar.ForeColor = System.Drawing.Color.White;
            this.btLogar.Location = new System.Drawing.Point(88, 209);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(100, 40);
            this.btLogar.TabIndex = 1;
            this.btLogar.Text = "Logar";
            this.btLogar.TextColor = System.Drawing.Color.White;
            this.btLogar.UseVisualStyleBackColor = false;
            this.btLogar.Click += new System.EventHandler(this.btLogar_Click);
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtEmailLogin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmailLogin.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmailLogin.BorderRadius = 10;
            this.txtEmailLogin.BorderSize = 2;
            this.txtEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailLogin.ForeColor = System.Drawing.Color.White;
            this.txtEmailLogin.Location = new System.Drawing.Point(16, 90);
            this.txtEmailLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailLogin.Multiline = false;
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmailLogin.PasswordChar = false;
            this.txtEmailLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmailLogin.PlaceholderText = "E-mail:";
            this.txtEmailLogin.Size = new System.Drawing.Size(250, 31);
            this.txtEmailLogin.TabIndex = 2;
            this.txtEmailLogin.Texts = "";
            this.txtEmailLogin.UnderlinedStyle = false;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSenhaLogin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSenhaLogin.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSenhaLogin.BorderRadius = 10;
            this.txtSenhaLogin.BorderSize = 2;
            this.txtSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenhaLogin.ForeColor = System.Drawing.Color.White;
            this.txtSenhaLogin.Location = new System.Drawing.Point(16, 157);
            this.txtSenhaLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaLogin.Multiline = false;
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSenhaLogin.PasswordChar = true;
            this.txtSenhaLogin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSenhaLogin.PlaceholderText = "Senha:";
            this.txtSenhaLogin.Size = new System.Drawing.Size(250, 31);
            this.txtSenhaLogin.TabIndex = 4;
            this.txtSenhaLogin.Texts = "";
            this.txtSenhaLogin.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 42);
            this.panel1.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(277, 261);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btLogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion
        private RJButton btLogar;
        private CustomControls.RJControls.RJTextBox txtEmailLogin;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Panel panel1;
        private CustomControls.RJControls.RJTextBox txtSenhaLogin;
    }
}