using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_76_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que utilice throw para relanzar una excepción
            try
            {
                LanzarError();//llamamos la funcion que relanza una excepción
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                
            }
        }

        static void LanzarError()
        {
            try
            {
                throw new Exception("Error detectado desde la funcion");
            }
            catch (Exception)
            {
                Console.WriteLine("Enviamos el error al main");
                throw;//relanzamos la excepcion a traves del llamado de nuevo mediante el uso de throw
            }
        }
    }
}
