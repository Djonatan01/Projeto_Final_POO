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

        public Usuario()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string Curso { get => curso; set => curso = value; }
    }
}
