using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;// usar la clase File y otras utilidades relacionadas con archivos y directorios.
namespace ejercicio_83_de_100
{
    class Archivo
    {
        public void Editar(string ruta, string texto)
        {
            File.AppendAllText(ruta, Environment.NewLine  + texto);//esto lo que hace es agregar contenido y una nueva linea o salto de linea en el archivo
            Console.WriteLine("Texto agregado");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //agregar texto a un archivo existente

            string ruta = @"C:\Users\JKAALEXKEI\source\repos\ejerciciosVarios\ejercicio_83_de_100\archivo\archivo.txt";

            Archivo archivo = new Archivo();
            archivo.Editar(ruta,"Este es el nuevo texto");
        }
    }
}
