using AgendaProvas.Dao;
using AgendaProvas.Model;
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
        
        public int id;
        public int check;
        public CadastrarEventosView()
        {
            InitializeComponent();

        }
        private bool verificaCampos()
        {
            bool resultado = true;
            if (String.IsNullOrEmpty(txtDiscciplina.Texts) ||
                String.IsNullOrEmpty(txtEvento.Texts) ||
                String.IsNullOrEmpty(txtMdata.Text) ||
                String.IsNullOrEmpty(cbCurso.Texts) ||
                String.IsNullOrEmpty(cbPeriodo.Texts) ||
                String.IsNullOrEmpty(cbSala.Texts) ||
                String.IsNullOrEmpty(txtMhora.Text))
            {
                resultado = false;
            }
            return resultado;
        }

       
        private void btVoltar_Click(object sender, EventArgs e)
        {
            ProvasView voltar = new ProvasView();
            voltar.Show();
            voltar.btCadastrar.Visible = false;
            this.Hide();
        }

        private void CadastrarEventosView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #region botão editar evento
        public void receberEdit(Evento obj)
        {
            id = Convert.ToInt32(obj.Id.ToString());
            txtMdata.Text = obj.Data.ToString();
            txtMhora.Text = obj.Hora.ToString();
            txtEvento.Texts = obj.Eventos.ToString();
            txtDiscciplina.Texts = obj.Disciplina.ToString();
            cbPeriodo.Texts = obj.Periodo.ToString();
            cbCurso.Texts = obj.Curso.ToString();
            cbSala.Texts = obj.Sala.ToString();
        }
        #endregion

        #region cadastrar evento
        private void btCadastraEvento_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                Evento obj = new Evento();
                obj.Data = txtMdata.Text;
                obj.Hora = txtMhora.Text;
                obj.Eventos = txtEvento.Texts;
                obj.Disciplina = txtDiscciplina.Texts;
                obj.Periodo = cbPeriodo.Texts;
                obj.Curso = cbCurso.Texts;
                obj.Sala = cbSala.Texts;

                EventoDao dao = new EventoDao();
                if (check == 0)
                {
                    if (id == 0)
                    {
                        dao.cadastrarEvento(obj);
                        ProvasView retonar = new ProvasView();
                        retonar.btCadastrar.Visible = false;
                        retonar.Show();
                        this.Hide();
                    }
                    else
                    {
                        obj.Id = Convert.ToString(id);
                        dao.alterarEvento(obj);
                        ProvasView retonar = new ProvasView();
                        retonar.btCadastrar.Visible = false;
                        retonar.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if (id == 0)
                    {
                        dao.cadastrarEvento(obj);
                        ProvasView retonar = new ProvasView();
                        retonar.Show();
                        this.Hide();
                    }
                    else
                    {
                        obj.Id = Convert.ToString(id);
                        dao.alterarEvento(obj);
                        ProvasView retonar = new ProvasView();
                        retonar.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preechidos", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
