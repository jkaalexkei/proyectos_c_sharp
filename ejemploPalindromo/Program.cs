using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPalindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string palabra;
            int longitudPalabra;

            Console.WriteLine("Ingrese la palabra a validar");
            palabra = Console.ReadLine().ToLower();//solicitamos una palabra

            longitudPalabra = palabra.Length;
            //creamos 2 arrays para almacenar la palabra ingresada y esa misma palabra de forma invertida
            string[] palindromo = new string[longitudPalabra];
            string[] textoInvertido = new string[longitudPalabra];

            for (int i = 0; i < longitudPalabra; i++)//recorremos la palabra ingresada y la agregamos al array
            {
                palindromo[i] = palabra[i].ToString();//agregamos cada letra en una posicion del array
                Console.Write(palindromo[i]);
            }
            Console.WriteLine();
            int indiceInvertido = 0;//creamos este indice para guardar las letras de forma invertida
            for (int j = longitudPalabra - 1; j >= 0; j--)
            {
                textoInvertido[indiceInvertido] = palabra[j].ToString();//almacenamos los caracteres de la palabra ingresada de forma invertida
                Console.Write(textoInvertido[indiceInvertido]);
                indiceInvertido++;
            }
            Console.WriteLine();

            bool esPalindromo = true;

            for (int p = 0; p < longitudPalabra; p++)//recorremos ambos arreglos y los comparamos
            {
                if (palindromo[p] != textoInvertido[p])//validamos si cada caracter en ambos arrays son iguales si consigue alguna diferencia se sale del bucle
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
