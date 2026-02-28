using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_29_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que use go to para saltar a una etiqueta

            Console.WriteLine("inicio del programa");
            goto salto;//instruccion para realizar saltos en el codigo
        
            Console.WriteLine("mensaje intermedio");

        salto://etiqueta para referenciar al salto con goto
            Console.WriteLine("aqui viene el salto");
        }
    }
}
