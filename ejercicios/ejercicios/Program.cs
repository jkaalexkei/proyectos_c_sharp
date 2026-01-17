using System;

namespace ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIOS VARIOS*/
            //Ejercicio estructura if 3: Validación de contraseña:
            //Crea un programa que solicite ingresar una contraseña, valide si es igual a la enunciada y emita un mensaje por pantalla si permite o no el acceso.

            //Reglas:
            //Indicar al inicio del programa que la contraseña sea "secreto123" mediante una impresión por pantalla
            //Usar la estructura selectiva if y operadores relacionales
            //Emite los siguientes mensajes por pantalla:
            //*Si es correcta la contraseña: ¡Contraseña correcta!Acceso concedido."
            //* Si no es correcta la contraseña: Contraseña incorrecta. Acceso denegado.

            //string clave = "secreto123", validarclave;

            //Console.WriteLine("Inicio del sistema, ingrese la clave de acceso:");
            //validarclave = Console.ReadLine();

            //if (validarclave == clave)
            //{
            //    Console.WriteLine("¡Contraseña correcta!Acceso concedido.");
            //    Console.WriteLine("Bienvenido al sistema");
            //}
            //else
            //{
            //    Console.WriteLine("Contraseña incorrecta. Acceso denegado.");
            //}

            //Console.WriteLine("Fin de la ejecución");
            //Console.ReadKey();










            //***************************************************
            //Ejercicio estructura if 2: Número positivo o negativo
            //Escribe un programa que solicite ingresar un número e indique si es positivo o negativo.

            //int numero;
            //Console.WriteLine("Prog para validar si un número es positivo o negativo");
            //numero = Convert.ToInt32(Console.ReadLine());

            //if (numero < 0)
            //{
            //    Console.WriteLine("El numero es negativo");
            //}
            //else
            //{
            //    Console.WriteLine("El numero es positivo");
            //}



            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //EJERCICIO PARA CALCULAR SI ERES MAYOR DE EDAD
            //Crea un programa que pregunte la edad y verifique si es mayor de edad(+18) o no de acuerdo a la estructura if y los operadores relacionales.
            //int edad;
            //Console.WriteLine("Vamos a validar si eres mayor de edad:");
            //edad = Convert.ToInt32(Console.ReadLine());

            //if (edad >= 18)
            //{
            //    Console.WriteLine("Eres mayor de edad: ");
            //}
            //else
            //{
            //    Console.WriteLine("No eres mayor de edad");

            //}

            //Console.WriteLine("Fin de la ejecución");
            //Console.ReadKey();



            //+************************************************************************

            //Centígrados a Kelvin y Fahrenheit
            //La escala Celsius es centígrada, 100 divisiones separan el punto de congelación del punto de ebullición del agua. En la escala Fahrenheit de los anglosajones, estos dos puntos están separados por 180 grados.La escala de Kelvin es una escala absoluta utilizada en ciencias.

            //    Cree un programa en C# para convertir de grados centígrados a Kelvin y Fahrenheit. Solicite al usuario la cantidad de grados centígrados para convertirlos usando las siguientes tablas de conversión:

            //    kelvin = celsius + 273
            //    fahrenheit = celsius x 18 / 10 + 32

            //Console.WriteLine("CONVERTIR DE GRADOS CENTIGRADOS A GRADOS KELVIN Y FAHRENHEIT");
            //double kelvin, fahrenheit, celsius;
            //Console.WriteLine("Ingrese la cant de grados centigrados a convertir");

            //celsius = Convert.ToDouble(Console.ReadLine());

            ////calculos   
            ////Fórmula
            ////(38 °C × 9 / 5) + 32 = 100,4 °F

            //kelvin = celsius + 273;
            //fahrenheit = celsius * 9/5 + 32;

            //Console.WriteLine("El resultado de la conversión es: Kelvin {0} y fahrenhei {1:F2}",kelvin, fahrenheit);
            //Console.ReadKey();

            //Escriba un programa en C# que solicite al usuario tres letras y los muestre al revés.

            //Console.WriteLine("Ingrese 3 letras aleatorias segun se le solicite");
            //string l1, l2, l3;
            //Console.WriteLine("Ingrese letra 1");
            //l1 = Console.ReadLine();

            //Console.WriteLine("Ingrese Letra 2");
            //l2 = Console.ReadLine();

            //Console.WriteLine("Ingrese Letra 3");
            //l3 = Console.ReadLine();

            //Console.WriteLine("orden de las letras {0} {1}, {2}",l3,l2,l1);
            //Console.ReadKey();


            //*********************************************************************

            //Este ejercicio valida si la división es exacta muestra el resultado sin decimales de lo contrario muestra el resultado con decimales
            //double a=8,b=2;
            //double d;
            //d = a / b;
            //if (a % b == 0)
            //{
            //    Console.WriteLine("La division da una division exacta");
            //    Console.WriteLine("{0}", d); //exacta
            //}
            //else
            //{
            //    Console.WriteLine("La división da un resultado decimal");
            //    Console.WriteLine("{0:F2}", d); //salida con decimales
            //}



            // Console.WriteLine("{0:F2}", d); //salida 0,67

            //*********************************************************************
            //CALCULAR LAS OPERACIONES DE + - * / % de 2 numeros ingresados por el usuario
            //int n1, n2, suma, resta, multiplicacion,resto;
            //double division = 0;

            //Console.WriteLine("Calculo de operaciones matematicas +,-,*./.% de 2 numeros");

            //Console.WriteLine("Ingrese numero 1: ");
            //n1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese numero 2: ");
            //n2 = Convert.ToInt32(Console.ReadLine());

            //suma = n1 + n2;
            //resta = n1 - n2;
            //multiplicacion = n1 * n2;

            //if (n1 == 0 | n2 == 0){
            //    Console.WriteLine("No se puede dividir entre 0");
            //} else {
            //    division = n1 / n2;

            //}

            //resto = n1 % n2;

            //Console.WriteLine("Los resultados de las operaciones son: ");
            //Console.WriteLine("Suma: {0}",suma);
            //Console.WriteLine("resta: {0}", resta);
            //Console.WriteLine("multiplicación: {0}", multiplicacion);
            //Console.WriteLine("division: {0}", division);
            //Console.WriteLine("resto: {0}", resto);



            //CALCULO DE DIMENSIONES DE ESFERA
            //crear un programa para calcular la superficie y volumen de una esfera dado su radio

            //double radio, superficie, volumen, PI;
            //PI = Math.PI;
            //Console.WriteLine("Ingrese el radio: ");
            //radio = Convert.ToDouble(Console.ReadLine());

            ////superficie
            //superficie = Math.Round((4 * PI * Math.Pow(radio, 2)), 2);
            //Console.WriteLine("La superficie es {0}", superficie);

            ////volumen
            //volumen = (Math.Round((4 / 3) * PI * Math.Pow(radio, 3), 2));
            //Console.WriteLine("El volumen es {0}", volumen);
            //Console.ReadKey();


        }
    }
}
