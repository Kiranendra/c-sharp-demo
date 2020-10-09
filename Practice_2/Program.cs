using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Greet();

            // C# automatically chooses the methods of same names with different parameters
            Add(2, 3);
            Add(2.3F, 3);
            Add(1, 2, 3);
        }

        static void Greet()
        {
            System.Console.WriteLine("Good Evening!");
        }

        // Same name with '2' integer parameters
        static void Add(int x, int y)
        {
            System.Console.WriteLine(x + y);
        }

        // Same name with '1' float parameter and '1' integer parameter.
        static void Add(float x, int y)
        {
            System.Console.WriteLine(x + y);
        }

        // Same name with '3' integer parameters
        static void Add(int x, int y, int z)
        {
            System.Console.WriteLine(x + y + z);
        }
    }
}
