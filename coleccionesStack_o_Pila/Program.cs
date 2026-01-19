using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coleccionesStack_o_Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Colecciones  Stack

            int opcion = 0;
            int numero = 0;
            bool encontrado = false;

            Stack miPila = new Stack();//inicializamos el Stack

            //se usa el bucle do while cuando al menos el programa se deba ejecutar una vez
            do
            {
                //menu de opciones
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
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
                    Console.WriteLine("Ingrese un valor: ");//agregar valor al stack
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-------");
                    //adicionamos valor al stack
                    miPila.Push(numero);//agrega al stack el valor ingresado por el usuario
                }
                else if (opcion == 2)
                {
                    //obtener elemento, saca el elemento del stack (remover o quitar del stack)
                    numero = (int)miPila.Pop();

                    //mostrar elemento obtenido
                    Console.WriteLine($"el numero removido es: {numero}");
                    
                }
                else if (opcion == 3)
                {
                    //limpiar todos los elementos del stack
                    miPila.Clear();
                    
                }
                else if (opcion == 4)
                {
                    //pedimos el valor a mostrar - consultar elemento
                    Console.WriteLine("Ingrese el numero a consultar:");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-------");
                    //validamos si el numero se encuentra en el stack
                    encontrado = miPila.Contains(numero);//recibe como parametro el numero a buscar y devuelve verdadero si lo encuentra de lo contrario retornara falso
                    Console.WriteLine("Encontrado {0}", encontrado);
                    
                }
                else if (opcion == 5)
                {

                    foreach (int item in miPila)//recorremos los elementos de la pila
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

                //mostrar información del stack
                Console.WriteLine($"El Stack tiene {miPila.Count} elemento");

            } while (opcion != 6);


            Console.ReadKey();
        }
    }
}

/*
 Colecciones: Stack o Pila

> permite guardar elementos y cambia su tamaño de forma dinámica, sin embargo trabaja en forma diferente al arreglo y al ArrayList

> estructura de tipo LIFO Lastin-first-out (El primero de entra, el ultimo que sale)(ultimo que entra, es el primero en salir)

> para colocar nuevos elementos en la parte superios del stack usamos el metodo Push();

        Stack.Push();

> para tomar un elemento de la parte superior del Stack usamos el método Pop();

        Stack.Pop();

       Antes
        4          elemento a tomar       despues 
        3                | 4 |                3
        2                                     2
        1                                     1

 > debido a este comportamiento con Push y Pop podemos entender cómo el primer objeto que se coloca adentro del Stack es el ultimo en poder salir

 > como crear el stack:
    la instanciación será la creación de un objeto de esta clase. Si deseamos crear un Stack hacemos lo siguiente:
            
                Stack miPila = new Stack();  --> se debe instanciar para poderlo usar
 
> Introducir información al stack usamos el método Push();

        miPila.Push(7);
        miPila.Push(11);
        miPila.Push(8);

        Queda de la siguiente Manera:
                    8
                    11 
                    7

> En este ejemplo se introduce primero el elemento 7 y luego sobre el se coloca el elemento 11. En seguida se coloca un nuevo elemento en la parte superior, que en este caso es 8.

> requiere un unico elemento, que es el que se va agregar al stack
> se puede usar el metodo Push() la cantidad de veces que sea necesario.

 > Para obtener la informacióndel stack:
    se debe usar el metodo Pop(). Toma el elemento que se encuentra en la parte superior del Stack. Este método no necesita ningún parámetro y regresa el elemento correspondiente

                ejemplo: 
                                int valor = 0;
                                valor = (int)miPila.Pop();

  > no se puede obtener un elemento de los primeros que entraron sin antes tomar el ultimo que entro al stack
  > el metodo Pop() no requiere que se le pase parametro ya que por defecto siempre va a tomar el ultimo que entro al stack
  > si le pasamos como parametro el primer elemento que entro al stack se va a producir un error

        Obtener la cantidad elementos que tiene el stack:
                se debe usar el metodo Count del stack. El uso es equivalente al del ArrayList.

                    Cantidad = miPila.Count;

        Para Eliminar contenido del Stack: Usar el Método Clear().

        Borra todos los elementos del Stack

        miPila.Clear(); ->no se necesita ningun parametro y solo se debe usar cuando se necesite limpiar todo el stack

> Para Saber si el stack tiene un elemento: Usar el método Contains()
> Este método necesita de un parametro que es el objeto a encontrar adentro del Stack.
> El metodo regresa un valor de tipo bool. Si el objeto se encuentra el valor es true, pero si no se encuentra es false.

    bool encontradoStack = false;
    encontradoStack = miPila.Contains(elemento a buscar);
        



 */