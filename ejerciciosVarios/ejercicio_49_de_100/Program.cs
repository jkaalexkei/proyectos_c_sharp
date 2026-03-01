using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_49_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //buscar un elemento en una lista de enteros

            List<int> listEnteros = new List<int> {10,50,45,23};
            List<string> listUsuarios = new List<string> {
                                                            "user1",
                                                            "user2",
                                                            "user3",
                                                            "user4",
                                                            "user4",
                                                            "user5",
                                                            "user6",
            
                                                            };

            Console.WriteLine("Ingrese el numero a buscar");
            int numeroFind = Int32.Parse(Console.ReadLine());

            Console.WriteLine("buscamos un solo elemento, usamos list.Find");
            int resultadoBuscarUnElemento = listEnteros.Find(resultado => resultado == numeroFind);//buscamos un elemento

            if (resultadoBuscarUnElemento != 0)//si es diferente de cero(valor por defecto) encontro un dato
            {
                Console.WriteLine("Se encontro el elemento {0}", resultadoBuscarUnElemento);
            }
            Console.WriteLine();
            Console.WriteLine("Buscamos varios elementos list.findAll");
            Console.WriteLine("Ingrese el usuario a buscar");
            string userBuscar = Console.ReadLine();//ingresamos usuario a buscar
            List<string> resulVariosElementosEnList = listUsuarios.FindAll(resultadoVarios => resultadoVarios == userBuscar);//buscamos varios elementos y los alamcenamos en una nueva lista de usuarios encontrados

            Console.WriteLine($"se encontraron {resulVariosElementosEnList.Count} usuarios con el mismo nombre");
            foreach (string user in resulVariosElementosEnList)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("fin");
        }
    }
}
