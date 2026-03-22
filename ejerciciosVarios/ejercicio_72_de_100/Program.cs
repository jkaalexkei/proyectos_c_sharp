using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_72_de_100
{
    class Convertir
    {
        public void Calcular(string numText)
        {
            try
            {
                int numConvertido= int.Parse(numText);
                Console.WriteLine("numero {0} convertido",numConvertido);

            }
            catch (FormatException)
            {

                Console.WriteLine("Numero {0} Invalido",numText);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //convierte texto a numero y maneja la excepcion

            Convertir convertir = new Convertir();
            convertir.Calcular("2");
            convertir.Calcular("z");
        }

    }
}
