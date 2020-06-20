using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    class Program
    {

        static string[,] Usuario = new string[4, 10];

        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Hola ¿Qué hará hoy? seleccione la opción");
            Console.WriteLine("\n");

            Console.WriteLine("1. ver usuarios ingresados");
            Console.WriteLine("2. Seleccionar un usuario");
            Console.WriteLine("3. Ver los usuarios");
            Console.WriteLine("4. Cambiar un usuario");
            Console.WriteLine("5. eliminar un usuario");
            Console.WriteLine("6. salir");
            Console.WriteLine("\n");

            x = int.Parse(Console.ReadLine());

            Console.ReadKey();
            Console.Clear();

            while (x != 7)
            {
                if (x == 1)
                {
                    Pedir();

                    Console.WriteLine("1. ver usuarios ingresados");
                    Console.WriteLine("2. Seleccionar un usuario");
                    Console.WriteLine("3. Ver los usuarios");
                    Console.WriteLine("4. Cambiar un usuario");
                    Console.WriteLine("5. eliminar un usuario");
                    Console.WriteLine("6. salir");
                    Console.WriteLine("\n");
                  
                    x = int.Parse(Console.ReadLine());
                }
                if (x == 2)
                {
                    Info();

                    Console.WriteLine("1. ver usuarios ingresados");
                    Console.WriteLine("2. Seleccionar un usuario");
                    Console.WriteLine("3. Ver los usuarios");
                    Console.WriteLine("4. Cambiar un usuario");
                    Console.WriteLine("5. eliminar un usuario");
                    Console.WriteLine("6. salir");
                    Console.WriteLine("\n");

                    x = int.Parse(Console.ReadLine());

                }
                if (x == 3)
                {
                    
                    Mostrar();
                    Console.WriteLine("1. ver usuarios ingresados");
                    Console.WriteLine("2. Seleccionar un usuario");
                    Console.WriteLine("3. Ver los usuarios");
                    Console.WriteLine("4. Cambiar un usuario");
                    Console.WriteLine("5. eliminar un usuario");
                    Console.WriteLine("6. salir");
                    Console.WriteLine("\n");

                    x = int.Parse(Console.ReadLine());

                }
                
                if (x == 5)
                {
                    Borrar();

                    Console.WriteLine("1. ver usuarios ingresados");
                    Console.WriteLine("2. Seleccionar un usuario");
                    Console.WriteLine("3. Ver los usuarios");
                    Console.WriteLine("4. Cambiar un usuario");
                    Console.WriteLine("5. eliminar un usuario");
                    Console.WriteLine("6. salir");
                    Console.WriteLine("\n");

                    x = int.Parse(Console.ReadLine());
                }

            }
            if (x == 6)
            {
                Eliminar();
                Console.WriteLine("1. ver usuarios ingresados");
                Console.WriteLine("2. Seleccionar un usuario");
                Console.WriteLine("3. Ver los usuarios");
                Console.WriteLine("4. Cambiar un usuario");
                Console.WriteLine("5. eliminar un usuario");
                Console.WriteLine("6. salir");
                Console.WriteLine("\n");

                x = int.Parse(Console.ReadLine());

            }

        }
        static void Pedir()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bienvenido, ingrese usuario");

                Console.WriteLine("Ingrese su nombre:");
                Usuario[0, i] = Console.ReadLine();

                Console.WriteLine("Ingrese su apellido:");
                Usuario[1, i] = Console.ReadLine();

                Console.WriteLine("Ingrese su dirección");
                Usuario[2, i] = Console.ReadLine();

                Console.WriteLine("Ingrese su telefono");
                Usuario[3, i] = Console.ReadLine();
                Console.Clear();
            }

        }
        static void Mostrar()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Nombre: " + Usuario[0, i] + " Apellido: " + Usuario[1, i] + " Dirección: " + Usuario[2, i] + " telefono: " + Usuario[3, i] + "\n");
            }
        }
        static void Info()
        {
            string y;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Ingrese el nombre del usuario que quiere ver");
                y = Console.ReadLine();
                if (y == Usuario[0, i])
                {
                    Console.WriteLine(" Nombre: " + Usuario[0, i] + " Apellido: " + Usuario[1, i] + " Dirección: " + Usuario[2, i] + " telefono: " + Usuario[3, i] + "\n");
                }
            }
        }
        static void Borrar()
        {
            String z = "";
            Console.Write("Ingrese el nombre del contacto para Modificarlo ");
            for (int i = 0; i < 1; i++)
            {
                z = Console.ReadLine();

                if (z == Usuario[0, i])

                {
                    Console.WriteLine("Antiguo " + Usuario[0, i]);
                    Console.Write("Nuevo ");
                    Usuario[0, i] = Console.ReadLine();
                    Console.WriteLine("Antiguo" + Usuario[1, i]);
                    Console.Write("Nuevo ");
                    Usuario[1, i] = Console.ReadLine();
                    Console.WriteLine("Antiguo " + Usuario[2, i]);
                    Console.Write("Nuevo ");
                    Usuario[2, i] = Console.ReadLine();
                    Console.WriteLine("Antiguo " + Usuario[3, i]);
                    Console.Write("Nuevo: ");
                    Usuario[3, i] = Console.ReadLine();

                }







            }

        }
        
        static void Eliminar()
        {
            {
                string a;
                Console.Write("ingrese el nombre del usuario Para borrarlo ");

                a = Console.ReadLine();
                for (int i = 0; i < 1; i++)
                {
                    if (a == Usuario[0, i])

                    {

                        Usuario[0, i] = " ";

                        Usuario[1, i] = " ";

                        Usuario[2, i] = " ";

                        Usuario[3, i] = " ";

                    }


                }








            }
        }
    }
}
