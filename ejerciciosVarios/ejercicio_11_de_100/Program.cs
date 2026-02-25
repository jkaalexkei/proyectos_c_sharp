using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_11_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*pedir al usuario un string por teclado e imprime el resultado*/
            String cadena;
            Console.WriteLine("Ingresa una frase");
            cadena = Console.ReadLine();

            Console.WriteLine("La cadena ingresada es: {0}",cadena);
        }
    }
}
