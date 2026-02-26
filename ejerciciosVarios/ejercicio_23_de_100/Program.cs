using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_23_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que clasifique un numero como positivo, negativo o cero

            int numero = Convert.ToInt32(Console.ReadLine());

            //aqui se utilizo una validacion con operador ternario anidado
            string comprobacion = (numero > 0) ? "Positivo" :
                                   (numero < 0) ? "Negativo" : "Es Cero";

            Console.WriteLine(comprobacion);
        }
    }
}
