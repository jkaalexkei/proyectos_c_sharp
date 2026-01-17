using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumadenumerossegunlimite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que sume todos los números enteros (positivos) desde 1 hasta un número límite ingresado por el usuario.*/
            int numero,i=1,valor;
            int suma = 0;
            Console.WriteLine("Programa que suma numeros segun limite");
            Console.Write("Ingresa un número a sumar: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            while (i <= numero)
            {
                Console.WriteLine("Ingrese numero a sumar: ");
                valor = Convert.ToInt32(Console.ReadLine());
                suma += valor;
                i++;
            }
            Console.WriteLine($"La suma de los numeros ingresados es: {suma}");
            Console.ReadKey();

        }
    }
}
