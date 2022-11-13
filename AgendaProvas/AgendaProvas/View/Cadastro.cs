using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaProvas.Dao;
using AgendaProvas.Model;
using static System.Net.Mime.MediaTypeNames;
//using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgendaProvas
{
    public partial class Cadastro : Form
    {
        private int id, matricula;
        public Cadastro()
        {
            InitializeComponent();
            menuCadastrar_Click();
        }
        private void btcadastrar_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();
            obj.Nome = txtNome.Texts;
            obj.Email = txtEmail.Texts;
            obj.Senha = txtEmail.Texts;
            obj.Matricula = Convert.ToInt32(txtMatricula.Texts);
            obj.Tipo = txtTipo.Texts;
            obj.Periodo = txtPeriodo.Texts;
            obj.Curso = txtCurso.Texts;

            UsuarioDao dao = new UsuarioDao();

            dao.cadastrarUsuario(obj);

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();
            obj.Id = id;
            obj.Nome = txtNome.Texts;
            obj.Email = txtEmail.Texts;
            obj.Senha = txtEmail.Texts;
            obj.Matricula = matricula;
            obj.Tipo = txtTipo.Texts;
            obj.Periodo = txtPeriodo.Texts;
            obj.Curso = txtCurso.Texts;

            UsuarioDao dao = new UsuarioDao();

            dao.alterarUsuario(obj);

        }
        private void btConsultar_Click(object sender, EventArgs e) 
        {         



        }

        private void menuCadastrar_Click(object sender, EventArgs e)
        {
            menuCadastrar_Click();
        }
      
        public void menuCadastrar_Click()
        {
            // Visualizar os campos
            txtId.Enabled = false;
            btConsultar.Visible = false;
            txtId.Visible = true;
            dgUsuario.Visible = false;
            btAlterar.Visible = true;
            btExcluir.Visible = true;
            btcadastrar.Visible = true;
            txtEmail.Visible = true;
            txtSenha.Visible = true;
            txtTipo.Visible = true;
            txtPeriodo.Visible = true;
            txtCurso.Visible = true;
        }
        private void menuConsultar_Click(object sender, EventArgs e)
        {
            // Ocultar os campos
            txtId.Visible = false;
            dgUsuario.Visible = true;
            btConsultar.Visible = true;
            btAlterar.Visible = false;
            btExcluir.Visible = false;
            btcadastrar.Visible = false;
            txtEmail.Visible = false;
            txtSenha.Visible = false;
            txtTipo.Visible = false;
            txtPeriodo.Visible = false;
            txtCurso.Visible = false;
            //implementar o método listar
            UsuarioDao dao = new UsuarioDao();
            dgUsuario.DataSource = dao.listarUsuarios();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            //implementar o método listar
            UsuarioDao dao = new UsuarioDao();
            dgUsuario.DataSource = dao.listarUsuarios();

        }

        private void dgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgUsuario.CurrentRow.Cells[0].Value.ToString());
            matricula = int.Parse(dgUsuario.CurrentRow.Cells[1].Value.ToString());

            txtId.Texts = dgUsuario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Texts = dgUsuario.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Texts = dgUsuario.CurrentRow.Cells[3].Value.ToString();
            txtSenha.Texts = dgUsuario.CurrentRow.Cells[4].Value.ToString();
            txtMatricula.Texts = dgUsuario.CurrentRow.Cells[1].Value.ToString();
            txtTipo.Texts = dgUsuario.CurrentRow.Cells[5].Value.ToString();
            txtPeriodo.Texts = dgUsuario.CurrentRow.Cells[6].Value.ToString();
            txtCurso.Texts = dgUsuario.CurrentRow.Cells[7].Value.ToString();
           
            txtId.Enabled = false;
            btConsultar.Visible = false;
            txtId.Visible = true;
            dgUsuario.Visible = false;
            btAlterar.Visible = true;
            btExcluir.Visible = true;
            btcadastrar.Visible = true;
            txtEmail.Visible = true;
            txtSenha.Visible = true;
            txtTipo.Visible = true;
            txtPeriodo.Visible = true;
            txtCurso.Visible = true;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();

            obj.Id = id;

            UsuarioDao dao = new UsuarioDao();
            dao.excluirUsuario(obj);            
        }
    }
}
