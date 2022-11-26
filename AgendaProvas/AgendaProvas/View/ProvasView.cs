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

namespace AgendaProvas.View
{
    public partial class ProvasView : Form
    {
        public ProvasView()
        {
            InitializeComponent();
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

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadastrarEventosView cadEvento = new CadastrarEventosView();

            cadEvento.Show();

            this.Hide();
        }
    }
}
