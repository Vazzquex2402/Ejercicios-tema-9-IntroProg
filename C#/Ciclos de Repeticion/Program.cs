using System;

namespace Ciclos_de_Repeticion
{
    class Program
    {
        static void Main(string[] args)
        {


            //Ciclo for
            Console.WriteLine("Usando ciclo for");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor del contador i: {0}", i);
                
            }

            Console.WriteLine("usando ciclo for");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor del contador i: {0}",i);
            }

            //Ciclo while
            Console.WriteLine("\nUsando ciclo While");

            // Ciclo While
            Console.WriteLine("\nUsando ciclo While");
            int n = 0; // Declaracion del contador

            while (n < 5)
            {
                Console.WriteLine("Valor del contador n: {0}", n);
                n++;
            }

            // Ciclo Do - While
            Console.WriteLine("\nUsando ciclo Do - While");
            int c = 10;

            do
            {
                Console.WriteLine("Valor del contador c: {0}", c);
            } while (c < 5);



        }
    }
}
