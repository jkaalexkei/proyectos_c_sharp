using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_28_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que use switch para determinar el tipo de fruta basado en una cadena

            Console.WriteLine("Ingrese un tipo de fruta: ");
            string fruta = Console.ReadLine();
            string tipo = "";

            switch (fruta)
            {
                case "papaya":
                    tipo = "Fruta dulce";
                    break;
                case "limon":
                    tipo = "Fruta acida";
                    break;
                default:
                    Console.WriteLine("valor no contemplado");
                    break;
            }

            Console.WriteLine(fruta + " | | " + tipo);
        }
    }
}
