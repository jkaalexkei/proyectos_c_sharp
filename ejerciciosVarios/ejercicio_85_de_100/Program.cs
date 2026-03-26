using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
 Escribe un programa para mover un archivo
 */
namespace ejercicio_85_de_100
{
    class Archivo
    {
        public void Mover(string origen, string destino)
        {
            File.Move(origen, destino);//con el uso del metodo Move de la clase File podemos mover un archivo entre una ruta de origen y destino
            Console.WriteLine("Archivo movido con exito");
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //las rutas deben mantener el nombre del archivo al final de la ruta
                string origen = @"C:\Users\JKAALEXKEI\source\repos\ejerciciosVarios\ejercicio_85_de_100\origen\prueba.txt";
                string destino = @"C:\Users\JKAALEXKEI\source\repos\ejerciciosVarios\ejercicio_85_de_100\destino\prueba.txt";
                Archivo archivo = new Archivo();
                archivo.Mover(origen, destino);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"ERROR DE EXCEPCION: {ex.Message}");
            }
        }
    }
}
