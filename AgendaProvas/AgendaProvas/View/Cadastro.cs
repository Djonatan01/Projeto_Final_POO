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
//using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgendaProvas
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
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

            dao.cadastrar(obj);

        }

        private void btAlterar_Click(object sender, EventArgs e)
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

            dao.alterar(obj);

        }
        private void btConsultar_Click(object sender, EventArgs e)
        {

        }

        private void menuCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
