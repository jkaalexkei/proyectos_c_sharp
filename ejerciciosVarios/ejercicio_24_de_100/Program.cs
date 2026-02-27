using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_24_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //usar el operador ternario para determinar si un numero es par o impar

            //operador ternario: es una forma compacta de escribir una condicion

            int numero = 7;

            string validacion = (numero % 2 == 0) ? "Es Par" : "Es Impar";

            Console.WriteLine(validacion);
           
            
            
           
        }
    }
}
