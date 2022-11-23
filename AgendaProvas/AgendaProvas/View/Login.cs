using AgendaProvas.Dao;
using AgendaProvas.View;
using System.Collections;

namespace AgendaProvas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtEmailLogin.Select();
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

                        ProvasView prov = new ProvasView();

                        prov.Show();

                        this.Hide();
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