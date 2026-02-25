using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*escribe un programa que convierta una cadena a minusculas y muestre el resultado*/

            string cadena = "HOLA MUNDO";
            string cadenaMinusculas;
            Console.WriteLine(cadena);
            cadenaMinusculas = cadena.ToLower();
            Console.WriteLine(cadenaMinusculas);
        }
    }
}
