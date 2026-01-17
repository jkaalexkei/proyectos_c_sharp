using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validacionElementosArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            string[] articulos;//almacenar articulos
            float[] precios;//almacenar precios

            //registrar articulos
            Console.WriteLine("Cuantos articulos quiere agregar a la máquina:");
            cantidad = Convert.ToInt32(Console.ReadLine());
            articulos = new string[cantidad];//establecemos la longitud del array
            precios = new float[cantidad];
            Console.WriteLine("Escribe el nombre de los articulos");
            for (int a = 0; a < cantidad; a++)//recorremos dependiendo de los elementos ingresado por el usuario para luego agregar al array los items
            {
                Console.Write($"Articulo {a + 1}: ");
                articulos[a] = Console.ReadLine();//agregamos items al array
                Console.Write($"Precio: ");
                precios[a] = Convert.ToSingle(Console.ReadLine());//agregamos items al array
            }
            Console.WriteLine("Se registraron {0} articulos: son los siguientes:", articulos.Length);
            for (int ar = 0; ar < articulos.Length; ar++)//recorremos los articulos registrados
            {
                Console.WriteLine($"{ar + 1} {articulos[ar]}");
            }
            bool validacion = true;//para la validacion del bucle do while
            int dato;
            int numeroProducto;
            int contador = 3;
            do
            {
                Console.Write("Que compra desea hacer, ingrese el numero del articulo deseado: ");
                dato = Convert.ToInt32(Console.ReadLine());//capturmaos el elemento deseado por el usuario
                numeroProducto = dato - 1;

                if (numeroProducto >= 0 && numeroProducto < articulos.Length)//validamos que el numero del articulo registrado exista en el array articulos
                {
                    Console.WriteLine($"Producto seleccionado: {articulos[numeroProducto]} debes pagar ${precios[numeroProducto]} pesos");
                    validacion = false;
                }
                else
                {
                    //validamos los intentos erroneos en el ingreso del numero del articulo
                    Console.WriteLine($"No hay articulo por ese numero, te quedan {--contador} intentos \n");
                    
                    if(contador < 1)
                    {
                        Console.WriteLine("\n\tAlcanzaste el limite maximo de 3 intentos");
                        validacion = false;
                    }
                }
                
                
                

            } while (validacion);
            Console.WriteLine("Fin del programa");
        }
    }
}
