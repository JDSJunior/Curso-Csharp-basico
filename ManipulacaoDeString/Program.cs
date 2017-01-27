using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoDeString
{
    class Program
    {
        static void Main(string[] args)
        {

            //meio mais comun de manipular strings
            string S1 = "one,two,three";
            string S2 = "one";

            //concatenação de string
            S2 += ",two";
            S2 += ",three";

            //retorna true se ouver dados com o final descrito
            bool meio = S2.EndsWith("ee");

            //compara se for igual a outro objeto;
            S2.Equals("");

            //insere os elementos no indice descrito
            S2.Insert(4 , "OK");

            //remove o numero de elementos descritos a partir de um indice
            S2.Remove(4, 3);

            //troca os valores onde foi descrito
            S2.Replace("two" , "one");

            //tranforma a string em um array delimitando os elementos por um char
            string[] S3 = S2.Split(',');

            //retorna o index da primeira ocorrencia do elemento na string
            Console.WriteLine(S2.IndexOf("r"));

            //meio mais robusto de manipular strings com metodos mais variaveis
            System.Text.StringBuilder SB = new StringBuilder();
            SB.Append("one");
            SB.Append(",two");
            SB.Append(",three");

            //retorna o index da primeira ocorrencia do elemento descrito
            SB.ToString().IndexOf("t");
            

            Console.WriteLine(S1);
            Console.WriteLine(S2);
            Console.WriteLine(SB);
            Console.WriteLine(meio);

            Console.ReadKey();

        }
    }
}
