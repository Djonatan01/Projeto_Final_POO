﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaProvas.Dao;
using AgendaProvas.Model;

namespace AgendaProvas.View
{
    public partial class ProvasView : Form
    {
        public ProvasView()
        {
            InitializeComponent();
            EventoDao dao = new EventoDao();
            dgProvas.DataSource = dao.listarEventos();
        }
        
        private void ProvasView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioView cad = new UsuarioView();
            
            cad.Show();

            this.Hide();
        }
        private void btEditar_Click(object sender, EventArgs e)
        {
            Evento obj = new Evento();
            obj.Id = dgProvas.CurrentRow.Cells[0].Value.ToString();
            obj.Data = dgProvas.CurrentRow.Cells[1].Value.ToString();
            obj.Hora = dgProvas.CurrentRow.Cells[2].Value.ToString();
            obj.Disciplina = dgProvas.CurrentRow.Cells[3].Value.ToString();
            obj.Periodo = dgProvas.CurrentRow.Cells[4].Value.ToString();
            obj.Curso = dgProvas.CurrentRow.Cells[5].Value.ToString();
            obj.Sala = dgProvas.CurrentRow.Cells[6].Value.ToString();

            CadastrarEventosView cad = new CadastrarEventosView();
            cad.receberEdit(obj);
            cad.Show();
            this.Hide();

            //txtId.Texts = dgUsuario.CurrentRow.Cells[0].Value.ToString();
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastrarEventosView cadEvento = new CadastrarEventosView();

            cadEvento.Show();

            this.Hide();
        }

        private void dgProvas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
