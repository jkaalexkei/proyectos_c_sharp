using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documentacionPOO_dos
{
    internal class Prueba
    {
        public int num1,num2;
        string nombre;
        public Prueba()
        {
            this.num1 = 0;
            this.num2 = 0;
        }

        public Prueba(string name)
        {
            this.num1 = 10;
            this.num2 = 20;
            this.nombre = name;

        }

        public void llamada()
        {
            Console.WriteLine($"num1:{this.num1} , num2:{this.num2} , nombre: {this.nombre}");
        }
    }
}
