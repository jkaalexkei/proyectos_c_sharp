using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_44_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //busca un elemento en un array de enteros

            int[] enteros = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Ingresa el elemento a buscar: ");
            int elementoBuscar = Convert.ToInt32(Console.ReadLine());
            int posicion = Array.IndexOf(enteros, elementoBuscar);//usando la clase Array y su metodo indexOf buscamos el elemento, esto retorna -1 sino lo encuentra, recibe como parametros el array y el elemento a buscar

            if (posicion != -1)
            {
                Console.WriteLine("el elemento existe en la posicion {0}", posicion);
            }
            else
            {
                Console.WriteLine("el elemento no existe");
            }

            
            //for (int i = 0; i < enteros.Length;i++)
            //{
            //    if (elementoBuscar == enteros[i])
            //    {
            //        Console.WriteLine("Elemento encontrado en la posicion {0}",i);
            //        break;
            //    }
                
               
            //}

            //foreach (int item in enteros)
            //{
            //    if (elementoBuscar == item)
            //    {
            //        Console.WriteLine("encontrado");
            //    }
            //    else
            //    {
            //        Console.WriteLine("no encontrado");
            //    }
            //}


        }
    }
}
