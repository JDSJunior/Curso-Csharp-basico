using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 0:
                    Console.WriteLine(0);
                    break;

                case 5:
                    Console.WriteLine(5);
                    break;

                case 10:
                    Console.WriteLine(10);
                    break;

                default:
                    Console.WriteLine(" c sem valor conhecido!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
