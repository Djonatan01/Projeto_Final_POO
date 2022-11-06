using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ConexaoBanco formCadastrar = new ConexaoBanco();
            formCadastrar.cadastrar(txtNome.Texts, txtEmail.Texts, txtSenha.Texts, txtMatricula.Texts,
                txtPeriodo.Texts,txtCurso.Texts);
        }
    }
}
