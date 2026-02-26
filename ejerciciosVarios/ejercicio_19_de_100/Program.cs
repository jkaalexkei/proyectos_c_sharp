using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_19_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;//Esto permite mostrar correctamente los caracteres Unicode.
            /*declara una variable de tipo DateTime y asignale la fecha y hora actual*/
            DateTime miFecha = DateTime.Now;//variable de tipo fecha
            Console.WriteLine(miFecha);
        }
    }
}
