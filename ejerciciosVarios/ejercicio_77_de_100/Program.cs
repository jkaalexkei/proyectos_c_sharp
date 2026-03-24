using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_77_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un metodo que lance una excepcion y manejala en otro lugar
            try
            {
                LanzarExcepcion();//aqui manejamos la excepción que viene del metodo
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void LanzarExcepcion()
        {
            int numero = 2;
            if (numero > 5)
            {
                throw new Exception("Lanzando excepcion desde el metodo, numero mayor a 5");//creamos la excepcion si el numero es mayor a 5
            }
            else
            {
                Console.WriteLine("Numero menor a 5");
            }
            

        }
    }
}
