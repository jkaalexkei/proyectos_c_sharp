using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUnoColeccionesArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio 1 ArrayList: Búsqueda de palabra
            Crea un programa que permita al usuario ingresar una palabra y luego busque si esa palabra se encuentra en un ArrayList predefinido con algunas palabras. Muestra un mensaje indicando si la palabra fue encontrada o no.



            Reglas:

            El programa debe mostrar la palabra ingresada por el usuario y también la lista de elementos en el array

            Para realizar el primer punto, debes utilizar un foreach

            Ejemplo de salida por pantalla
             
             
             */ 
             
            int cantidad;
            string palabra, palabraBuscar;
            bool encontrado = false;

            Console.WriteLine("Cantidad de palabras a registrar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            ArrayList listaPalabras = new ArrayList();

            Console.WriteLine("Ingrese las palabras a registrar");
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Palabra #{i + 1}: ");
                palabra = Console.ReadLine();
                listaPalabras.Add(palabra);
            }
            Console.WriteLine("Se registraron {0} palabras",listaPalabras.Count);

            Console.WriteLine("Ingrese la palabra a buscar");
            palabraBuscar = Console.ReadLine();

            foreach (string item in listaPalabras)
            {
                if (item == palabraBuscar)
                {
                    Console.WriteLine("La palabra existe en el ArrayList \n");
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                int valor = listaPalabras.IndexOf(palabraBuscar);
                Console.WriteLine($"Se encontro la palabra: {listaPalabras[valor]} \n");
                Console.WriteLine("Fin del programa");
                
            }
            else
            {
                Console.WriteLine("La palabra no existe");
            }
            Console.ReadKey();
        }
    }
}
