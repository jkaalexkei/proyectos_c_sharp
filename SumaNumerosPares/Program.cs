using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Crea un programa que calcule la suma de todos los números pares entre 1 y un número entero ingresado por el usuario
             */

            int numero,suma=0,entero;

            Console.Write("Ingrese un numero para suma: ");
            entero = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ingresa cantidad de numeros a procesar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1;i<=numero;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} Es Par",i);
                    Console.WriteLine($"{i} + {suma} = {suma + i}");
                    suma += i;

                }
                else
                {
                    Console.WriteLine("{0} Es Impar", i);
                }
            }
            entero = entero + suma;
            Console.WriteLine("La suma es de los numeros pares es {0} mas el numero entero ingresado es = {1}", suma,entero);

            Console.WriteLine("Fin del programa");

            Console.ReadKey();
        }
        /*
         12
        12 % 1
        12 % 2
        12 % 3
         */
    }
}


/*
 
6 |_2___
 0   3

*/
