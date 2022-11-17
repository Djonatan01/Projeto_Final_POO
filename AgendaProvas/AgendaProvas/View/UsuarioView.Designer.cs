﻿namespace AgendaProvas
{
    partial class UsuarioView
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
            this.btcadastrar = new AgendaProvas.RJButton();
            this.btConsultar = new AgendaProvas.RJButton();
            this.btExcluir = new AgendaProvas.RJButton();
            this.btAlterar = new AgendaProvas.RJButton();
            this.txtId = new CustomControls.RJControls.RJTextBox();
            this.mnOpcao = new System.Windows.Forms.MenuStrip();
            this.menuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCurso = new CustomControls.RJControls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPeriodo = new CustomControls.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbNivelAcesso = new CustomControls.RJControls.RJComboBox();
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
            this.txtNome.Location = new System.Drawing.Point(13, 244);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNome.PlaceholderText = "";
            this.txtNome.Size = new System.Drawing.Size(250, 31);
            this.txtNome.TabIndex = 3;
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
            this.txtEmail.Location = new System.Drawing.Point(11, 300);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(250, 31);
            this.txtEmail.TabIndex = 4;
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
            this.txtSenha.Location = new System.Drawing.Point(11, 356);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSenha.PasswordChar = true;
            this.txtSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSenha.PlaceholderText = "";
            this.txtSenha.Size = new System.Drawing.Size(250, 31);
            this.txtSenha.TabIndex = 5;
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
            this.txtMatricula.Location = new System.Drawing.Point(13, 188);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatricula.Multiline = false;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMatricula.PasswordChar = false;
            this.txtMatricula.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatricula.PlaceholderText = "";
            this.txtMatricula.Size = new System.Drawing.Size(250, 31);
            this.txtMatricula.TabIndex = 2;
            this.txtMatricula.Texts = "";
            this.txtMatricula.UnderlinedStyle = false;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
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
            this.btcadastrar.Location = new System.Drawing.Point(8, 591);
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
            this.btConsultar.Location = new System.Drawing.Point(542, 82);
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
            this.btExcluir.Location = new System.Drawing.Point(111, 591);
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
            this.btAlterar.Location = new System.Drawing.Point(217, 591);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(100, 30);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextColor = System.Drawing.Color.White;
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
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
            this.txtId.Location = new System.Drawing.Point(12, 132);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtId.PasswordChar = false;
            this.txtId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtId.PlaceholderText = "";
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
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbCurso.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbCurso.BorderSize = 1;
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbCurso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCurso.ForeColor = System.Drawing.Color.DimGray;
            this.cbCurso.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbCurso.Items.AddRange(new object[] {
            "",
            "ADS",
            "GPI",
            "EVENT"});
            this.cbCurso.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbCurso.ListTextColor = System.Drawing.Color.DimGray;
            this.cbCurso.Location = new System.Drawing.Point(11, 517);
            this.cbCurso.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Padding = new System.Windows.Forms.Padding(1);
            this.cbCurso.Size = new System.Drawing.Size(200, 30);
            this.cbCurso.TabIndex = 14;
            this.cbCurso.Texts = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Curso:";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbPeriodo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbPeriodo.BorderSize = 1;
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPeriodo.ForeColor = System.Drawing.Color.DimGray;
            this.cbPeriodo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbPeriodo.Items.AddRange(new object[] {
            "",
            "1° Semestre",
            "2° Semestre",
            "3° Semestre",
            "4° Semestre",
            "5° Semestre",
            "6° Semestre"});
            this.cbPeriodo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbPeriodo.ListTextColor = System.Drawing.Color.DimGray;
            this.cbPeriodo.Location = new System.Drawing.Point(11, 464);
            this.cbPeriodo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Padding = new System.Windows.Forms.Padding(1);
            this.cbPeriodo.Size = new System.Drawing.Size(200, 30);
            this.cbPeriodo.TabIndex = 14;
            this.cbPeriodo.Texts = "";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Período:";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nivel de Acesso";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "RA/Matricula:";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Id:";
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbNivelAcesso.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbNivelAcesso.BorderSize = 1;
            this.cbNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbNivelAcesso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNivelAcesso.ForeColor = System.Drawing.Color.DimGray;
            this.cbNivelAcesso.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbNivelAcesso.Items.AddRange(new object[] {
            "",
            "Professor",
            "Aluno"});
            this.cbNivelAcesso.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbNivelAcesso.ListTextColor = System.Drawing.Color.DimGray;
            this.cbNivelAcesso.Location = new System.Drawing.Point(12, 411);
            this.cbNivelAcesso.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Padding = new System.Windows.Forms.Padding(1);
            this.cbNivelAcesso.Size = new System.Drawing.Size(200, 30);
            this.cbNivelAcesso.TabIndex = 14;
            this.cbNivelAcesso.Texts = "";
            // 
            // dgUsuario
            // 
            this.dgUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Location = new System.Drawing.Point(384, 279);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.RowTemplate.Height = 25;
            this.dgUsuario.Size = new System.Drawing.Size(850, 286);
            this.dgUsuario.TabIndex = 13;
            this.dgUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuario_CellClick);
            // 
            // UsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(875, 633);
            this.Controls.Add(this.dgUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNivelAcesso);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mnOpcao);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.mnOpcao;
            this.MaximizeBox = false;
            this.Name = "UsuarioView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_FormClosing);
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
        private RJButton btcadastrar;
        private RJButton btConsultar;
        private RJButton btExcluir;
        private RJButton btAlterar;
        private CustomControls.RJControls.RJTextBox txtId;
        private MenuStrip mnOpcao;
        private ToolStripMenuItem menuCadastrar;
        private ToolStripMenuItem menuConsultar;
        private CustomControls.RJControls.RJComboBox cbCurso;
        private Label label1;
        private CustomControls.RJControls.RJComboBox cbPeriodo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CustomControls.RJControls.RJComboBox cbNivelAcesso;
        private DataGridView dgUsuario;
    }
}