using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * escribe un programa que convierta una cadena a mayusculas y muestre el resultado
             */

            string cadena;
            string cadenaMayusculas;

            Console.Write("Ingrese una frase corta: ");
            cadena = Console.ReadLine();
            cadenaMayusculas = cadena.ToUpper();//convertimos cadena a mayusculas
            Console.Write(cadenaMayusculas);
        }
    }
}
