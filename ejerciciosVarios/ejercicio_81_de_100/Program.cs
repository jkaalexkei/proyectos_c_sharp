using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ejercicio_81_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear y escribir en un archivo ruta: C:\Users\JKAALEXKEI\source\repos\ejerciciosVarios\ejercicio_81_de_100\archivos\
            string ruta = @"C:\\Users\\JKAALEXKEI\\source\\repos\\ejerciciosVarios\\ejercicio_81_de_100\\archivo\\archivo.txt";
        
            Archivo archivo = new Archivo();
            archivo.crear_escribir(ruta, "Hola Mundo como estas");


        }
    }

    class Archivo
    {
        public void crear_escribir(string ruta, string texto)
        {
            
            File.WriteAllText(ruta,texto);//objeto File y su metodo escribir para crear el archivo y texto dentro del archivo
   
            
            Console.WriteLine("Archivo y texto creado");
        }
    }
}
