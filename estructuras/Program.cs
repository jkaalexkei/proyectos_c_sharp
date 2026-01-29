using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int longitudPalabra;

            Console.WriteLine("Ingrese la palabra a validar");
            palabra = Console.ReadLine().ToLower();

            longitudPalabra = palabra.Length;

            string[] palindromo = new string[longitudPalabra];
            string[] textoInvertido = new string[longitudPalabra];
            
            for (int i = 0; i < longitudPalabra; i++)
            {
                palindromo[i] = palabra[i].ToString();
                Console.Write(palindromo[i]);
            }
            Console.WriteLine();
            int indiceInvertido = 0;
            for (int j = longitudPalabra - 1; j >=0; j--)
            {
                textoInvertido[indiceInvertido] = palabra[j].ToString();
                Console.Write(textoInvertido[indiceInvertido]);
                indiceInvertido++;
            }
            Console.WriteLine();

            bool esPalindromo = true;

            for (int p = 0; p < longitudPalabra; p++)
            {
                if (palindromo[p] != textoInvertido[p])
                {
                    esPalindromo = false;
                    break;
                }
            }

            if (esPalindromo)
            {
                Console.WriteLine("La palabra es palindromo");
            }
            else
            {
                Console.WriteLine("La palabra no es palindromo");
            }
            

            




        }
    }
}

/*
 Estructuras: se componen de muchos arreglos, se puede administrar mejor el orden

Las estructuras son tipos definidos por el programador y son un conjunto de datos agrupados. funcionan como un array o parecido a las colecciones

permiten flexibilidad al almacenar datos

Cuando creamos una estructura, definimos un nuevo tipo y adentro de este tipo podremos colocar datos. Estos datos se conocen como campos

cada campo esta representado por una variable, que puede ser de cualquier tipo

Luego que hemos terminado de definir la estructura podemos crear variables de esta estructura y guardar la información que necesitamos en ellas

se puede manejar como un arreglo pero ahi que tener presente los datos que se deben almacenar

ejemplo:
Agenda telefonica:
    nombre: string
    direccion: string
    telefono: string
    edad: int

Definir una estructura:

para definir una estructura debemos usar 3 pasos:

1. el acceso: indica si la estructura puede verse por fuera del ámbito


























 */
