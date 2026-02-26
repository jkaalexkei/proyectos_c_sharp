using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_22_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que verifique si un numero es par o impar
            int numero = Convert.ToInt32(Console.ReadLine());
            string comprobacion = (numero % 2 == 0) ? "Par" : "Impar";

            Console.WriteLine(comprobacion);
        }
    }
}
