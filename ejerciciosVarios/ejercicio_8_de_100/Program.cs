using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * escribe un programa que calcule la longitud de una cadena y muestre el resultado
             *
             */

            string cadena = "Hola Mundo";
            int longitud = cadena.Length;
            Console.WriteLine("La cadena tiene: {0} caracteres",longitud);
        }
    }
}
