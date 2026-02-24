using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace creacion_de_Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //creacion de archivos
            //Console.WriteLine("Ingrese una linea de texto para el archivo");
            //TextWriter archivoTexto; //declaramos un objeto, escribir texto
            //archivoTexto = new StreamWriter("C:\\Users\\JKAALEXKEI\\source\\repos\\informacion.txt");//permite crear el archivo en una ruta dada
            //string mensaje1 = Console.ReadLine();//leemos el dato ingresado por el usuario
            //archivoTexto.WriteLine(mensaje1);//le pasamos al archivo creado el mensaje escrito por el usuario
            //archivoTexto.Close();//cerramos el archivo para que se guarde
            //Console.Clear();//limpiamos la consola
            //Console.WriteLine("Archivo Guaradado correctamente");
            //Console.ReadKey();

            //lectura de archivos
            //TextReader leerArchivo;
            //leerArchivo = new StreamReader("C:\\Users\\JKAALEXKEI\\source\\repos\\informacion.txt");
            //Console.WriteLine(leerArchivo.ReadToEnd());//leemos el archivo de principio a fin (todo el archivo)
            //leerArchivo.Close();

            //modificar información del archivo
            StreamWriter archivo1 = File.AppendText("C:\\Users\\JKAALEXKEI\\source\\repos\\informacion.txt");//pasamos el archivo que se va a modificar
            string mensaje = Console.ReadLine();

            archivo1.WriteLine(mensaje);//se añade la información nueva
            archivo1.Close();
            Console.Clear();//limpiamos la consola
            Console.WriteLine("Archivo Guaradado correctamente");
            Console.ReadKey();

        }
    }
}
