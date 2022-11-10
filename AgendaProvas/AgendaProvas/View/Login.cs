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
                    ArrayList verificarLogin = new ArrayList();
                    //Consulta loginConsulta = new Consulta();
                    //loginConsulta.consultar(txtEmailLogin.Texts, txtSenhaLogin.Texts);
                    //verificarLogin = loginConsulta.consultar(txtEmailLogin.Texts,txtSenhaLogin.Texts);
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