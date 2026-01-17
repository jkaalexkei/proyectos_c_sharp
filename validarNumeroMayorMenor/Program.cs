using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validarNumeroMayorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declaracion de variables
            int numeroMayor, numeroMenor, cantidad;

            //capturamos cantidad de elementos de tendra el array
            Console.WriteLine("Ingrese el numero de elementos que tendra el array: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[cantidad];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ingrese el numero  {i+1}:  ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Numeros registrados");
            for (int a = 0; a < array.Length; a++)
            {

                Console.WriteLine("{0}",array[a]);
            }

            numeroMayor = array[0];
            numeroMenor = array[0];

            for (int b = 0; b < array.Length;b++)
            {
                if (array[b] > numeroMayor)
                {
                    numeroMayor = array[b];
                }
                if (array[b] < numeroMenor)
                {
                    numeroMenor = array[b];
                }
            }

            Console.WriteLine("El numero mayor es {0}", numeroMayor);
            Console.WriteLine("El numero menor es {0}", numeroMenor);
            
        }
    }
}
