using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace arreglosEjercicioNumeroMayorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad,mayor,menor,numero;
           
            Console.WriteLine("Ingrese la cantidad de numeros a comprobar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[cantidad];//establecemos la cantidad de elementos del array
            
            for (int i = 0; i < array.Length; i++)//recorremos el array para agregar los elementos ingresados por el usuario
            {
                Console.WriteLine($"Ingrese numero {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());//asignamos al array lo que el usuario ingrese
            }
            //inicializamos las variables mayor y menor con el primer valor del array
            mayor = array[0];
            menor = array[0];
            for (int n = 0; n < array.Length; n++)//recorremos el array para comparar los valores y determinar el numero mayor y menor
            {
                if (array[n] > mayor)//validamos si el elemento del array es mayor a lo que tiene la variable mayor
                {
                    mayor = array[n];
                }

                if (array[n] < menor)//validamos si el elemento del array es menor a lo que tiene la variable menor
                {
                    menor = array[n];
                }

            }
            //mostramos los valores
            Console.WriteLine($"El numero mayor del listado es: {mayor}");
            Console.WriteLine($"El numero menor del listado es: {menor}");





            Console.ReadKey();
        }
    }
}
