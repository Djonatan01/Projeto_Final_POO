using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaProvas.View
{
    public partial class CadastrarEventosView : Form
    {
        public CadastrarEventosView()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            ProvasView voltar = new ProvasView();

            voltar.Show();

            this.Hide();
        }

        private void CadastrarEventosView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
