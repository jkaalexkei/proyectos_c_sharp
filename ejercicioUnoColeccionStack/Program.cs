using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUnoColeccionStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio Stack: Convertir número decimal a binario
            Crea un programa que realice la conversión de un número decimal ingresado por el usuario a binario utilizando un Stack.


            Reglas:

            Utiliza la declaración una variable int para la conversión a binarios. Recuerda que estos últimos son números enteros.

            Para cumplir la primera regla, puedes usar la siguiente sentencia al momento de declarar el Stack: Stack<int> stack = new Stack<int>();
             
             
             */

            int numero,resultado;
            int binario;//esta variable almacena el numero a validar
            Console.WriteLine("Ingrese el numero que desea convertir a Binario: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");
            Stack listaBinario = new Stack();//inicializamos el stack
            binario = numero;//guardamos el numero ingresado por el usuario
            while (binario > 0)//ejecutamos el bucle while mientras binario sea mayor que cero
            {
                resultado = binario % 2;//almacenamos el resultado de binario modulo 2
                listaBinario.Push(resultado);//agregamos el valor de resultado al stack
                Console.WriteLine($"{binario} / {2} = {binario = binario / 2}");//mostramos por pantalla el proceso de la division y actualizamos el valor de binario diviendolo entre 2
                
            }
            Console.WriteLine("----------");
            foreach (int item in listaBinario)//listamos los valores del stack segun van ingresando
            {
                Console.WriteLine(item);//mostramos los valores
            }
            Console.WriteLine("----------");
            Console.Write($"El número binario de {numero} es: ");//mostramos el numero binario del numero ingresado por el usuario
            foreach (int item in listaBinario)//recorremos el stack para mostrar el numero binario
            {
                Console.Write(item);
            }
            Console.WriteLine("\nCantidad de elementos {0} en el stack", listaBinario.Count);
            Console.WriteLine("\n----usando Metodo Pop()------");//aqui tambien extraemos los valores del stack con la diferencia que se borran los valores del stack
            while (listaBinario.Count > 0)
            {
                Console.Write(listaBinario.Pop());
            }


            Console.WriteLine("\nFin del Programa");
            Console.WriteLine("Cantidad de elementos {0} en el stack",listaBinario.Count);
            Console.ReadKey();




        }
    }
}
