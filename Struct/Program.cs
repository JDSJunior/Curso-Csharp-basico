using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public class Program
    {
        //uma struct é uma estrutura de dados mais simples que uma classe
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
            Livro l1;
            l1.codigo = 1;
            l1.autor = "Machado de assis";
            l1.titulo = "Dom Casmurro";

            Livro l2;
            l2.codigo = 2;
            l2.autor = "Jorge Amado";
            l2.titulo = "Gabriela";
        }
    }
}
