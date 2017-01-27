using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //atribuindo valores nulos as varivaies
            //usa-se o ? para a variavel aceitar o valor
            //é obrigatório das variaveis de tipo numérico
            //nullable
            int? i = null;

            string s = null;

            //anonymoustypes muito usado em LINQ
            //guardando valores em coleções tipificadas
            //não aceita variaveis nulas
            var valores = new { idade = 18, nome = "José Júnior" };

            //array de anonymoustypes
            var valores2 = new[] { new { idade = 18, nome = "José Júnior" }, new { idade = 20, nome="dariana" } };

            //extraindo valores do anonymoustype
            foreach (var item in valores2)
            {
                Console.WriteLine("Nome :" + item.nome.ToString() + ", Idade: " + item.idade.ToString());
            }

            Console.ReadKey();
        }
    }
}
