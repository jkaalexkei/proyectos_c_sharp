using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//se utiliza para usar el metodo que permite hacer un retardo en la ejecución del codigo
using System.Threading.Tasks;

namespace calculoFactorialUsandoMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio 2: Calcular factorial
                Crea un programa que calcule el factorial de un número ingresado por el usuario utilizando un método. El programa debe solicitar un número entero no negativo al usuario y mostrar el factorial correspondiente.

                Reglas:

                El método secundario debe ser de tipo long

                El método secundario debe declarar una variable de tipo int en los atributos

                Recuerda:  Factorial es multiplicar todos los números enteros positivos que hay entre el número propuesto (en este caso el ingresado por el usuario) y el 1
             
             */

            Console.WriteLine("Programa para calcular el factorial de un numero");
            int numero = solicitarNumero();//almacenamos lo que retorna la funcion en la variable numero
            Console.WriteLine("Calulando");
            for (int a = 0; a <= numero;a++ )//genera una barra de progreso para esperar y mostrar resultados.
            {
                Thread.Sleep(500);//hace un retardo de 5ms por cada ejecución
                Console.Write(".");
                if(a == numero)//cuando el contador y el numero son iguales hace un salto de linea
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine($"factorial = {calculoFactorial(numero):N0}");//aca mostramos el factorial calculado en formato de miles
            Console.ReadKey();

        }

        static int solicitarNumero()//solicitamos y validamos el numero ingresado
        {
            int numero = 0;
            bool estado = true;//esta variable se usa para comprar si el numero ingresado es positivo o negativo
            //este ciclo se va a ejecutar mientras la variable estado sea verdadera
            do
            {
               
               Console.Write("Ingrese el numero a calcular: ");//aca se solicita el numero para calcular el factorial
               numero = Convert.ToInt32(Console.ReadLine());
               if(numero >= 0)// si el numero es mayor o igual a cero la variable estado la cambiamos a falso ya que indica que se trata de un numero positivo y de esta manera se sale del bucle
                {
                    estado = false;
                    
                }
                else
                {
                    Console.WriteLine("Solo permite numeros positivos");
                }
                

            } while (estado);

            return numero;

        }

        static long calculoFactorial(int numero)//con este metodo calculamos 
        {
            long factorial = 1;
            for (int i = numero; i >= 1; i--)
            {
                //Console.WriteLine(i);
                factorial *= i;

            }

            return factorial;//retornamos el factorial calculado
        }
      


    }
}
