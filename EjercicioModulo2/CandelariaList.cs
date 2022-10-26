using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioModulo2
{
    internal class CandelariaList
    {

        public int[] candelariaList = { 10, 15, 12, 0, 0 };

        int capacidad = 5;         // Capacidad maxima del array
        int cantidad = 3;          // Número real de numeros guardados
        int i;

        public CandelariaList()
        {
        }


        public void agregarElemento()
        {
            int numero;
           

            Console.WriteLine("Ingrese el numero que desea ingresar"); //pedimos al usuario que agregue un numero
            numero = Convert.ToInt32(Console.ReadLine());              //Almacenamos le numero en la variable numero
            Console.WriteLine("Añadiendo el numero {0} al final", numero); //mensaje con el numero que se va a agregar
            if (cantidad < capacidad)                                       //Verificamos si el array tiene lugar para el numero nuevo
            {
                
                candelariaList[cantidad] = numero;
                cantidad++;
                capacidad = candelariaList.Length;
            }
            else if (candelariaList.Length == cantidad)
            {
                Array.Resize(ref this.candelariaList, this.candelariaList.Length * 2);

                candelariaList[cantidad] = numero;
                cantidad++;
                capacidad = candelariaList.Length * 2;


            }

            foreach (int value in candelariaList)
            {
                Console.WriteLine(value);
            }

            //     // Y volvemos a mostrar el array
            //    for (i = 0; i < cantidad; i++)
            //    Console.Write("{0} ", candelariaList[i]);
            //    Console.WriteLine();
            //
        }


        public void agregarElementoPosicion()
        {
            int numero;
            int posicionInsertar;

            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", candelariaList[i]);
            Console.WriteLine();

            Console.WriteLine("Ingrese el numero que desea ingresar"); 
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese en que posicion lo quiere ingresar");
            posicionInsertar = (Convert.ToInt32(Console.ReadLine()) - 1);
            

            if (cantidad < capacidad)
            {
                Console.WriteLine("Añadiendo el numero {0} en la posicion {1}", numero, posicionInsertar + 1);
                for (i = cantidad; i > posicionInsertar; i--) // los que queden atras tienen que moverse a la derecha  para dejarle hueco
                    candelariaList[i] = candelariaList[i - 1];
                //candelariaList[posicionInsertar - 1] = numero;
                candelariaList[posicionInsertar] = numero;
                cantidad++;
                capacidad = candelariaList.Length;
            }

            else if (candelariaList.Length == cantidad)
            {
                Array.Resize(ref this.candelariaList, this.candelariaList.Length * 2);

                candelariaList[cantidad] = numero;
                cantidad++;
                capacidad = candelariaList.Length * 2;


            }

            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", candelariaList[i]);
            Console.WriteLine();
        }


        public void eliminarNumero()
        {
            int i;
            int posicionEliminar;

            //mostramos el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", candelariaList[i]);
            Console.WriteLine();

            Console.WriteLine("Ingrese la posicion del numero que desea eliminar");
            posicionEliminar = (Convert.ToInt32(Console.ReadLine()) - 1 ); //como el array comienza en 0 le restamos 1

            // Borramos el numero
            Console.WriteLine("Borrando el {0} numero", posicionEliminar);
            for (i = posicionEliminar; i < cantidad; i++) //para eliminar un numero los que estaban a continuacion tienen que moversea la izquierda para que no quede un lugar vacio
                candelariaList[i] = candelariaList[i + 1];
            cantidad--;

            //if(candelariaList.Length > cantidad)
            //{
            //    Array.Resize(ref this.candelariaList, this.candelariaList.Length / 2);
            //}

            // Y volvemos a mostrar el array
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", candelariaList[i]);
            Console.WriteLine();
        }


        public void buscarElemento()
        {
            int i;
            int numero;

            //mostramos el array para acordarnos de los datos
            for (i = 0; i < cantidad; i++)
            Console.Write("{0} ", candelariaList[i]);
            Console.WriteLine();

            Console.WriteLine("Ingrese el numero que desea buscar");
            numero = Convert.ToInt32(Console.ReadLine());

            // Buscamos el numero ingresado
            for (i = 0; i < cantidad; i++)
            {
                if (candelariaList[i] == numero)
                    Console.WriteLine("{0} encontrado en la posición {1} ", numero, i + 1);
            }
            //Error con el mensaje del numero no se encuentra

            if (candelariaList[i] != numero)
            {
                Console.Write("El numero ingresado no se encuentra");
            }

        }

        public void buscarPosicion()
        {
           
            int posicion;
            
            

            Console.WriteLine("Ingrese en que posicion desea saber que numero se encuentra");
            posicion = (Convert.ToInt32(Console.ReadLine()) -1 );

            Console.WriteLine("En la posicion {0} se encuentra el numero " + candelariaList.GetValue(posicion) , posicion + 1);


        }

        public void ordenarMayor()
        {
            
            //mostramos el array para acordarnos de los datos
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", candelariaList[i]);
            Console.WriteLine();

            //ordenamos el array
            Array.Sort(candelariaList);

            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", candelariaList[i]);
            Console.WriteLine();

        }

    }
}
