using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coleccionQueue_Cola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Colección Queue
        

            int opcion = 0;
            int numero = 0;
            bool encontrado = false;

            Queue miFila = new Queue();//inicializamos el Queue

            //se usa el bucle do while cuando al menos el programa se deba ejecutar una vez
            do
            {
                //menu de opciones
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Contains");
                Console.WriteLine("5. Listar");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Escoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------");
                //verificar opcion ingresada por el usuario
                if (opcion == 1)//si usuario ingreso 1
                {
                    Console.WriteLine("Ingrese un valor: ");//agregar valor al Queue
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-------");
                    //adicionamos valor al Queue
                    miFila.Enqueue(numero);//agrega al Queue el valor ingresado por el usuario
                }
                else if (opcion == 2)
                {
                    //obtener elemento, saca el elemento del Queue (remover o quitar del Queue)
                    numero = (int)miFila.Dequeue();

                    //mostrar elemento obtenido
                    Console.WriteLine($"el numero removido es: {numero}");

                }
                else if (opcion == 3)
                {
                    //limpiar todos los elementos del Queue
                    miFila.Clear();

                }
                else if (opcion == 4)
                {
                    //pedimos el valor a mostrar - consultar elemento
                    Console.WriteLine("Ingrese el numero a consultar:");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-------");
                    //validamos si el numero se encuentra en el Queue
                    encontrado = miFila.Contains(numero);//recibe como parametro el numero a buscar y devuelve verdadero si lo encuentra de lo contrario retornara falso
                    Console.WriteLine("Encontrado {0}", encontrado);

                }
                else if (opcion == 5)
                {

                    foreach (int item in miFila)//recorremos los elementos de la pila
                    {
                        Console.WriteLine($"{item}");
                    }
                }
                else if (opcion == 6)
                {

                    Console.WriteLine("Fin del Programa");
                    break;
                }
                else
                {
                    Console.WriteLine("Opcion no contemplada en el Menú");
                }

                //mostrar información del Queue
                Console.WriteLine($"El Queue tiene {miFila.Count} elemento");

            } while (opcion != 6);


            Console.ReadKey();




        }
    }
}

/*

Colecciones: Queue o Cola

Permite guardar elementos y cambia su tamaño de forma dinámica.

la forma como trabaja es diferente al Queue, ya que el Queue es una estructura de tipo FIFO (First In First Out) Primero en entrar - primero en salir

esto nos indica que cuando insertamos elementos en el Queue, estos se colocan atras del ultimo elemento insertado o en la parte posterior de este. Al momento de Leer elementos, se toma el que se encuentre en la parte superior del Queue

ejemplo de funcionamiento

antes       elemento a insertar                 elemento a retirar          despues         
|1|               |5|                 |1|               |1|                   |2|
|2|                                   |2|                                     |3|
|3|                                   |3|                                     |4|
|4|                                   |4|                                     |5|
                                      |5|

El proceso por medio del cual nosotros insertamos un elemento nuevo al Queue se conoce como Enqueue y no debemos olvidar que lo hace al final. El acto de extraer un elemento del Queue se llama Dequeue y siempre toma el elemento que se encuentra en la parte superior.

los elementos se insertan al final
para extraer un elemento siempre se hace al primer elemento

Declaracion del Queue

si deseamos crear un Queue llamado fila, haremos lo siguiente:

    Queue fila = new Queue();

Adicionar elementos:
    se debe utilizar el metodo Enqueue(), el cual pertenece a la clase Queue de C#, requiere de un parametro. En el parametro colocamos el elemento que deseamos añadir, este metodo no regresa ningun valor

        fila.Enqueue(7);--> de esta forma agregamos un valor al Queue y no retorna ningun valor

Extraer un elemento del Queue:

Se debe usar el metodo Dequeue(). El método no necesita de ningún parámetro y regresa el elemento correspondiente. Es importante tener una variable que reciba el elemento o una expresión que haga uso de él.

        ejemplo:
                    int valor = 0;
                    valor = fila.Dequeue();--> retorna el primer elemento del Queue

no requiere parametro ya que por defecto retira el primer elemento ingresado
una vez lo extraiga lo elimina del Queue


Observar un elemento del Queue:

Usar el método Peek(). Este método nos va a permitir observar el elemento sin eliminarlo. Este método no necesita de ningún parámetro y regresa el elemento observado. Al igual que con Dequeue() debe de existir una variable o una expresión que reciba este valor.

ejemplo.

            int valor = 0;
            valor = fila.Peek(); --> esta declaracion recibe el valor devuelto del metodo Peek(); el elemento consultado

Peek() no requiere un parametro

Como saber si el Queue contiene un elemento:

Se debe usar el metodo Contains(); este metodo retorna true o false dependiendo si el dato existe o no en el Queue

para usar este metodo, necesitamos pasar como parametro el elemento que queremos determinar.

el metodo regresara un valor de tipo bool. Si el elemento existe adentro del Queue, el valor retornado sera true. En el caso de que el elemento no exista en el interior del Queue el valor regresado será false.

necesitamos tener una variable o una expresión que reciba el valor del metodo Contains().

        ejemplo:
                        if(miFila.Contains(7) == true){
                                    
                                Console.WriteLine("El elemento si existe");
                
                            }


Para Borrar los contenidos del Queue:

Se debe usar el metodo Clear(). No necesita de ningun parametro

miFila.Clear();

para conocer la cantidad de elementos que tiene el Queue:

se debe usar el metodo Count(). Corresponde a un valor de tipo entero

        int cantidad = 0;
        cantidad = miFila.Count; --> retorna la cantidad de elementos del Queue





 */
