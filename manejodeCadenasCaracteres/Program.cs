using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejodeCadenasCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\nWorld!"); //agrega un salto de linea \n
            Console.WriteLine("Hello\tWorld!");//agrega una tabulacion \t

            Console.WriteLine("Hello \"World\"!"); // el simbolo \ permite hacer una secuencia escape de caracteres.

            Console.WriteLine("c:\\source\\repos");// para mostrar una ruta no se puede utilizar una sola barra invertida, se deben usar dos para evitar un error de secuencia de escape no reconocida
            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.Write("\nOutput Directory:\t");
            Console.WriteLine();
            Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
            Console.Write(@"c:\invoices");
            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.Write("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");
            int result = 5 / 10;
            Console.WriteLine("Windows " + result);

        }
    }
}
