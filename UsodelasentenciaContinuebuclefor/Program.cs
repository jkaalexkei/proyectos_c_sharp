using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsodelasentenciaContinuebuclefor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribe un programa que solicite al usuario ingresar un número entre 1 y20, luego imprima los números del 1 al 20, y en el lugar del número ingresado por el usuario, imprima la siguiente frase: Número omitido
             */
            int numero = 20;
            int valor;

            Console.WriteLine("Uso de la sentencia continue en bucle for");
            Console.Write("Ingrese un numero entre 1 y 20: ");
            valor = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero;i++)
            {
                
                if (i == valor)
                {
                    
                    Console.WriteLine("Numero Omitido");
                    continue;

                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine("Fin del programa");
            Console.ReadKey();

        }
    }
}
