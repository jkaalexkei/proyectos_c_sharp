using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDosEstructuras
{
    internal class Program
    {
        public struct Producto
        {
            public string Nombre;
            public decimal Precio;
            public int CantidadStock;


        }
        static void Main(string[] args)
        {

            /*
             Ejercicio de Gestión de Inventario simple
                Crea una estructura llamada Producto que contenga los siguientes campos:

                Nombre (cadena de texto)

                Precio (decimal)

                CantidadEnStock (entero)

                Luego, crea un arreglo de 5 productos, solicita al usuario que ingrese la información para cada uno y finalmente muestra el valor total del inventario (sumando Precio × CantidadEnStock de cada producto).
             */
            int cantidadProductos;
            Console.WriteLine("Ingrese la cantidad de productos a registrar");
            cantidadProductos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Registro inventario Ferreteria");
            Producto[] productos = new Producto[cantidadProductos];
            decimal precioTotal = 0;
            decimal totalPrecioInventario = 0;
            for (int i = 0; i < productos.Length;i++)
            {
                Console.WriteLine($"Ingrese los datos para el producto N°: {i+1}");
                Console.Write("Nombre: ");
                productos[i].Nombre = Console.ReadLine();
                Console.Write("Precio: ");
                productos[i].Precio = Convert.ToDecimal(Console.ReadLine());
                
                Console.Write("Stock: ");
                productos[i].CantidadStock = Convert.ToInt32(Console.ReadLine());
                precioTotal = productos[i].Precio * productos[i].CantidadStock;
                Console.WriteLine($"Precio Total: {precioTotal}");

            }

            Console.WriteLine("Productos Registrados");

            foreach (Producto item in productos)
            {
                Console.WriteLine($"Producto:{item.Nombre}| Precio:{item.Precio}| stock:{item.CantidadStock}| ");
                totalPrecioInventario += item.Precio;
            }
            Console.WriteLine($"El valor total del inventario es: {totalPrecioInventario}");





        }
    }
}
