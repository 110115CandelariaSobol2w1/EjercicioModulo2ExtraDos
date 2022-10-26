using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioModulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

          CandelariaList  lista = new CandelariaList();

            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Ingrese 1 para agregar un elemento al final de la lista");
                    Console.WriteLine("2. Ingrese 2 para agregar un elemento en una posicion determinada de la lista");
                    Console.WriteLine("3. Ingrese 3 para eliminar un elemento");
                    Console.WriteLine("4. Ingrese 4 para buscar un elemento en la lista");
                    Console.WriteLine("5. Ingrese 5 para obtener el elemento de la posicion indicada");
                    Console.WriteLine("6. Ingrese 6 para ordenar el array de mayor a menor");
                    Console.WriteLine("7. Ingrese 7 para salir de la aplicacion");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has elegido la opción 1");
                            lista.agregarElemento();
                            break;

                        case 2:
                            Console.WriteLine("Has elegido la opción 2");
                            lista.agregarElementoPosicion();
                            break;

                        case 3:
                            Console.WriteLine("Has elegido la opción 3");
                            lista.eliminarNumero();
                            break;

                        case 4:
                            Console.WriteLine("Has elegido la opción 4");
                            lista.buscarElemento();
                            break;

                        case 5:
                            Console.WriteLine("Has elegido la opción 5");
                            lista.buscarPosicion();
                            break;

                        case 6:
                            Console.WriteLine("has elegido ordenar el array de mayor a menor");
                            lista.ordenarMayor();
                            break;
                        case 7:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 7");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

           

        }
    


    }
}

