using System;

namespace BlazingPizzaVScode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Cantidad");
            int quantity = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("2: Tamanio");
            Console.WriteLine("     1: Pequenio");
            Console.WriteLine("     2: Mediano");
            Console.WriteLine("     3: Grande");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3: Cobertura");
            Console.WriteLine("     1: Pineapple");
            Console.WriteLine("     2: Ham");
            Console.WriteLine("     3: Sausage");
            int coverage = Convert.ToInt32(Console.ReadLine());

            
            
        }
    }
}
