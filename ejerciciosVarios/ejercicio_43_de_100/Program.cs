using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_43_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa que sume todos los elementos de un array de enteros

            int[] enteros = { 1,2,3,4,5,6,7,8};
            int suma = 0;

            for (int i = 0; i < enteros.Length;i++)
            {
                suma += enteros[i];//aqui sumamos los elementos
            }

            Console.WriteLine("La suma de elementos del array es: {0}",suma);

        }
    }
}
