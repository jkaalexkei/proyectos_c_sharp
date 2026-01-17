using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioNueveArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio 1 Array como parámetros a métodos: Suma de elementos
                Crea un programa que contenga un método que acepta un array de enteros como parámetro y calcula la suma de todos sus elementos.

                Reglas:

                Utliza un foreach para hacer el recorrido en el array y dentro de él realiza la opración
             */

            int cantidad,resultado;
            int[] valores;
            Console.WriteLine("Registre la cantidad de valores a procesar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            valores = new int[cantidad];

            Console.WriteLine("Ingrese los numeros que se van a sumar");
            for (int n = 0; n < valores.Length; n++)
            {
                Console.Write($"Numero {n + 1}: ");
                valores[n] = Convert.ToInt32(Console.ReadLine());
            }

            resultado = sumaValores(valores);

            Console.WriteLine($"El resultado de la suma es: {resultado}");


        }

        static int sumaValores(int[] valores)
        {
            Console.WriteLine("Los números registrados son: ");
            int suma = 0;
            int indice = 0;
            foreach (int item in valores)
            {
                Console.WriteLine($"numero {indice + 1} = {item}  ");
                indice++;
                suma += item;
            }


            return suma;
        }
    }
}
