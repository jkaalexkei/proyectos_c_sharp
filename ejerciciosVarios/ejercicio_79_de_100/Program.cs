using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_79_de_100
{
    class Producto
    {
        private decimal _precio;
        public decimal Precio
        {

            get { return _precio; }
            set
            {
                if (value < 0)//validamos el valor de la propiedad
                {
                    throw new Exception("El precio no puede ser negativo");//CREAMOS LA EXCEPCION DENTRO DE LA PROPIEDAD
                }
                _precio = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                //escribir un propiedad que lance una excepción si se asigna un valor inválido
                try
                {
                    Producto p = new Producto();
                    Console.WriteLine("Ingrese un precio");
                    p.Precio = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Precio: {0}", p.Precio);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("ERROR DE EXCEPCION: {0} ",ex.Message);
                }

        }
    }
}
