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
            int cantidad;//variable para cantidad de registros
            int posicionEncontrado;//para almacenar lo que devuelve la funcion buscarDato
            string nombreBuscar;//variable para guardar la cadena a buscar
            string[] nombres;//array para almacenar nombres
            Console.WriteLine("Ingrese la cantidad de nombres que tendra el array: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            nombres = new string[cantidad];//inicializamos el array

            Console.WriteLine("Registre los nombres");
            for (int n = 0; n < nombres.Length;n++)//recorremos el array para almacenar los valores
            {
                Console.Write($"nombre {n + 1}: ");
                nombres[n] = Console.ReadLine();
            }
            
            Console.WriteLine("Ingrese el nombre a buscar: ");
            nombreBuscar = Console.ReadLine();//ingresamos el nombre a buscar en el array

            posicionEncontrado = buscarDato(nombres,nombreBuscar);//capturamos lo que devuelve la función 

            if (posicionEncontrado != -1)//validamos que el valor en caso que sea diferente de -1 el registro existe
            {
                Console.WriteLine($"El nombre {nombres[posicionEncontrado]} esta en la posición {posicionEncontrado}");
            }
            else
            {
                Console.WriteLine("El registro No existe");
            }
            

        }

        static int buscarDato(string[] nombres,string nombreBuscar)//funcion para buscar en el array nombre ingresado por el usuario
        {
               

            int posicion = Array.IndexOf(nombres, nombreBuscar);//capturamos el indice o posición en el arreglo del elemento buscado

            if (posicion >= 0)//si el valor devuelvo es mayor o igual a cero el registro existe y retornamos la posicion, caso contrario retornamos -1 si el registro no existe en el array
            {
                return posicion;//si existe el registro
            }
            else
            {
                return -1; //no existe el registro
            }
                    
            
        
        }

    }
}
