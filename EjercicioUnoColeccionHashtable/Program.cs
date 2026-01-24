using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnoColeccionHashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Ejercicio Hashtable 1: Contador de Palabras Únicas
                Implementa un programa en C# que tome una cadena de texto como entrada y cuente la frecuencia de cada palabra única en el texto utilizando una Hashtable. Luego, el programa debe imprimir cada palabra única junto con su frecuencia.

                Ejemplo:

                Si escribes "Hola Mundo" la salida por pantalla será así:

                Palabras únicas y sus frecuencias:
                Hola: 1
                Mundo: 1
                Pistas:

                Utiliza un foreach para que el programa recorra las palabras
             
             */

            string miCadena = "Hola mundo como estas estas mi mundo Hola Hola Hola como como como como";
            miCadena = miCadena.ToLower();
            string[] cadena = miCadena.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);//aqui separamos la cadena original usando el metodo split(' ') y cada palabra se almacena en el array cadena
            Hashtable contadorPalabras = new Hashtable();
            
            foreach (string item in cadena)//aqui recorremos cada palabra dentro del array cadena
            {

                if (contadorPalabras.ContainsKey(item))//esto retorna true o false dependiendo si la palabra existe o no
                {
                    contadorPalabras[item] = (int)contadorPalabras[item] + 1;//si la palabra ya existe, recibimos un numero entero que corresponde a la primera aparacion y le sumamos 1 para ir incrementando dependiendo de la cantidad de veces que aparece esa palabra en la cadena
                                                                                //Resumen:
                                                                             // Si la palabra ya existe:
                                                                             // - Obtenemos el valor actual (int)
                                                                             // - Le sumamos 1
                                                                             // - Actualizamos la frecuencia

                }
                else//caso contrario que la palabra no este repetida
                {
                    contadorPalabras.Add(item,1);//agregamos un nuevo registro al hashtable, // Palabra nueva: se inicializa su contador en 1

                }


            }
            Console.WriteLine($"Relación de palabras y sus frecuencias en la cadena completa: \n\n\t-{miCadena}-\n");//escribimos la cadena original a manera de información
            foreach (DictionaryEntry item in contadorPalabras)//recorremos el hashtable para verificar  la cantidad de palabras y sus apareciones en la cadena
            {
                Console.WriteLine($"key: {item.Key}- value: {item.Value}");
            }






        }
    }
}
