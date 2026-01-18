using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDiezArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio 2 Array como parámetros a métodos: Búsqueda de un elemento
                Crea un programa con un método que acepte un array de cadenas y una cadena a buscar. El método debe verificar si la cadena buscada se encuentra en el array.

                Ejemplo:

                {"Daniel", "Carlos"} ;
                string nombreBuscar = "Carlos";


                Reglas

                Crea un método adicional que se encargue de buscar el elemento, este es el que deberá llevar los parámetros
             
             */
            int cantidad;
            int posicionEncontrado;
            string nombreBuscar;
            string[] nombres;
            Console.WriteLine("Ingrese la cantidad de nombres que tendra el array: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            nombres = new string[cantidad];

            Console.WriteLine("Registre los nombres");
            for (int n = 0; n < nombres.Length;n++)
            {
                Console.Write($"nombre {n + 1}: ");
                nombres[n] = Console.ReadLine();
            }
            
            Console.WriteLine("Ingrese el nombre a buscar: ");
            nombreBuscar = Console.ReadLine();

            posicionEncontrado = buscarDato(nombres,nombreBuscar);

            if (posicionEncontrado != -1)
            {
                Console.WriteLine($"El nombre {nombres[posicionEncontrado]} esta en la posición {posicionEncontrado}");
            }
            else
            {
                Console.WriteLine("El registro No existe");
            }
            

        }

        static int buscarDato(string[] nombres,string nombreBuscar)
        {
               

            int posicion = Array.IndexOf(nombres, nombreBuscar);

            if (posicion >= 0)
            {
                return posicion;
            }
            else
            {
                return -1;
            }
                    
            
        
        }

    }
}
