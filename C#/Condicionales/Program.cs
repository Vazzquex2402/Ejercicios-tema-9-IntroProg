using System;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //if
            int num = 10;

            if (num > 5)
            {
                Console.WriteLine("num es mayor que 5");
            }
            //Condicional Compuesta

            string user = "user1";
            string pass = "hola123";

            if (user == "user1" && pass == "hola123")
            {
                Console.WriteLine("Acceso Corecto");
            }

            // if - Else

            int edad = 23;

            if (edad >= 18)
            {
                Console.WriteLine("Mator de Edad");
            }
            else
            {
                Console.WriteLine("Menor de edad");
            }

            // if - ese if
            int a = 6;
            int b = 8;

            if (a > b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            } 
            else if (a < b)
            {
                Console.WriteLine("{0} < {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} == {1}", a, b);
            }


            // Swith

            string codigo = "A1";
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("Producto1");
                    break;
                case "A2":
                    Console.WriteLine("Producto2");
                    break;
                case "A3":
                    Console.WriteLine("Producto3");
                    break;
                case "A4":
                    Console.WriteLine("Producto4");
                    break;
                default:
                    Console.WriteLine("Producto No Encontrado");
                    break;
            }





        }
    }
}
