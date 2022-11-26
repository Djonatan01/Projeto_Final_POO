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
                    string [] check;
                    string retorno;
                    retorno = dao.login(txtEmailLogin.Texts,txtSenhaLogin.Texts);

                    check = retorno.Split('/');

                    ProvasView prov = new ProvasView();

                    switch (check[0])
                    {
                        
                        case "0":
                            prov.Show();
                            this.Hide();
                            break;

                        case "1":
                            prov.Show();                           
                            this.Hide();
                            prov.aluno(check[1]);                           
                            break;
                        case "3":
                            prov.Show();
                            this.Hide();
                            prov.professor();
                            break;
                        default:
                            MessageBox.Show("Email e/ou Senha inválidos ",
                        "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
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