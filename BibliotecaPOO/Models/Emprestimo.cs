using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOO.Models
{
    internal class Emprestimo

    {
        private string titulo;
        private string autor;
        private List<string> assuntos;

        public string Titulo { get; set; }
        public string Autor { get; set; }

        public List<string> Assuntos { get; set; }

        public Material(string titulo, string? autor = null)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.assuntos = new List<string>();
        }

      
        
    }
}
