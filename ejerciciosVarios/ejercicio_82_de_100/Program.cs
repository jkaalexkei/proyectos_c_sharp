using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ejercicio_82_de_100
{
    class Archivo
    {
        public void leer(string ruta)//metodo para procesar la lectura del contenido de un archivo
        {
            if (File.Exists(ruta))//aqui validamos si el archivo existe
            {
                string contenido = File.ReadAllText(ruta);//aqui leemos el contenido del archivo
                Console.WriteLine(contenido);//imprimimos el contenido del archivo.txt
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa para leer un archivo
            string ruta = @"C:\Users\JKAALEXKEI\source\repos\ejerciciosVarios\ejercicio_82_de_100\archivo\archivo.txt";
            Archivo archivo = new Archivo();
            archivo.leer(ruta);//llamamos al metodo leer de la clase archivo
        }
    }
}
