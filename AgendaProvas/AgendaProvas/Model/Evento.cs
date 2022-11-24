using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaProvas.Model
{
    public class Evento
    {
        private int id;
        private string data;
        private string hora;
        private string disciplina;
        private string periodo;
        private string curso;
        private string sala;

        public Evento() { }

        public string Id { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string Disciplina { get; set; }
        public string Periodo { get; set; }
        public string Curso { get; set; }
        public string Sala { get; set; }


    }
}
