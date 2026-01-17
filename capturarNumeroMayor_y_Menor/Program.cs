using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capturarNumeroMayor_y_Menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            float numeroMayor, numeroMenor, suma, promedio;
            float[] array;
            Console.Write("Ingrese los numeros a procesar ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            array = new float[cantidad];

            suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ingrese el numero {i + 1}: ");
                array[i] = Convert.ToSingle(Console.ReadLine());
                suma += array[i];

            }

            numeroMayor = array[0];
            numeroMenor = array[0];

            for (int a = 0; a < array.Length;a++)
            {
                if (array[a] > numeroMayor)
                {
                    numeroMayor = array[a];
                }

                if (array[a]<numeroMenor)
                {
                    numeroMenor = array[a];
                }
            }
            promedio = suma / cantidad;
           

            Console.WriteLine("El numero mayor es {0} y el numero menor es {1}",numeroMayor,numeroMenor);
            Console.WriteLine("La suma de los elementos del array es: {0} y el promedio es: {1}", suma, promedio);
        }
    }
}
