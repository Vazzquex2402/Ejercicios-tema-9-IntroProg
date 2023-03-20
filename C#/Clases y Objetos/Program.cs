using System;
using System.Net.Http.Headers;

namespace Clases_y_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo rectangulo
            Rectangulo rect = new Rectangulo();
            rect.Altura = 5;
            rect.Base = 10;

            int area = rect.CalcularArea();
            Console.WriteLine("rect: {0} x {1}, area: {2}", rect.Base, rect.Altura, area);

            // Sintaxis de inicializacion

            Rectangulo rect2 = new Rectangulo { Base = 3, Altura = 8 };
            int area2 = rect2.CalcularArea();
            Console.WriteLine("rect2: {0} x {1}, area: {2}", rect2.Base, rect2.Altura, area2);



        }
    }
}
