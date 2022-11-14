using AgendaProvas.Dao;
using System.Collections;

namespace AgendaProvas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            try { 
                if (String.IsNullOrEmpty(txtEmailLogin.Texts) || String.IsNullOrEmpty(txtSenhaLogin.Texts))
                {
                    MessageBox.Show("Preencha o e-email ou senha", "E-mail ou senha vazio", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    UsuarioDao dao = new UsuarioDao();
                    bool check = false;
                    check = dao.login(txtEmailLogin.Texts,txtSenhaLogin.Texts);
                    if (check == true) 
                    {

                        Cadastro cad = new Cadastro();
                        cad.Show();
                    }
                    else
                    {

                    }
                }
            }
            catch
            {
                MessageBox.Show("Preencha o e-email", "E-mail vazio", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}