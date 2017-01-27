using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //colocamos o valor de uma variavel de outro tipo
            //dentro de um tipo object(superclasse de todas os tipos)

            //boxing 
            int valorInteiro = 100;
            object valorObject = valorInteiro;

            Console.WriteLine(valorObject.GetType());

            //retiramos os valor das variaveis do tipo object
            //dentro de outro tipo

            //unboxing
            int valorInteiro2 = (int)valorObject;
            Console.WriteLine(valorInteiro2);
            
            //podemos usar o cast diretamente sem atribuir o resultado
            //a outra variavel
            //unboxing
            ((int)valorObject).GetType();

            Console.ReadKey();
        }
    }
}
