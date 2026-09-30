using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOO.Models
{
    internal class Livro : Material

    {
        public Livro(string titulo, List<string> assuntos, string? autor = null) : base(titulo, assuntos, autor)
        {

        }
    }
}
