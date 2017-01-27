using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisConversoes
{
    class Program
    {
        enum acessorios { Sapato, Bolsa, Cinto, Carteira, Colar}
        static void Main(string[] args)
        {
            //retorna o valor do item do enum
            Console.WriteLine(acessorios.Cinto);

            //conversao explicita
            //convert o valor do item do enum e retorna seu indice dentro do enum
            int item1 = Convert.ToInt16(acessorios.Cinto);
            Console.WriteLine(item1);            

            //para conveter strings em numeros
            //parse apenas aceita strings como parametro
            string numero = "1234";
            int item2 = int.Parse(numero);
            Console.WriteLine(item2);

            //retorna true se for possivel a atribuição da variavel
            //numero do tipo string na variavel item3 do tipo Int32 
            int item3;
            bool resultado = Int32.TryParse(numero, out item3);
            Console.WriteLine(resultado);

            //cast
            int item4 = (int)acessorios.Cinto;
            Console.WriteLine(item4);

            //conversão implicita
            int valor1 = 100;
            long valor2 = valor1;
            Console.WriteLine(valor2);

            Console.ReadKey();
        }
    }
}
