using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //statemant if else
            //if - verifica se a condição é verdadeira
            //#region  delimitador de região

            //atalhos de comentário

            #region if

            int a = 10;

            if (a == 5)
            {
                Console.WriteLine(" a = 5");
            }
            else
            {
                Console.WriteLine("a <> 5");
            }

            //sintaxe alternativa
            // se a > 10 b recebe 5 senão recebe 8

            int b = (a > 10) ? 5 : 8 ;

            Console.ReadKey();

            #endregion
        }
    }
}
