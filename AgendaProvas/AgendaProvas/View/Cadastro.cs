using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Cadastrar formCadastrar1 = new Cadastrar();

            formCadastrar1.cadastrar(txtNome.Texts,txtEmail.Texts,txtSenha.Texts,txtMatricula.Texts,txtTipo.Texts,txtPeriodo.Texts,txtCurso.Texts);

        }
    }
}
