using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
 Escribe un programa para copiar un archivo
 */
namespace ejercicio_84_de_100
{
    class Archivo
    {
        public void Copiar(string origen, string destino)
        {
            File.Copy(origen, destino, true);//usamos el metodo Copy de la clase File indicando ruta origen y destino y el parametro true para que se incie la copia del archivo.
            Console.WriteLine("Archivo Copiado");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string rutaOrigen = "C:\\Users\\JKAALEXKEI\\source\\repos\\ejerciciosVarios\\ejercicio_84_de_100\\origen\\pruebaCopia.cs";
                string rutaDestino = "C:\\Users\\JKAALEXKEI\\source\\repos\\ejerciciosVarios\\ejercicio_84_de_100\\destino\\pruebaCopia.cs";
                Archivo archivo = new Archivo();
                archivo.Copiar(rutaOrigen, rutaDestino);
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR DE EXCEPCION: {0}",ex.Message);
            }
        }
    }
}
