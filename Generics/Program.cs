using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> cria uma lista com apenas o tipo descrito, sem unboxing para 
            //recuperação dos dados
            List<int> l1 = new List<int>();
            l1.Add(10);
            l1.Add(20);
            l1.Add(30);

            Console.WriteLine(l1[0].ToString());
            Console.ReadKey();

            List<bool> l2 = new List<bool>();


        }
    }
}
