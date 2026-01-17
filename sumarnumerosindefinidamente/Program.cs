using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumarnumerosindefinidamente
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Crea un programa que le solicite al usuario que ingrese números repetidamente y sumará esos números hasta que el usuario decida detenerse.
                Reglas:

                1. Puedes usar variables decimales o enteras

                2. Realiza la validación de si o no mediante una petición con operadores relacionales
             */
            
            string opcion = "si";

            Console.WriteLine("Programa para sumar numeros hasta que se decida si o no continuar");
            do
            {
                Console.WriteLine("Programa para sumar 2 numeros");
                Console.Write("Ingrese primer numero: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese segundo numero: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int suma = n1 + n2;
                Console.WriteLine($"La suma de los numeros es: {suma}");
                Console.Write("Quieres volver a sumar dos numeros: ");
                opcion = Console.ReadLine();
               


            } while (opcion != "no");
            Console.WriteLine("Haz finalizado el programa");
            Console.ReadKey();

        }
    }
}
