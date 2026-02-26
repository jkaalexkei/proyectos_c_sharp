using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_18_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que tome una letra minuscula como entrada, avance 3 posiciones en el alfabeto y muestre la nueva letra
            Console.WriteLine("Ingrese una letra");
            //leemos la letra ingresada
            char letra = Console.ReadKey().KeyChar;//se usa para leer un solo caracter en la entrada
            //a la letra ingresada le sumamos 3 posiciones y que retorne la nueva letra
            char nuevaLetra = (char)(letra+3);//creamos una nueva variable que almacenara la nueva letra, para esto aplicamos un casteo o conversion de tipo de la (letra + 3) (que son las posiciones) y me de la nueva letra
            Console.WriteLine();
            Console.WriteLine("nueva letra: " + nuevaLetra);

        }
    }
}
