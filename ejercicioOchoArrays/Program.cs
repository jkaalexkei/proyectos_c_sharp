using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioOchoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio 1 Array Jagged como parámetros a métodos: Suma de elementos
                Crea un programa que contenga un método que acepta un array jagged de enteros como parámetro y calcula la suma de todos sus elementos.

                Reglas:

                Utliza un foreach para hacer el recorrido en el array y dentro de él realiza la opración
             */
            int columnas,filas;
            int[][] jaggedNumeros;
            Console.WriteLine("Ingresa la cantidad de columnas que tendra el array");
            columnas = Convert.ToInt32(Console.ReadLine());

            jaggedNumeros = new int[columnas][];

            Console.WriteLine("Ingrese el numero de filas para cada columna");
            for (int c = 0; c < jaggedNumeros.Length;c++)
            {
                Console.Write($"Columna {c} filas:  ");
                filas = Convert.ToInt32(Console.ReadLine());
                jaggedNumeros[c] = new int[filas];
            }

            Console.WriteLine("Registro de valores en las filas:");
            for (int c = 0; c < jaggedNumeros.Length;c++)
            {
                Console.Write($"columna {c}, ");
                for (int f = 0; f < jaggedNumeros[c].Length;f++)
                {
                    Console.Write($"\n\t fila {f}: ");
                    jaggedNumeros[c][f] = Convert.ToInt32(Console.ReadLine());
                }
            }



            int resultado = sumaNumeros(jaggedNumeros);
            Console.WriteLine($"La suma de los elementos es: {resultado}");

        }

        static int sumaNumeros(int[][] jaggedNumeros)
        {
            Console.WriteLine("Procesando suma desde la funcion");
            int suma = 0;
            //aca agregamos un doble bucle foreach para recorrer columnas y filas del arrayjagged
            foreach (int[] item in jaggedNumeros)//recorremos filas
            {
                foreach (int valores in item)//recorremos valores de las filas
                {
                    Console.WriteLine(valores);
                    suma += valores;//asignamos y sumamos los valores
                }

            }
            return suma;


        }

    }
}
