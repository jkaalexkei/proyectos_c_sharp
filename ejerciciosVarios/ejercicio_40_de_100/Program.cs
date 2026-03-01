using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_40_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             escribe un programa que no permita salir sin confirmación
             */

            //este programa tambien se puede hacer con un bucle while
            bool confirmacion = true;
            do
            {
                Console.WriteLine("programa en ejecución");
                int op = 0;
                Console.WriteLine("desea salir: 1 - si, 0 - no");
                op = Convert.ToInt32(Console.ReadLine());
                if(op == 1)
                {
                    confirmacion = false;
                }

            }while (confirmacion);
            Console.WriteLine("saliste del programa");

            //este programa tambien se puede hacer con un bucle while
            bool permiso = false;
            while (!permiso)
            {
                Console.WriteLine("Desea salir, presione S o N");
                string op = Console.ReadLine().ToUpper();
                if (op == "S")
                {
                    Console.WriteLine("Saliste");
                    permiso = true;
                }
            }
        }
    }
}
