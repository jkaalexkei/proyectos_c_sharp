using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace repasando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'm', 'n', 'l', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x','y','z'};

            string cadena = "Hola Mundo".ToLower();
            char[] nuevaCadena;
            int posicion = 0;
            nuevaCadena = new char[cadena.Length];
            foreach (char item in cadena)
            {
                if (char.IsLetter(item))
                {

                    int indice = Array.IndexOf(alfabeto, item);
                    if (indice >= 0)
                    {
                        int nuevoIndice = (indice + 2) % alfabeto.Length;
                        nuevaCadena[posicion] = alfabeto[nuevoIndice];
                        posicion++;
                    }
                    
                }
            }
            Console.WriteLine("Cdena original: {0}", cadena);
            Console.WriteLine("cadena encriptada: {0}",new string(nuevaCadena));
            

            //for (int i = cadena.Length - 1; i >= 0; i = i - 2)
            //{

            //}



            //contador de vocales
            //char[] vocales = {'a','e','i','o','u'};

            //string cadena = "Texto de prueba";

            //ArrayList misVocales = new ArrayList();
            //ArrayList misConsonantes = new ArrayList();

            //foreach (char letras in cadena)
            //{
            //    if (char.IsLetter(letras))//aqui se valida que sea una letra y que no sea un espacio en blanco
            //    {
            //        if (Array.IndexOf(vocales,letras) >= 0)//si lo que devuelve es mayor que 0 significa que existe en la cadena la vocal
            //        {
            //            misVocales.Add(letras);//si existe la vocal se guarda en la lista
            //        }
            //        else
            //        {
            //            misConsonantes.Add(letras);//si no hay coincidencia con vocales significa que se trata de una consonante y se guarda en la lista.
            //        }
            //    }
            //}

            //Console.WriteLine("Vocales encontradas en la cadena {0}",misVocales.Count);
            //Console.WriteLine("Consonantes Encontradas en la cadena {0}",misConsonantes.Count);
            //StreamReader archivo = null;//instacionamos un objeto para leer el archivo
            //try
            //{

            //    string ruta = @"C:\Users\JKAALEXKEI\source\repos\informacion.txt";//seleccionamos la ruta a validar
            //    archivo = new StreamReader(ruta);
            //    int contador = 0;
            //    string linea;
            //    while ((linea = archivo.ReadLine()) != null)//mientras haya lineas en el archivos
            //    {
            //        Console.WriteLine(linea);
            //        contador++;
            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Error con el archivo");
            //}
            //finally
            //{
            //    if(archivo != null) archivo.Close();
            //    Console.WriteLine("Conexión con el archivo cerrada");
            //}



            //checked
            //{
            //    int valor = int.MaxValue;
            //    int resu = valor + 20;
            //    Console.WriteLine(resu);
            //}
            //validar un numero aleatorio:
            //int valor = 0;
            //Random aleatorio = new Random();
            //valor = aleatorio.Next(0,100);
            //bool exito = false;
            //while (!exito)
            //{
            //    try
            //    {
            //        Console.WriteLine("Adivina el numero entre 0 y 100");
            //        int num = Int32.Parse(Console.ReadLine());
            //        if (num > valor)
            //        {
            //            Console.WriteLine("El numero es menor");
            //        }
            //        else if (num < valor)
            //        {
            //            Console.WriteLine("El numero es mayor");


            //        }
            //        else if (num == valor)
            //        {
            //            Console.WriteLine("Haz conseguido el numero");
            //            exito = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Numero invalido");
            //        }

            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine("Haz ingrado un dato invalido, intenta de nuevo", ex.Message);
            //    }
            //}
            //Console.WriteLine("Fin del programa");



            //calcular un factorial, el factorial es factorial de 5 es 5*4*3*2*1
            //int numero = 5;
            //int factorial = numero;
            //for (int i= numero - 1;i >= 1; i-- )
            //{
            //    factorial = factorial * i;
            //}
            //Console.WriteLine("El factorial del numero {0} es {1}",numero,factorial);
            //int[] numeros = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    switch (numeros[i])
            //    {
            //        case 3:
            //            Console.WriteLine("el numero {1} esta en la posicion {0}", i, numeros[i]);
            //            break;
            //        default:
            //            Console.WriteLine(numeros[i]);
            //            break;
            //    }
            //}

        }
    }
}
