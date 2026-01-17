using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUnoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Ejercicio 1: Suma de números de una matriz (Unidimensional)

Crea un programa que solicite al usuario que ingrese valores en un array y luego calcule la suma de esos valores.
             
             
             */

            int cantidad, suma;

            int[] numeros;

            Console.WriteLine("Ingrese la cantidad de numeros a sumar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            numeros = new int[cantidad];
            suma = 0;
            Console.WriteLine("Ingrese los numeros a sumar: ");
            for (int num=0; num < cantidad;num++)
            {
                Console.Write("Numero {0}: ", (num + 1));
                numeros[num] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[num];
            }
            Console.WriteLine("Numeros registrados");
            for (int i = 0; i < numeros.Length;i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine($"La suma de los números es: {suma}");
            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}
