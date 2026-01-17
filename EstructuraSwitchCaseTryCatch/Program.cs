using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSwitchCaseTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese en letras un numero del 1 al 5");
            string num = Console.ReadLine();//capturamos le dato ingresado por el usuario

            try
            {
                //usa esta sentencia dentro de la estructura Try
                int numero = ConvertNumber(num);//aqui le pasamos al metodo ConvertNumber el dato ingresado por el usuario para que sea evaluado en dicho metodo
                Console.WriteLine($"el numero ingresado es: {numero}");//aqui escribimos lo que devuelve el metodo ConvertNumber

            }
            catch (Exception error)//capturamos el error
            {
                Console.WriteLine(error);//si se ingresa un dato que no esta contemplado en la solicitud aqui se muestra en pantalla
            }
        }

        //No borres este subprograma. Te permite realizar la conversión
        static int ConvertNumber(string numeroEnLetras)//metodo para convertir un numero en letras a numeros
        {

            //Escribe aqui la estructura Switch Case
            switch (numeroEnLetras)//evaluamos el  parametro el cual proviene del dato ingresado por el usuario
            {
                case "uno"://si el usuario ingresa uno en este caso
                    return 1; // se retorna el 1 respecto al numero en letras ingresado
                    break;
                case "dos":
                    return 2;
                    break;
                case "tres":
                    return 3;
                    break;
                case "cuatro":
                    return 4;
                    break;
                case "cinco":
                    return 5;
                    break;
                //Este default pertenece a la estructura Switch Case que escribas
                default:
                    throw new ArgumentException("Número en letras no reconocido.");//se crea una nueva excepción en caso que el numero sea diferente a los solicitados.
            }

            //Ten cuidado con los corchetes de apertura y cierre

        }


    }
}
