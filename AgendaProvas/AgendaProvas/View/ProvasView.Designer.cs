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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvasView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLogoff = new AgendaProvas.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgProvas = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new AgendaProvas.RJButton();
            this.btAdicionar = new AgendaProvas.RJButton();
            this.btEditar = new AgendaProvas.RJButton();
            this.btExcluir = new AgendaProvas.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesquisaData = new CustomControls.RJControls.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btLogoff);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel1.Size = new System.Drawing.Size(757, 42);
            this.panel1.TabIndex = 1;
            // 
            // btLogoff
            // 
            this.btLogoff.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btLogoff.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btLogoff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLogoff.BackgroundImage")));
            this.btLogoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btLogoff.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btLogoff.BorderRadius = 30;
            this.btLogoff.BorderSize = 0;
            this.btLogoff.FlatAppearance.BorderSize = 0;
            this.btLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogoff.ForeColor = System.Drawing.Color.White;
            this.btLogoff.Location = new System.Drawing.Point(707, 0);
            this.btLogoff.Name = "btLogoff";
            this.btLogoff.Size = new System.Drawing.Size(40, 41);
            this.btLogoff.TabIndex = 17;
            this.btLogoff.TextColor = System.Drawing.Color.White;
            this.btLogoff.UseVisualStyleBackColor = false;
            this.btLogoff.Click += new System.EventHandler(this.btLogoff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programação do Dia";
            // 
            // dgProvas
            // 
            this.dgProvas.AllowUserToAddRows = false;
            this.dgProvas.AllowUserToDeleteRows = false;
            this.dgProvas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgProvas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProvas.ColumnHeadersHeight = 20;
            this.dgProvas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgProvas.Location = new System.Drawing.Point(8, 101);
            this.dgProvas.Name = "dgProvas";
            this.dgProvas.ReadOnly = true;
            this.dgProvas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgProvas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgProvas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgProvas.RowTemplate.Height = 25;
            this.dgProvas.Size = new System.Drawing.Size(737, 377);
            this.dgProvas.TabIndex = 2;
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
            this.btCadastrar.Location = new System.Drawing.Point(618, 55);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(120, 40);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "Gerenciar Alunos";
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
            this.btAdicionar.Location = new System.Drawing.Point(194, 484);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(100, 40);
            this.btAdicionar.TabIndex = 5;
            this.btAdicionar.Text = "Adicionar Eventos";
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
            this.btEditar.Location = new System.Drawing.Point(308, 484);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(100, 40);
            this.btEditar.TabIndex = 5;
            this.btEditar.Text = "Editar Eventos";
            this.btEditar.TextColor = System.Drawing.Color.White;
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btExcluir.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btExcluir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btExcluir.BorderRadius = 15;
            this.btExcluir.BorderSize = 0;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Location = new System.Drawing.Point(420, 484);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(100, 40);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Excluir Eventos";
            this.btExcluir.TextColor = System.Drawing.Color.White;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pesquisa por data:";
            // 
            // txtPesquisaData
            // 
            this.txtPesquisaData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPesquisaData.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPesquisaData.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPesquisaData.BorderRadius = 10;
            this.txtPesquisaData.BorderSize = 2;
            this.txtPesquisaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisaData.ForeColor = System.Drawing.Color.White;
            this.txtPesquisaData.Location = new System.Drawing.Point(35, 64);
            this.txtPesquisaData.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaData.Multiline = false;
            this.txtPesquisaData.Name = "txtPesquisaData";
            this.txtPesquisaData.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPesquisaData.PasswordChar = false;
            this.txtPesquisaData.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPesquisaData.PlaceholderText = "";
            this.txtPesquisaData.Size = new System.Drawing.Size(250, 31);
            this.txtPesquisaData.TabIndex = 16;
            this.txtPesquisaData.Texts = "";
            this.txtPesquisaData.UnderlinedStyle = false;
            this.txtPesquisaData._TextChanged += new System.EventHandler(this.txtPesquisaData__TextChanged);
            // 
            // ProvasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(757, 535);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPesquisaData);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgProvas);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaximizeBox = false;
            this.Name = "ProvasView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProvasView_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgProvas;
        public RJButton btCadastrar;
        private RJButton btAdicionar;
        private RJButton btEditar;
        private RJButton btExcluir;
        private Label label6;
        private CustomControls.RJControls.RJTextBox txtPesquisaData;
        private RJButton btLogoff;
    }
}