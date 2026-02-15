using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int item in new int[] { 2, 9, 5, 6, 3, 4 })//otra forma de crear un array
            {
                numeros.AddFirst(item);//este metodo agrega los datos en el orden que aparece abajo, el primer registro se va ubicado de ultimo
                /*
                        4
                        3
                        6
                        5
                        9
                        2
                */

            }

            foreach (int item in numeros)//recorremos el linkedlist
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            for (LinkedListNode<int> nodo = numeros.First; nodo!=null;nodo = nodo.Next)//se crea un nuevo nodo y se le asigna el primer valor de la linkedlist, se va a ejecutar mientras el valor de nodo sea diferente de null, para incrementar el bucle a la variable nodo le asignamos el siguiente elemento de la linkedlist
            {
                int num = nodo.Value;//se crea una variable a la cual se le asigna el valor actual del nodo en el momento de la iteracion
                Console.WriteLine(num);//se muestra por pantalla
            }

            Console.WriteLine(numeros.);





        }
    }
}
