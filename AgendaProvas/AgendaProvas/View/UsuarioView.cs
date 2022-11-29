using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaProvas.Dao;
using AgendaProvas.Model;
using AgendaProvas.View;
using static System.Net.Mime.MediaTypeNames;
//using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Application = System.Windows.Forms.Application;

namespace AgendaProvas
{
    public partial class UsuarioView : Form
    {
        private int id, matricula;
        public UsuarioView()
        {
            InitializeComponent();
            menuCadastrar_Click();
        }
        private bool verificaCampos()
        {
            bool resultado = true;
            if (String.IsNullOrEmpty(txtNome.Texts) ||
                String.IsNullOrEmpty(txtMatricula.Texts)||
                String.IsNullOrEmpty(txtEmail.Texts)||
                String.IsNullOrEmpty(txtSenha.Texts)||
                String.IsNullOrEmpty(cbNivelAcesso.Texts)||
                String.IsNullOrEmpty(cbCurso.Texts))
            {
                resultado = false;
            }
            return resultado;
        }
        private void btcadastrar_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                Usuario obj = new Usuario();
                obj.Nome = txtNome.Texts;
                obj.Email = txtEmail.Texts;
                obj.Senha = txtSenha.Texts;
                obj.Matricula = txtMatricula.Texts;
                obj.Tipo = cbNivelAcesso.Texts;
                obj.Periodo = cbPeriodo.Texts;
                obj.Curso = cbCurso.Texts;

                UsuarioDao dao = new UsuarioDao();

                dao.cadastrarUsuario(obj);

                LimparForm();
            }
            else
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preechidos","Campos vazios",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #region botão editar
        private void btAlterar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente alterar?", "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta.ToString().Equals("Yes"))
            {
                if (verificaCampos())
                {
                    Usuario obj = new Usuario();
                    obj.Id = id;
                    obj.Nome = txtNome.Texts;
                    obj.Email = txtEmail.Texts;
                    obj.Senha = txtSenha.Texts;
                    obj.Matricula = txtMatricula.Texts;
                    obj.Tipo = cbNivelAcesso.Texts;
                    obj.Periodo = cbPeriodo.Texts;
                    obj.Curso = cbCurso.Texts;
                    UsuarioDao dao = new UsuarioDao();

                    dao.alterarUsuario(obj);
                    //Limpar os campos 
                    LimparForm();
                }
            }
        }
        #endregion

        public void LimparForm()
        {
            txtNome.Texts = "";
            txtEmail.Texts = "";
            txtSenha.Texts = "";
            txtMatricula.Texts = "";
            cbNivelAcesso.Texts = "";
            cbPeriodo.Texts = "";
            cbCurso.Texts = "";
        }

        private void menuCadastrar_Click(object sender, EventArgs e)
        {
            menuCadastrar_Click();
        }
      
        public void menuCadastrar_Click()
        {
            // Visualizar os campos
            dgUsuario.Visible = false;
            btAlterar.Visible = true;
            btExcluir.Visible = true;
            btcadastrar.Visible = true;
            txtEmail.Visible = true;
            txtSenha.Visible = true;
            cbNivelAcesso.Visible = true;
            cbPeriodo.Visible = true;
            cbCurso.Visible = true;  
            

        }
        private void menuConsultar_Click(object sender, EventArgs e)
        {

            menuConsultar_Click();

            //implementar o método listar
            UsuarioDao dao = new UsuarioDao();
            dgUsuario.DataSource = dao.listarUsuarios();
            
        }
        public void menuConsultar_Click()
        {
            // Ocultar os campos
            dgUsuario.Visible = true;
            btAlterar.Visible = false;
            btExcluir.Visible = false;
            btcadastrar.Visible = false;
            txtEmail.Visible = false;
            txtSenha.Visible = false;
            cbNivelAcesso.Visible = false;
            cbPeriodo.Visible = false;
            cbCurso.Visible = false;
            txtMatricula.Texts = "";
            txtNome.Texts = "";
            LimparForm();
        }
        private void Cadastro_Load(object sender, EventArgs e)
        {
            //implementar o método listar
            UsuarioDao dao = new UsuarioDao();
            dgUsuario.DataSource = dao.listarUsuarios();

        }

        private void dgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgUsuario.CurrentRow.Cells[0].Value.ToString());
            txtNome.Texts = dgUsuario.CurrentRow.Cells[1].Value.ToString();
            lbUsuario.Text = dgUsuario.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Texts = dgUsuario.CurrentRow.Cells[2].Value.ToString();
            txtSenha.Texts = dgUsuario.CurrentRow.Cells[3].Value.ToString();
            txtMatricula.Texts = dgUsuario.CurrentRow.Cells[4].Value.ToString();
            cbNivelAcesso.Texts = dgUsuario.CurrentRow.Cells[5].Value.ToString();
            cbPeriodo.Texts = dgUsuario.CurrentRow.Cells[6].Value.ToString();
            cbCurso.Texts = dgUsuario.CurrentRow.Cells[7].Value.ToString();
            menuCadastrar_Click();
        }
        #region botão excluir usuários
        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente Exluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta.ToString().Equals("Yes"))
            {
                Usuario obj = new Usuario();

                obj.Id = id;

                UsuarioDao dao = new UsuarioDao();
                dao.excluirUsuario(obj);

                //Limpar os campos 
                LimparForm();
            }
        }
        #endregion
        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;

            if (txtMatricula.Texts.Length + 1 >= 13) e.Handled = true; 

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            ProvasView voltar = new ProvasView();

            voltar.Show();

            this.Hide();
        }

        private void txtNome__TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Texts == "")
            {
                //implementar o método listar
                UsuarioDao dao = new UsuarioDao();
                dgUsuario.DataSource = dao.listarUsuarios();
            }
            else
            {
                String nome = txtNome.Texts;

                UsuarioDao dao = new UsuarioDao();
                dgUsuario.DataSource = dao.listarUsuariosNome(nome);
            }
        }

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
