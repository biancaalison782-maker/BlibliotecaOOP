using BibliotecaPOO.Models;

namespace BibliotecaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Material.ReferenceEquals livro = new Material(
                "Receitas de bolo",
                ["Receitas", "Doces", "Culinária", "Rango", "boia", "Rala bucho"]
                , "rita Lobo");

            Livro.mostrarInformacoes();

            Material violaoDaBiblioteca = new Material(
                "VIolão Clássico")


        }

            
       

        
    }
}
