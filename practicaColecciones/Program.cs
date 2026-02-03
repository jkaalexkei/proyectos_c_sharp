using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaColecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            int[] numeros = new int[] { 20,30 };

            Console.WriteLine("se agregaron los numeros del array");
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                lista.Add(numeros[i]);//agregamos los elementos elementos a la lista
                Console.WriteLine($"Agregado el numero {numeros[i]} a la lista");
                suma += lista[i];//asignamos y sumamos los elementos de la lista
            }
            Console.WriteLine("La suma de los numeros es: {0}", suma);

            //int cantidad = 0;
            //Console.WriteLine("Ingrese la cantidad de elementos a registrar: ");
            //cantidad = Int32.Parse(Console.ReadLine());

            //for (int i = 0; i < cantidad;i++)
            //{
            //    Console.WriteLine("Elemento {0}", (i+1));
            //    lista.Add(Int32.Parse(Console.ReadLine()));
            //}

            //Console.WriteLine("Se registraron los siguientes elementos");

            //lista.RemoveAt(lista.Count - 1);//removemos el ultimo elemento agregado

            //for (int j = 0; j < lista.Count; j++)
            //{
            //    Console.WriteLine(lista[j]);
            //}

        }
    }
}
