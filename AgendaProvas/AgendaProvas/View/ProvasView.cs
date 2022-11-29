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

        private string retCurso = "";


        public ProvasView()
        {
            InitializeComponent();
            CarregarEvento();
        }
        
        public void CarregarEvento()
        {
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

        #region botão exluir
        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente excluir?","Excluir",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(resposta.ToString().Equals("Yes")) {  

            Evento obj = new Evento();
            obj.Id = dgProvas.CurrentRow.Cells[0].Value.ToString();

            EventoDao dao = new EventoDao();

            dao.excluirEvento(obj);

            CarregarEvento();
            }
        }
        #endregion

        #region botão editar
        private void btEditar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente alterar?", "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta.ToString().Equals("Yes"))
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
        }
        #endregion

        #region botão adicionar
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastrarEventosView cadEvento = new CadastrarEventosView();

            cadEvento.Show();

            this.Hide();
        }
        #endregion

        #region Ocultar botões aluno
        public void aluno(string tipoCurso)
        {
            retCurso = tipoCurso;
            EventoDao dao = new EventoDao();
            dgProvas.DataSource = dao.listarEventosPorCurso(retCurso);

            btAdicionar.Visible = false;
            btCadastrar.Visible = false;
            btEditar.Visible = false;
            btExcluir.Visible = false;
        }
        #endregion

        #region Ocultar botões professor
        public void professor()
        {
            CadastrarEventosView obj = new CadastrarEventosView();
            obj.check = 0;
            btCadastrar.Visible = false;
        }

        #endregion

        #region Filtrar por disciplina / curso
        private void txtPesquisaData__TextChanged(object sender, EventArgs e)
        {
            if(retCurso == "")
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
            else
            {
                if (txtPesquisaData.Texts == "")
                {
                    EventoDao dao = new EventoDao();
                    dgProvas.DataSource = dao.listarEventosPorCurso(retCurso);
                }
                else
                {
                    String data = txtPesquisaData.Texts;

                    EventoDao dao = new EventoDao();
                    dgProvas.DataSource = dao.listarEventosPorDataCurso(data, retCurso);
                }
            }
        }
        #endregion

        #region botão logoff
        private void btLogoff_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente fazer logoff?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta.ToString().Equals("Yes"))
            {
                Login logoff = new Login();
                logoff.Show();
                this.Hide();
            }
        }
        #endregion
    }
}
