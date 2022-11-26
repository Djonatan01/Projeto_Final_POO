using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgendaProvas.View
{
    public partial class ProvasView : Form
    {
        public object bindingSource { get; private set; }
        public string retCurso;
        EventoDao dao = new EventoDao();
        public ProvasView()
        {
            InitializeComponent();
            CarregarEvento();
        }
        
        public void CarregarEvento()
        {
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
        private void btExcluir_Click(object sender, EventArgs e)
        {
            Evento obj = new Evento();
            obj.Id = dgProvas.CurrentRow.Cells[0].Value.ToString();

            EventoDao dao = new EventoDao();

            dao.excluirEvento(obj);

            CarregarEvento();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Evento obj = new Evento();
            obj.Id = dgProvas.CurrentRow.Cells[0].Value.ToString();
            obj.Data = dgProvas.CurrentRow.Cells[1].Value.ToString();
            obj.Hora = dgProvas.CurrentRow.Cells[2].Value.ToString();
            obj.Eventos = dgProvas.CurrentRow.Cells[3].Value.ToString();
            obj.Disciplina = dgProvas.CurrentRow.Cells[4].Value.ToString();
            obj.Periodo = dgProvas.CurrentRow.Cells[5].Value.ToString();
            obj.Curso = dgProvas.CurrentRow.Cells[6].Value.ToString();
            obj.Sala = dgProvas.CurrentRow.Cells[7].Value.ToString();

            CadastrarEventosView cad = new CadastrarEventosView();
            cad.receberEdit(obj);
            cad.Show();
            this.Hide();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastrarEventosView cadEvento = new CadastrarEventosView();

            cadEvento.Show();

            this.Hide();
        }

        public void aluno(string tipoCurso)
        {
            retCurso = tipoCurso;
            
            dgProvas.DataSource = dao.listarEventosPorCorso(retCurso);

            btAdicionar.Visible = false;
            btCadastrar.Visible = false;
            btEditar.Visible = false;
            btExcluir.Visible = false;
        }

        public void professor()
        {
            btCadastrar.Visible = false;
        }
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Login voltaLogin = new Login();
            voltaLogin.Show();
            this.Hide();
        }

        private void txtPesquisaData__TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaData.Texts == "")
            {
                EventoDao dao = new EventoDao();
                dgProvas.DataSource = dao.listarEventos();
            }
            else
            {
                String data = txtPesquisaData.Texts;

                EventoDao dao = new EventoDao();
                dgProvas.DataSource = dao.listarEventosPorDisciplina(data);
            }

        }
    }
}
