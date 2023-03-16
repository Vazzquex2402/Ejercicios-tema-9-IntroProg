using System;

namespace Ciclos_de_Repeticion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uso de break");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break; // Termina con el ciclo
                }
                Console.WriteLine("Valor del Contador i: {0}", i);
            }

            Console.WriteLine("Uso de continue");

            int n = 0;
            while (n < 10)
            {

                if (n % 2 == 0)
                {
                    n++;
                    continue;
                }

                Console.WriteLine("Valor del contador n: {0}", n);
                n++;
            } 





        }
    }
}
