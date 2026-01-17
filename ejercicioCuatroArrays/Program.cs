using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioCuatroArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Ejercicio 1 Bidimensional: Suma de elementos de una matriz
            Crea un programa que calcule la suma de de los números de una matriz predefinidos e imprima el resultado en pantalla.



            Reglas:

            Ejemplo de matriz: 

            int[,] matriz = {
                        {1, 2, 3},
                        {4, 5, 6},
                        {7, 8, 9}
                    };
            Utiliza la propiedad GetLength para obtener la longitud de una array
             
             */

            int[,] matriz = {//matriz predefinida
                        {1, 2, 3},
                        {4, 5, 6},
                        {7, 8, 9}
                    };

            Console.WriteLine("Suma de numeros de la matriz predefinida");
            int suma = 0;//la iniciamos por fuera del primer bucle para que tome todos los valores del array
            for (int i =0; i < matriz.GetLength(0);i++)//aqui recorremos las filas
            {
                ;
                for (int k = 0; k < matriz.GetLength(1);k++) //aqui recorremos las columnas                   
                {
                    suma += matriz[i,k];//aqui validamos los valores y los asignamos a la variable suma
                }
                
            }
            Console.WriteLine($"La suma de los numeros es: {suma}");





        }
    }
}
