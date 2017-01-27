using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementandoClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno();

            //instanciando a classe com os parametros necessarios do construtor 
            Aluno a3 = new Aluno("Dariana", 25);

            a1.Nome = "junior";
            a1.Idade = 25;

            Console.WriteLine(a1.GetTwiceIdade());

            Console.WriteLine(a1.Major(25).ToString());

            Console.WriteLine(a1.GetNome());

            //chamada do metodo
            a1.Limpar();

            Console.ReadKey();
        }
    }
}
