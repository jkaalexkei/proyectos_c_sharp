using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicioCadenasUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio Cadenas 1: Contador de Caracteres
                Crea un programa que ingrese una cadena de texto y el programa cuente el número de caracteres en esa cadena, incluyendo letras, números, espacios en blanco y signos de puntuación.

                Usa la función Length


             */

            string texto = "Hola mundo .2#  123";
            int cant = texto.Length;
            

            Console.WriteLine(cant);
            Console.ReadKey();



        }
    }
}
