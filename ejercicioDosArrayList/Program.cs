using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDosArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Ejercicio 2 ArrasList: Ordenar elementos
                Crea un programa que ordene los elementos de un array de menor a mayor y los imprima por pantalla
                
            Reglas:
                Los elementos deben ser de tipo entero
                utiliza la sentencia: Sort() para ordenar los elementos. Ejemplo: myList.Sort();
                Usa bucles foreach
                Ejemplo de salida por pantalla
                                
             */

            int cantidad, numeros;
            Console.WriteLine("Ingrese la cantidad de numeros a registrar");
            cantidad = Convert.ToInt32(Console.ReadLine());

            ArrayList valores = new ArrayList();    
            Console.WriteLine("Registre los valores que desea agregar");
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el numero {i+1}: ");
                numeros = Convert.ToInt32(Console.ReadLine());
                valores.Add(numeros);
            }
            Console.WriteLine("Articulos Registrados");
            foreach (int val in valores)
            {
                Console.WriteLine($"{val}");
            }
            Console.WriteLine("Articulos Registrados y Ordenados");
            valores.Sort();//ordenamos el arraylist
            foreach (int val in valores)
            {
                Console.WriteLine($"{val}");
            }
            Console.WriteLine($"Se registraron {valores.Count} numeros");
            
            foreach (int val in valores)
            {
                Console.WriteLine($"{val}");
            }
            







        }
    }
}
