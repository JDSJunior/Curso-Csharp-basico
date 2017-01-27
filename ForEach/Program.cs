using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ForEach
{
    class Program
    {
        public struct Livro
        {
            public string titulo;
            public string autor;
            public int codigo;
            public int anodepublicacao;
        }
        static void Main(string[] args)
        {
            //uma struct pode ser instanciada sem o uso do new
            // Livro l1 = new Livro();
            Livro l1 = new Livro();
            l1.codigo = 1;
            l1.autor = "Machado de assis";
            l1.titulo = "Dom Casmurro";

            Livro l2 = new Livro();
            l2.codigo = 2;
            l2.autor = "Jorge Amado";
            l2.titulo = "Gabriela";

            //ArrayList livros = new ArrayList();
            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);

            foreach (Livro item in livros)
            {
                Console.WriteLine("Livro Código: " + item.codigo.ToString());
                Console.WriteLine("Autor do Livro: " + item.autor.ToString());
                Console.WriteLine("Titulo Livro: " + item.titulo.ToString());
                Console.WriteLine("Ano de publicção: " + item.anodepublicacao.ToString());
                Console.WriteLine("---------------------------------------------");
            }

            for (int i = 0; i < livros.Count; i++)
            {
                //ElementAt retorna um elemento em um indice especifico
                Console.WriteLine("Livro Código: " + livros.ElementAt(i).codigo.ToString());
                Console.WriteLine("Autor do Livro: " + livros.ElementAt(i).autor.ToString());
                Console.WriteLine("Titulo do Livro: " + livros.ElementAt(i).titulo.ToString());
                Console.WriteLine("Ano de publicação: " + livros.ElementAt(i).anodepublicacao.ToString());
                Console.WriteLine("---------------------------------------------");
            }

                Console.ReadKey();
        }
    }
}
