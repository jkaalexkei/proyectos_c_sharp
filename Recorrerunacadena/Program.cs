using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recorrerunacadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que recorra una cadena de texto (Hola, mundo!) e imprima cada carácter en la cadena.*/
            string cadena;
            cadena = "Hola Mundo!";

            foreach (char c in cadena)
            {
                //Console.WriteLine(c);
                Console.Write(" {0} ", c);
            }
            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}
