using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploMaquinadeBendi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string [] articulos;
            int cantArticulos;
            
            
            Console.WriteLine("Cantidad articulos a registrar en la maquina de bendi");
            cantArticulos = Convert.ToInt32(Console.ReadLine());
            articulos = new string[cantArticulos];
            Console.WriteLine("Ingrese los articulos: ");
            for (int a = 0; a < articulos.Length;a++)
            {
                articulos[a] = Console.ReadLine();
            }
            Console.WriteLine($"Se registraron {articulos.Length} articulos en la maquina");
            tomarPedido(articulos);
             
        }

        static void tomarPedido(string[] articulos)
        {
            int numeroPedido;
            Console.WriteLine("Que articulo desea comprar, Marque un número de listado: ");
            for (int art = 0;art < articulos.Length;art++)
            {
                Console.WriteLine($"{art + 1 } para {articulos[art]}");

            }
            Console.Write("Aqui: ");
            numeroPedido = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < articulos.Length;i++)
            {
                if (articulos.indexOf())
                {

                }
            }








        }

    }
}
