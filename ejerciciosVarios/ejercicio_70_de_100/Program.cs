using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_70_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crea una clase cuenta con:
            un atributo privado saldo
            un metodo depositar(decimal cantidad)
            que suma al saldo si la cantidad es positiva
            un metodo consultarSaldo() que devuelve el saldo

             */

            Cuenta miCuenta = new Cuenta(1200);
            miCuenta.Depositar(123.40m);
            Console.WriteLine($"Saldo actualizado: { miCuenta.ConsultarSaldo()}");
        }
    }
    class Cuenta
    {
        private decimal _saldo;

        public Cuenta(decimal saldo)
        {
            this._saldo = saldo;
        }

        public void Depositar(decimal cantidad)
        {
            Console.WriteLine($"Saldo actual: {this._saldo}");
            Console.WriteLine($"Monto a depositar: {cantidad}");
            if (cantidad > 0)
            {
                _saldo += cantidad;
                Console.WriteLine("deposito exitoso");
               

            }
            else
            {
                Console.WriteLine("Cantidad invalida");
            }
        }

        public decimal ConsultarSaldo()
        {
            return _saldo;
        }
    }
}
