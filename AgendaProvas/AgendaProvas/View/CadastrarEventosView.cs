using AgendaProvas.Dao;
using AgendaProvas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaProvas.View
{
    public partial class CadastrarEventosView : Form
    {
        public CadastrarEventosView()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            ProvasView voltar = new ProvasView();

            voltar.Show();

            this.Hide();
        }

        private void CadastrarEventosView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btCadastraEvento_Click(object sender, EventArgs e)
        {
           
            Evento obj = new Evento();
            obj.Data = txtMdata.Text;
            obj.Hora = txtMhora.Text;
            obj.Disciplina = txtDisciplina.Texts;
            obj.Periodo = cbPeriodo.Texts;
            obj.Curso = cbCurso.Texts;
            obj.Sala = cbSala.Texts;

            EventoDao dao = new EventoDao();

            dao.cadastrarEvento(obj);
        }
    }
}
