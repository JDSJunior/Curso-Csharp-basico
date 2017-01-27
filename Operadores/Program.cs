using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores

            int a = 10;
            int b = 2;

            //adicição
            int add = a + b;

            //subtração
            int sub = a - b;

            //multiplicação
            int multi = a * b;

            //divisão
            int div = a / b;

            //resto da divisão
            int res = a % b;

            //primarios
            //incremento i++;
            //decremento i--;

            //comparativo
            //maior
            if (a > b)
            {
                //Console.WriteLine("a > b");
            }

            //menor
            if (b < a)
            {
                //Console.WriteLine("b < a");
            }

            //maior ou igual
            if (a >= b)
            {
                //Console.WriteLine("a maior ou igual b");
            }

            //menor ou igual
            if (a <= b)
            {
                //Console.WriteLine("a menor ou igual");
            }

            //igual
            if (a == b)
            {
                //Console.WriteLine("a igual b");
            }

            //diferente
            if (a != b)
            {
                //Console.WriteLine("a diferente de b");
            }


            //logicos
            //xor(logico exclusivo)
            //apenas quando as duas comparação são diferentes
            if (true ^ false)
            {
                //To Do
            }


            //condicionais
            //and(e)
            if (true && true)
            {
                //To Do
            }

            //or(ou)
            if (true || false)
            {
                //To Do
            }

            #endregion

            //Exemplo Operadores

            Console.WriteLine("Digite um valor para A:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para B:");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("A + B = " + Convert.ToInt16(valor1 + valor2));
            Console.WriteLine("A - B = " + Convert.ToInt16(valor1 - valor2));
            Console.WriteLine("A * B = " + Convert.ToInt16(valor1 * valor2));

            //para obter o resultado com casas decimais deve-se converter pelo
            //menos uma variavel para double para o compilador não chamar o metodo
            //de divisão de inteiros retirar as casas decimais
            Console.WriteLine("A / B = " + Convert.ToDecimal(valor1 / (double)valor2));

            //classe math para calculos matematicos .pow raiz quadrada
            Console.WriteLine("A elevado B = " + Math.Pow(valor1, valor2));
            
            Console.ReadKey();

        }
    }
}
