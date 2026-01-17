using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CuentaRegresivadenuNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que muestre un contador regresivo desde un número ingresado por el usuario hasta 1.*/

            int valor, i;
            Console.Write("Ingrese un numero entero para la cuenta regresiva: ");
            valor = Convert.ToInt32(Console.ReadLine());

            for (i = valor; i >= 1; i--)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
            Console.WriteLine("Fin del Programa");
            Console.ReadKey();
        }
    }
}


