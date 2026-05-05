using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////buscar un numero en un arreglo
            //int[] numero = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Ingresa un numero a buscar en el arreglo: ");
            //int buscar = int.Parse(Console.ReadLine());
            //bool encontrado = false;
            //foreach (int item in numero)
            //{
            //    if (buscar == item)
            //    {
            //        encontrado = true;
            //        break;
            //    }
            //}

            //if (encontrado)
            //{
            //    Console.WriteLine("existe");
            //}
            //else
            //{
            //    Console.WriteLine("No existe");
            //}
            ////forma 2 de buscar en el array
            //Console.WriteLine("Forma 2 usando Array.IndexOf()");
            //int indiceNumero = Array.IndexOf(numero, buscar);

            //if (indiceNumero >= 0)//se validar mayor e igual a cero para tome en consideración la posición 0 del array
            //{
            //    Console.WriteLine("Existe");
            //}
            //else
            //{
            //    Console.WriteLine("No existe");
            //}


            //invertir un cadena
            //Console.WriteLine("Ingresa una cadena invertir");
            //string cadena = Console.ReadLine();

            //for (int c = cadena.Length -1; c>=0;c--)
            //{
            //    Console.Write(cadena[c]);
            //}
            //Console.WriteLine("\nforma 2 de invertiir una cadena usando el metodo reverse");
            //string invertida = new string(cadena.Reverse().ToArray());
            //Console.WriteLine(invertida);

            //suma de numeros pares
            //Console.WriteLine("Ingresa la cantidad de numeros a validar: ");
            //int numeros = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int SumaPares = 0;
            //for (int i = 1; i<=numeros;i++)
            //{
            //    if (i % 2 ==0)
            //    {
            //        SumaPares = SumaPares + i;
            //        Console.Write(i + ",");
            //    }
            //}

            //Console.WriteLine($"\nLa suma de los numeros pares es: {SumaPares}");

            ////cuenta regresiva usando while
            //Console.WriteLine("Ingrese un numero");
            //int n = int.Parse(Console.ReadLine());
            //int contador = 1;
            //Console.WriteLine();
            //while (contador < n)
            //{
                
            //    Console.WriteLine(n-contador);
            //    contador++;
            //}
            //Console.WriteLine();
            ////correccion, forma correcta. 
            //while (n>=0)//mientras el numero ingresado sea mayor igual a 0
            //{
            //    Console.WriteLine(n);
            //    n--;//se decrementa el valor ingresado
            //}



            ////numeros pares del 1 al 50
            //for (int i = 0; i <=50;i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //serie fibonacci:La sucesión de Fibonacci es una serie infinita de números naturales donde cada término se obtiene sumando los dos anteriores, comenzando generalmente por 0 y 1 (0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...)

            //Console.WriteLine("Serie Fibonacci");
            //int cantidadValores = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            ////se inicalizan las variables a=0; b=1 por regla de la serie
            //int a = 0;
            //int b = 1;
            //for (int i=1;i<=cantidadValores;i++)
            //{
                
                
            //    //formula serie fibonacci
            //    int c = a + b;
            //    Console.WriteLine($"c = a ({a}) + b ({b}) resultado {a+b}");
            //    a = b;
            //    b = c;
            //    Console.WriteLine($"a={a}, b={b}");

            //}

            //contador de vocales
            //Console.WriteLine("contar vocales de una cadena");
            //Console.WriteLine("Ingresa una cadena: ");
            //string cadena = Console.ReadLine();
            //char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            //ArrayList vocalesEncontradas = new ArrayList();
            //foreach (char letra in cadena)
            //{
            //    if (char.IsLetter(letra))
            //    {
            //        if (Array.IndexOf(vocales, letra) >= 0)
            //        {
            //            vocalesEncontradas.Add(letra);
            //        }
            //    }
            //}

            //Console.WriteLine($"La cadena --{cadena}-- tiene {vocalesEncontradas.Count} vocales");

            //Tabla de multiplicar:
            //Console.WriteLine("Tabla de multiplicar");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("numero a evaluar {0}", n);
            //for (int i = 1; i <= 10 ;i++ )
            //{
            //    Console.WriteLine($"{i} x {n} = {i*n}");
            //}

            //Suma de numeros hasta N
            //Console.WriteLine("Ingrese la cantidad de numeros a sumar: ");
            //int numero = int.Parse(Console.ReadLine());

            //int contador = 1;
            //int suma = 0;
            //while(numero >= contador)
            //{
            //    Console.WriteLine(contador);
            //    suma += contador;
            //    contador++;
            //}

            //Console.WriteLine("La suma de los numeros es: {0}",suma);

            //recorrer numeros del 1 al 100
            //int[] valores = new int[101];
            //for (int i = 1; i <=100;i++)
            //{

            //    valores[i] = i;


            //}
            // Console.Write(string.Join(",", valores));
        }
    }
}
