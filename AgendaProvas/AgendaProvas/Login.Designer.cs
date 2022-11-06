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
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
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
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtEmailLogin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmailLogin.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmailLogin.BorderRadius = 10;
            this.txtEmailLogin.BorderSize = 2;
            this.txtEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(16, 157);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = true;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "Senha:";
            this.rjTextBox1.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox1.TabIndex = 4;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
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
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btLogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RJButton btLogar;
        private CustomControls.RJControls.RJTextBox txtEmailLogin;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Panel panel1;
    }
}