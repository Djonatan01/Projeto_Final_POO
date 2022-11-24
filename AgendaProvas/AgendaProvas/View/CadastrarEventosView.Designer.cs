﻿namespace AgendaProvas.View
{
    partial class CadastrarEventosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarEventosView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btVoltar = new AgendaProvas.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDisciplina = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHora = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btCadastraEvento = new AgendaProvas.RJButton();
            this.txtData = new CustomControls.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPeriodo = new CustomControls.RJControls.RJComboBox();
            this.cbCurso = new CustomControls.RJControls.RJComboBox();
            this.cbSala = new CustomControls.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btVoltar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel1.Size = new System.Drawing.Size(597, 42);
            this.panel1.TabIndex = 1;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btVoltar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVoltar.BackgroundImage")));
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btVoltar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btVoltar.BorderRadius = 30;
            this.btVoltar.BorderSize = 0;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(8, 1);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(40, 41);
            this.btVoltar.TabIndex = 17;
            this.btVoltar.TextColor = System.Drawing.Color.White;
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(172, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cadastro de eventos";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDisciplina.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDisciplina.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDisciplina.BorderRadius = 15;
            this.txtDisciplina.BorderSize = 2;
            this.txtDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisciplina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDisciplina.Location = new System.Drawing.Point(13, 95);
            this.txtDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisciplina.Multiline = false;
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDisciplina.PasswordChar = false;
            this.txtDisciplina.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDisciplina.PlaceholderText = "";
            this.txtDisciplina.Size = new System.Drawing.Size(250, 31);
            this.txtDisciplina.TabIndex = 2;
            this.txtDisciplina.Texts = "";
            this.txtDisciplina.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Disciplina:";
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtHora.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHora.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHora.BorderRadius = 15;
            this.txtHora.BorderSize = 2;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHora.Location = new System.Drawing.Point(13, 209);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtHora.Multiline = false;
            this.txtHora.Name = "txtHora";
            this.txtHora.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHora.PasswordChar = false;
            this.txtHora.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHora.PlaceholderText = "";
            this.txtHora.Size = new System.Drawing.Size(250, 31);
            this.txtHora.TabIndex = 2;
            this.txtHora.Texts = "";
            this.txtHora.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(312, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Periodo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data:";
            // 
            // btCadastraEvento
            // 
            this.btCadastraEvento.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btCadastraEvento.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btCadastraEvento.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btCadastraEvento.BorderRadius = 15;
            this.btCadastraEvento.BorderSize = 0;
            this.btCadastraEvento.FlatAppearance.BorderSize = 0;
            this.btCadastraEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastraEvento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCadastraEvento.ForeColor = System.Drawing.Color.White;
            this.btCadastraEvento.Location = new System.Drawing.Point(213, 298);
            this.btCadastraEvento.Name = "btCadastraEvento";
            this.btCadastraEvento.Size = new System.Drawing.Size(150, 40);
            this.btCadastraEvento.TabIndex = 4;
            this.btCadastraEvento.Text = "Cadastrar";
            this.btCadastraEvento.TextColor = System.Drawing.Color.White;
            this.btCadastraEvento.UseVisualStyleBackColor = false;
            this.btCadastraEvento.Click += new System.EventHandler(this.btCadastraEvento_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtData.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtData.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtData.BorderRadius = 15;
            this.txtData.BorderSize = 2;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtData.Location = new System.Drawing.Point(13, 153);
            this.txtData.Margin = new System.Windows.Forms.Padding(4);
            this.txtData.Multiline = false;
            this.txtData.Name = "txtData";
            this.txtData.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtData.PasswordChar = false;
            this.txtData.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtData.PlaceholderText = "";
            this.txtData.Size = new System.Drawing.Size(250, 31);
            this.txtData.TabIndex = 2;
            this.txtData.Texts = "";
            this.txtData.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(312, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Curso:";
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
            this.cbPeriodo.Location = new System.Drawing.Point(312, 96);
            this.cbPeriodo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Padding = new System.Windows.Forms.Padding(1);
            this.cbPeriodo.Size = new System.Drawing.Size(200, 30);
            this.cbPeriodo.TabIndex = 16;
            this.cbPeriodo.Texts = "";
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
            this.cbCurso.Location = new System.Drawing.Point(312, 154);
            this.cbCurso.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Padding = new System.Windows.Forms.Padding(1);
            this.cbCurso.Size = new System.Drawing.Size(200, 30);
            this.cbCurso.TabIndex = 17;
            this.cbCurso.Texts = "";
            // 
            // cbSala
            // 
            this.cbSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbSala.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbSala.BorderSize = 1;
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbSala.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSala.ForeColor = System.Drawing.Color.DimGray;
            this.cbSala.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbSala.Items.AddRange(new object[] {
            "",
            "S1",
            "S2",
            "S3",
            "L1",
            "L2",
            "L3",
            "L4"});
            this.cbSala.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbSala.ListTextColor = System.Drawing.Color.DimGray;
            this.cbSala.Location = new System.Drawing.Point(312, 210);
            this.cbSala.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbSala.Name = "cbSala";
            this.cbSala.Padding = new System.Windows.Forms.Padding(1);
            this.cbSala.Size = new System.Drawing.Size(200, 30);
            this.cbSala.TabIndex = 17;
            this.cbSala.Texts = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sala / Laboratório:";
            // 
            // CadastrarEventosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(597, 414);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.btCadastraEvento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.panel1);
            this.Name = "CadastrarEventosView";
            this.Text = "ProvasView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastrarEventosView_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private CustomControls.RJControls.RJTextBox txtDisciplina;
        private Label label1;
        private CustomControls.RJControls.RJTextBox txtHora;
        private Label label3;
        private Label label4;
        private Label label5;
        private RJButton btCadastraEvento;
        private Label label6;
        private RJButton btVoltar;
        private CustomControls.RJControls.RJTextBox txtData;
        private Label label7;
        private CustomControls.RJControls.RJComboBox cbPeriodo;
        private CustomControls.RJControls.RJComboBox cbCurso;
        private CustomControls.RJControls.RJComboBox cbSala;
        private Label label2;
    }
}