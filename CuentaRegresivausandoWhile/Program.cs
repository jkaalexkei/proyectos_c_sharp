using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaRegresivausandoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que muestre un contador regresivo desde un número ingresado por el usuario hasta 1.
             se debe usar el bucle  while
             */
            int contador;
            Console.WriteLine("Ingrese un numero para la cuenta regresiva");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            while (numero >= 1)
            {
                Console.WriteLine(numero);
                numero--;
            }
            Console.WriteLine("Fin del programa");
            Console.ReadKey();

        }
    }
}
