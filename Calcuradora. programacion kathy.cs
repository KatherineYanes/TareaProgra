using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            try
            {
                string r = "";

                do
                {

                    int a = 0;
                    int b = 0;
                    int c = 0;

                    Console.WriteLine("Presione el simbolo que corresponda a la opcion que desea realizar: ");
                    Console.WriteLine("Ejemplo: ");
                    Console.WriteLine("+ para suma");
                    Console.WriteLine("- para resta");
                    Console.WriteLine("* para muultiplicación");
                    Console.WriteLine("/ para división");
                    r = Console.ReadLine();

                    string elecction = Convert.ToString(r);
                    Console.Clear();
                    Console.WriteLine("Operación " + r);
                    Console.WriteLine("Primer Número;");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo Número;");
                    b = int.Parse(Console.ReadLine());

                    switch (elecction)
                    {
                        case "+":

                            Console.WriteLine("La suma es: ");
                            c = a + b;

                            Console.WriteLine(a + "+" + b + "=" + c);
                            break;
                        case "-":
                            Console.WriteLine("La diferencia es: ");
                            c = a - b;
                            Console.WriteLine(a + "+" + b + "=" + c);
                            break;
                        case "*":
                            Console.WriteLine("el producto  es: ");
                            c = a * b;
                            Console.WriteLine(a + "+" + b + "=" + c);
                            break;
                        case "/":
                            Console.WriteLine("El cociente es: ");
                            c = a / b;
                            Console.WriteLine(a + "+" + b + "=" + c);
                            break;

                    }
                    Console.WriteLine("¿Desea realizar otra operación? S o N");
                    r = Console.ReadLine();

                }
                while (r == "s" || r == "s");

            }
            catch (System.IndexOutOfRangeException e)
            {
                System.Console.WriteLine("Error");
                Console.WriteLine("¿Desea relizar una operación?");
                Console.WriteLine("1 (Sí) 2(No)");
                int o;
                o = int.Parse(Console.ReadLine());
                if (o == 1)
                {

                    throw new System.ArgumentOutOfRangeException("Index paramenter is out of range. ", e);
                }
            }
        }
    }    }
