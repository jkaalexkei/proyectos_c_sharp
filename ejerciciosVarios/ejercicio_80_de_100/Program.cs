using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_80_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que maneje excepciones dentro de un bucle

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };

            foreach (int item in numeros)
            {
                try
                {
                    if (item % 2 != 0)
                    {
                        throw new Exception("Numero Impar");//lanzamos una excepción por cada numero impar
                    }
                    else
                    {
                        Console.WriteLine("Numero Par");
                    }

                }
                catch (Exception ex) //capturamos excepcion
                {
                    Console.WriteLine("EXCEPCION CONTROLADA: {0}",ex.Message);//mostramos la excepción
                }

            }
            Console.WriteLine("SEGUNDA FORMA");
            //int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < numeros.Length;i++)
            {
                try
                {
                    Console.WriteLine(numeros[8]);//simulamos un indice que no existe para forzar la salida de la excepcion
                }
                catch (IndexOutOfRangeException ex)//capturamos excepcion predefinida indice fuera de rango
                {

                    Console.WriteLine("EXCEPCION CONTROLADA: {0}",ex.Message);
                }
            }

        }
    }
}
