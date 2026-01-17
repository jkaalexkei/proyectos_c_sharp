using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioCincoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio 2 Bidimensional: Encontrar valor máximo de una matriz
                Crea un programa con una matriz con valores predeterminados que encuentre el valor máximo en ella.

                Reglas:

                Utiliza un for anidado

                Usa la propiedad GetLength

                Ejemplo de matriz:

                int[,] matriz = {

                {10, 20, 30},

                {40, 50, 60},

                {70, 80, 90}

                };
             
             */

            int[,] matriz = {//matriz bidimensional predefinida

                {10, 20, 30},

                {40, 50, 60},

                {70, 80, 90}

                };

            Console.WriteLine("buscar el valor maximo de un array bidimensional");

            int mayor = matriz[0, 0];//inicializamos una variable llamada mayor con el primer valor del array para ir comparando

            for (int i = 0; i < matriz.GetLength(0);i++) //recorremos las filas
            {
                for (int j = 0; j < matriz.GetLength(1);j++)//recorremos las columnas
                {
                    Console.WriteLine(matriz[i, j]);//imprimimos todos los elementos del array
                    if (matriz[i,j] > mayor)//validamos si el elemento del array es mayor al valor guardado en la variable mayor
                    {
                        mayor = matriz[i,j];//si se cumple la condición se reemplaza el valor por el numero mayor hasta que se complete el ciclo.
                    }
                }
            }

            Console.WriteLine("El número mayor es: {0}", mayor);//se muestra por pantalla el numero mayor obtenido

        }
    }
}
