using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOO.Models
{
    internal class Material
    {
        private string titulo;
        private string autor;
        private List<string> assuntos;

        public string Titulo { get; set; }
        public string Autor { get; set; }

        public List<string> Assuntos { get; set; }

        public Material(string titulo,  List<string> assuntos, string? autor = null)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.assuntos = new List<string>();
        }

        public void mostrarInformacoes()
        {
            Console.WriteLine($"Título: {this.titulo}");

            if (!string.IsNullOrWhiteSpace(autor))
            {
                Console.WriteLine($"Autor: {autor}");

            }

            Console.WriteLine($"Assuntos: {string.Join(", ", assuntos)}");
            Console.WriteLine($"--------------------------");
        }
    }
}
