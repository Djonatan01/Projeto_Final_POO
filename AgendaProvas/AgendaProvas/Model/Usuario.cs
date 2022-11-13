using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProvas.Model
{
    public class Usuario
    {
        private int id;
        private string nome;
        private string email;
        private string senha;
        private int matricula;
        private string tipo;
        private string periodo;
        private string curso;

        public Usuario() { }

        public int Id { get ; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Matricula { get; set; }
        public string Tipo { get ; set; }
        public string Periodo { get; set; }
        public string Curso { get; set; }
        
    }
}
