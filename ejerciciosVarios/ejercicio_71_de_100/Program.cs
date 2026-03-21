using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_71_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //divide 2 numeros y maneja la excepcion por cero
            int n1, n2,res;
            try
            {
                n1 = 3;
                n2 = 0;
                res = n1 / n2;
                Console.WriteLine(res);
            }
            catch (DivideByZeroException ex) {
                Console.WriteLine("intento de dividir por cero");
            }
            //+++++++++++++++++++++++++++++
            Matematicas dividir = new Matematicas();
            dividir.Dividir(3, 0);
            dividir.Dividir(7, 9);
        }
    }
    class Matematicas 
    {
        public void Dividir(float a, float b)
        {
            try
            {
                float r = a / b;
                Console.WriteLine("{0:F2}",r);//esto imprime solo dos lugares decimales
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("no es posible la división por cero");
            }
        }
    }
}
