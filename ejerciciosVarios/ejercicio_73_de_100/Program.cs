using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_73_de_100
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //escribe un programa que use finally para ejecutar codigo despues de un try-catch
            Archivo archivo = new Archivo();
            archivo.ProcesaArchivo(false);

           
        }
    }

    class Archivo
    {
        public void ProcesaArchivo(bool causaError)
        {
            Console.WriteLine("Abriendo Archivo...");
            try
            {
                if (causaError)
                {
                    throw new Exception("Error simulado");
                }
                Console.WriteLine("Procesando información ok");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion capturada: {0}",ex.Message);
                
            }
            finally
            {
                Console.WriteLine("Continuando con la ejecución del programa");
            }

        }
    }
}
