using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraysEArraysList
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando um array unidimensional
            //array unidimensional delimitado a cinco posicoes
            //int[] array = new int[5] {1, 2, 3, 4, 5};
            //int[] array = new int[5];
            //array[0] = 1;
            //array[1] = 2;
            //array[2] = 3;
            //array[3] = 4;
            //array[4] = 5;

            //inserindo dinamicamente os valores no array
            //for (int i = 0; i < 5; i++)
            //{
            //    array[i] = i + 1;
            //}

            //    extraindo os valores do array com foreach
            //    foreach (var item in array)
            //    {
            //        Console.WriteLine(item);
            //    }

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //criando array multidimensional
            //array multidimencional delimitado com 4 posicoes
            //int[,] arraymultidimensional = new int[2, 2];
            //arraymultidimensional[0, 0] = 1;
            //arraymultidimensional[1, 0] = 2;
            //arraymultidimensional[0, 1] = 3;
            //arraymultidimensional[1, 1] = 4;

            //inserindo dinamicamente os valores no arraymultidimensional
            //int z = 0;
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int x = 0; x < 2; x++)
            //    {
            //        arraymultidimensional[i, x] = z++;
            //    }
            //}

            //    extraindo valores do arraymultidimensional com foreach
            //    foreach (var item in arraymultidimensional)
            //    {
            //        Console.WriteLine(item);
            //    }

            //extraindo os valores do arraymultidimensional com for
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int x = 0; x < 2; x++)
            //    {
            //        Console.WriteLine(arraymultidimensional[x, i]);
            //    }
            //}

            //arrayList array dinamico que pode conter varios elementos de 
            //diferentes tipos que sao convertidos em objetc com outros tipos de metodos
            ArrayList coisas = new ArrayList();
            coisas.Add(150);
            coisas.Add("Coisas");
            coisas.Add(true);

            //cast de object para string
            string s1 = (string)coisas[1];

            //foreach (var item in coisas)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < coisas.Count ; i++)
            {
                Console.WriteLine(coisas[i]);
            }
           

            

                Console.ReadKey();
        }
    }
}
