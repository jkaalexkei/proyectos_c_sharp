using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioTabladeMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que muestre la tabla de multiplicar de un número ingresado por el usuario*/

            int i, valor;

            Console.WriteLine("Programa para calcular la table de multiplicar");
            Console.Write("Ingrese valor de la tabla de multiplicar a calcular: ");
            valor = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {valor} = {i * valor}");
            }
            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}
