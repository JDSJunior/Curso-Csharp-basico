using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;

            //executa depois verifica a condição
            do 
            {
                //a = a + 1;
                a++;
                Console.WriteLine(a);
            }
            while(a < 10);

            //verifica depois executa
            while( b < 10)
            {
                b++;
                Console.WriteLine(b);
            }

        }
    }
}
