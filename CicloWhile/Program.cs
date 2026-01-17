using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ciclo While

            while(condicion){
            
                se valida mientras la condicion sea verdadera
            
                codigo a ejecutar
            }
             */

            //programa que permita enfriar un horno a 20 grados centigrados

            int temperatura;
            Console.WriteLine("Ingrese la temperatura actual");
            temperatura = Convert.ToInt32((Console.ReadLine()));
            while (temperatura > 20)
            {
                temperatura--;
                Console.WriteLine("La temperatura -> {0}",temperatura);
            }

            Console.WriteLine("La temperatura final {0}",temperatura);
            Console.ReadKey();
        }
    }
}
