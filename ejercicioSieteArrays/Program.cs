using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioSieteArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Ejercicio 2 Array Jagged: Suma de elementos en un array Jagged
                Crea un programa que calcule la suma de un array jagged
             
             */

            int columnas, suma,filas, subtotal;
            Console.WriteLine("Ingrese la cantidad de columnas que tendras");
            columnas = Convert.ToInt32(Console.ReadLine());//se almacena la cantidad de columnas

            int[][] jaggedValores = new int[columnas][];//se inicializa el array jagged con el numero de columnas

            for (int c = 0; c < columnas; c++)//se recorre las columnas para registrar la cantidad de filas por columnas
            {
                Console.Write("Ingrese la cantidad de filas para la columna {0}: ",c);
                filas = Convert.ToInt32(Console.ReadLine());//se cáptura la cantidad de filas
                jaggedValores[c] = new int[filas];//se inicializan las columnas con la cantidad de filas
            }

            Console.WriteLine("Registrar y sumar valores de las filas");
            suma = 0;//iniciamos la variable suma que guardara el resultado de la suma
            for (int c = 0; c < jaggedValores.Length; c++)//recorremos las columnas
            {
                Console.WriteLine("Ingrese valores fila {0}:", c);//iniciamos el registro de los valores en las filas por cada columna
                subtotal = 0;//iniciamos la variable subtotal que guardara el resultado de los elementos por fila
                for (int f = 0; f < jaggedValores[c].GetLength(0);f++)//recorremos las filas y sus valores
                {
                    Console.Write($"Valor {f}: ");
                    jaggedValores [c][f] = Convert.ToInt32(Console.ReadLine());//guardamos los valores en cada posicion de la fila
                    subtotal += jaggedValores[c][f];//asignamos y sumamos los valores registrados
                }
                Console.WriteLine($"Subtotal: {subtotal}");//escribimos el subtotal por columna
                suma += subtotal;//asignamos y sumamos los subtotales y los almacenamos en la variable suma
            }
            Console.WriteLine($"La suma de los numeros ingresados es: {suma}");//escribimos el resultado de la suma final
        }
    }
}
