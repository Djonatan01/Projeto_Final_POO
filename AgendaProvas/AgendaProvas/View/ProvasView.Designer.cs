namespace AgendaProvas.View
{
    partial class ProvasView
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgProvas = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new AgendaProvas.RJButton();
            this.btAdicionar = new AgendaProvas.RJButton();
            this.btEditar = new AgendaProvas.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel1.Size = new System.Drawing.Size(757, 42);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programação do Dia";
            // 
            // dgProvas
            // 
            this.dgProvas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgProvas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProvas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProvas.Location = new System.Drawing.Point(12, 60);
            this.dgProvas.Name = "dgProvas";
            this.dgProvas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgProvas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgProvas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgProvas.RowTemplate.Height = 25;
            this.dgProvas.Size = new System.Drawing.Size(730, 377);
            this.dgProvas.TabIndex = 2;
            this.dgProvas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProvas_CellContentClick);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btCadastrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btCadastrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btCadastrar.BorderRadius = 15;
            this.btCadastrar.BorderSize = 0;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCadastrar.ForeColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(161, 443);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(120, 40);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.TextColor = System.Drawing.Color.White;
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAdicionar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btAdicionar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAdicionar.BorderRadius = 15;
            this.btAdicionar.BorderSize = 0;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAdicionar.ForeColor = System.Drawing.Color.White;
            this.btAdicionar.Location = new System.Drawing.Point(435, 443);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(108, 40);
            this.btAdicionar.TabIndex = 5;
            this.btAdicionar.Text = "Adicionar eventos";
            this.btAdicionar.TextColor = System.Drawing.Color.White;
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btEditar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btEditar.BorderRadius = 15;
            this.btEditar.BorderSize = 0;
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEditar.ForeColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(298, 443);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(120, 40);
            this.btEditar.TabIndex = 5;
            this.btEditar.Text = "Editar";
            this.btEditar.TextColor = System.Drawing.Color.White;
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // ProvasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(757, 514);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgProvas);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "ProvasView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProvasView_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgProvas;
        private RJButton btCadastrar;
        private RJButton btAdicionar;
        private RJButton btEditar;
    }
}