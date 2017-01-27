using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
             *Values Types
             *bool     Verdadeiromou falso(Valores boleanos)
             *byte     0 a 255(8 bits)
             *sbyte    -128 a 127(8 bits)
             *char     Um caractere(16 bits) entre aspas simples
             *decimal  ±1.0 x 10-28 a ±7.9 x 1028(128 bits) usado para calculos financeiros, inserir o sulfixo M ao valor
             *double   ±5.0 x 10-324 a 1.7 x 10308(64 bits)
             *float    ±1.5 x 10-45 a 3.4 x 1038(32 bits) inseriri o sulfixo F ao valor
             *int      -2,147,438,648 a 2,147,438,647(32 bits)
             *uint     0 a 4,294,967,295(32 bits)
             *long     -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807(64 bits)
             *ulong    0 a 18,446,744,073,709,551,615(64 bits)
             *object   Qualquer tipo
             *short    -32,768 a 32,767(16 bits)
             *ushort   0 a 65,535(16 bits)
             *string   Sequenca de caracteres(16 bits por caractere) até 1 GB
           */

            bool        boolValue = true;
            byte        byteValue = 15;
            sbyte       sbyteValue = 100;
            char        charValue = 'A';
            decimal     decimalValue = 10.50M;
            double      doubleValue = 10.50;
            float       floatValue = 10.50F;
            int         intValue = 1565789123;
            uint        uintValue = 456412387;
            long        longValue = -7654321987654;
            ulong       ulongValue = 10987654321987;
            object      objectValue = byteValue;
            short       shortValue = 10123;
            ushort      ushortValue = 60353;
            string      stringValue = "Hello World";
            
        }
    }
}
