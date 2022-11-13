﻿namespace AgendaProvas
{
    partial class Cadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNome = new CustomControls.RJControls.RJTextBox();
            this.txtEmail = new CustomControls.RJControls.RJTextBox();
            this.txtSenha = new CustomControls.RJControls.RJTextBox();
            this.txtMatricula = new CustomControls.RJControls.RJTextBox();
            this.txtCurso = new CustomControls.RJControls.RJTextBox();
            this.txtPeriodo = new CustomControls.RJControls.RJTextBox();
            this.btcadastrar = new AgendaProvas.RJButton();
            this.btConsultar = new AgendaProvas.RJButton();
            this.btExcluir = new AgendaProvas.RJButton();
            this.btAlterar = new AgendaProvas.RJButton();
            this.txtTipo = new CustomControls.RJControls.RJTextBox();
            this.txtId = new CustomControls.RJControls.RJTextBox();
            this.mnOpcao = new System.Windows.Forms.MenuStrip();
            this.menuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.mnOpcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel1.Size = new System.Drawing.Size(875, 42);
            this.panel1.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtNome.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNome.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNome.BorderRadius = 10;
            this.txtNome.BorderSize = 2;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(13, 172);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNome.PlaceholderText = "Nome:";
            this.txtNome.Size = new System.Drawing.Size(250, 31);
            this.txtNome.TabIndex = 3;
            this.txtNome.TabStop = false;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(13, 211);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "E-mail:";
            this.txtEmail.Size = new System.Drawing.Size(250, 31);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TabStop = false;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSenha.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSenha.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSenha.BorderRadius = 10;
            this.txtSenha.BorderSize = 2;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(13, 250);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSenha.PasswordChar = false;
            this.txtSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSenha.PlaceholderText = "Senha:";
            this.txtSenha.Size = new System.Drawing.Size(250, 31);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.TabStop = false;
            this.txtSenha.Texts = "";
            this.txtSenha.UnderlinedStyle = false;
            // 
            // txtMatricula
            // 
            this.txtMatricula.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMatricula.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMatricula.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatricula.BorderRadius = 10;
            this.txtMatricula.BorderSize = 2;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.ForeColor = System.Drawing.Color.White;
            this.txtMatricula.Location = new System.Drawing.Point(13, 133);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatricula.Multiline = false;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMatricula.PasswordChar = false;
            this.txtMatricula.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatricula.PlaceholderText = "Matricula";
            this.txtMatricula.Size = new System.Drawing.Size(250, 31);
            this.txtMatricula.TabIndex = 2;
            this.txtMatricula.TabStop = false;
            this.txtMatricula.Texts = "";
            this.txtMatricula.UnderlinedStyle = false;
            // 
            // txtCurso
            // 
            this.txtCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCurso.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCurso.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCurso.BorderRadius = 10;
            this.txtCurso.BorderSize = 2;
            this.txtCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCurso.ForeColor = System.Drawing.Color.White;
            this.txtCurso.Location = new System.Drawing.Point(13, 367);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurso.Multiline = false;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCurso.PasswordChar = false;
            this.txtCurso.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCurso.PlaceholderText = "Curso:";
            this.txtCurso.Size = new System.Drawing.Size(250, 31);
            this.txtCurso.TabIndex = 8;
            this.txtCurso.TabStop = false;
            this.txtCurso.Texts = "";
            this.txtCurso.UnderlinedStyle = false;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPeriodo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPeriodo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPeriodo.BorderRadius = 10;
            this.txtPeriodo.BorderSize = 2;
            this.txtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPeriodo.ForeColor = System.Drawing.Color.White;
            this.txtPeriodo.Location = new System.Drawing.Point(13, 328);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriodo.Multiline = false;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPeriodo.PasswordChar = false;
            this.txtPeriodo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPeriodo.PlaceholderText = "Período:";
            this.txtPeriodo.Size = new System.Drawing.Size(250, 31);
            this.txtPeriodo.TabIndex = 7;
            this.txtPeriodo.TabStop = false;
            this.txtPeriodo.Texts = "";
            this.txtPeriodo.UnderlinedStyle = false;
            // 
            // btcadastrar
            // 
            this.btcadastrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btcadastrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btcadastrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btcadastrar.BorderRadius = 5;
            this.btcadastrar.BorderSize = 0;
            this.btcadastrar.FlatAppearance.BorderSize = 0;
            this.btcadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcadastrar.ForeColor = System.Drawing.Color.White;
            this.btcadastrar.Location = new System.Drawing.Point(9, 474);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(100, 30);
            this.btcadastrar.TabIndex = 7;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.TextColor = System.Drawing.Color.White;
            this.btcadastrar.UseVisualStyleBackColor = false;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btConsultar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btConsultar.BorderRadius = 5;
            this.btConsultar.BorderSize = 0;
            this.btConsultar.FlatAppearance.BorderSize = 0;
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btConsultar.ForeColor = System.Drawing.Color.White;
            this.btConsultar.Location = new System.Drawing.Point(287, 151);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(100, 30);
            this.btConsultar.TabIndex = 8;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.TextColor = System.Drawing.Color.White;
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btExcluir.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btExcluir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btExcluir.BorderRadius = 5;
            this.btExcluir.BorderSize = 0;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Location = new System.Drawing.Point(112, 474);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(100, 30);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextColor = System.Drawing.Color.White;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAlterar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btAlterar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAlterar.BorderRadius = 5;
            this.btAlterar.BorderSize = 0;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAlterar.ForeColor = System.Drawing.Color.White;
            this.btAlterar.Location = new System.Drawing.Point(218, 474);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(100, 30);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextColor = System.Drawing.Color.White;
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTipo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTipo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTipo.BorderRadius = 10;
            this.txtTipo.BorderSize = 2;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipo.ForeColor = System.Drawing.Color.White;
            this.txtTipo.Location = new System.Drawing.Point(13, 289);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Multiline = false;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTipo.PasswordChar = false;
            this.txtTipo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTipo.PlaceholderText = "Nivel de acesso:";
            this.txtTipo.Size = new System.Drawing.Size(250, 31);
            this.txtTipo.TabIndex = 6;
            this.txtTipo.TabStop = false;
            this.txtTipo.Texts = "";
            this.txtTipo.UnderlinedStyle = false;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderRadius = 10;
            this.txtId.BorderSize = 2;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(13, 90);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtId.PasswordChar = false;
            this.txtId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtId.PlaceholderText = "Id:";
            this.txtId.Size = new System.Drawing.Size(78, 31);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = false;
            // 
            // mnOpcao
            // 
            this.mnOpcao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrar,
            this.menuConsultar});
            this.mnOpcao.Location = new System.Drawing.Point(0, 42);
            this.mnOpcao.Name = "mnOpcao";
            this.mnOpcao.Size = new System.Drawing.Size(875, 24);
            this.mnOpcao.TabIndex = 11;
            this.mnOpcao.Text = "Opção";
            // 
            // menuCadastrar
            // 
            this.menuCadastrar.Name = "menuCadastrar";
            this.menuCadastrar.Size = new System.Drawing.Size(69, 20);
            this.menuCadastrar.Text = "Cadastrar";
            this.menuCadastrar.Click += new System.EventHandler(this.menuCadastrar_Click);
            // 
            // menuConsultar
            // 
            this.menuConsultar.Name = "menuConsultar";
            this.menuConsultar.Size = new System.Drawing.Size(70, 20);
            this.menuConsultar.Text = "Consultar";
            this.menuConsultar.Click += new System.EventHandler(this.menuConsultar_Click);
            // 
            // dgUsuario
            // 
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Location = new System.Drawing.Point(13, 210);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.RowTemplate.Height = 25;
            this.dgUsuario.Size = new System.Drawing.Size(850, 236);
            this.dgUsuario.TabIndex = 13;
            this.dgUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuario_CellClick);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(875, 517);
            this.Controls.Add(this.dgUsuario);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mnOpcao);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.mnOpcao;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.mnOpcao.ResumeLayout(false);
            this.mnOpcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private CustomControls.RJControls.RJTextBox txtNome;
        private CustomControls.RJControls.RJTextBox txtEmail;
        private CustomControls.RJControls.RJTextBox txtSenha;
        private CustomControls.RJControls.RJTextBox txtMatricula;
        private CustomControls.RJControls.RJTextBox txtCurso;
        private CustomControls.RJControls.RJTextBox txtPeriodo;
        private RJButton btcadastrar;
        private RJButton btConsultar;
        private RJButton btExcluir;
        private RJButton btAlterar;
        private CustomControls.RJControls.RJTextBox txtTipo;
        private CustomControls.RJControls.RJTextBox txtId;
        private MenuStrip mnOpcao;
        private ToolStripMenuItem menuCadastrar;
        private ToolStripMenuItem menuConsultar;
        private DataGridView dgUsuario;
    }
}