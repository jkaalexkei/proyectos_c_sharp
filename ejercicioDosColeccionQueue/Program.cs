using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDosColeccionQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio Queue 2: Orden de pedidos restaurante
                Crea un programa que realice el procesamiento de los pedidos de un restaurante.
                Agrega los pedidos y procesalos por orden de llegada y luego imprímelos.

                Usa este código para crear la cola

                Queue<string> colaPedidos = new Queue<string>();
             
             */
            string pedido;
            string tomarPedido;
            Queue<string> colaPedidos = new Queue<string>();
            Console.WriteLine("Orden de pedidos");
            int contador = 1;
            do {
                Console.WriteLine("Registrar pedido, ingrese si o no: ");
                pedido = Console.ReadLine();
                if (pedido == "si")
                {
                    Console.WriteLine($"ingrese pedido N° {contador}: ");
                    tomarPedido = Console.ReadLine();
                    colaPedidos.Enqueue(contador+"-"+ tomarPedido);//aqui se almacena el id del pedido concatenado al pedido para saber el orden el que van ingresando
                    contador++;
                }
                

            } while (pedido == "si");
            Console.WriteLine($"Se registraron {colaPedidos.Count} pedidos");
            
            foreach (string item in colaPedidos)//aqui recorremos los pedidos registrados
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Fin del programa");

        }
    }
}
