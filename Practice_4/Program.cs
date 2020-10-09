using System;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SecondProgram secondProgram = new SecondProgram();
            Console.WriteLine(secondProgram.count);

            // Here, the variable name is inaccessible
            // Console.WriteLine(secondProgram.name); 
            
            Console.WriteLine("-------------------------");
            Console.WriteLine("Value of the 'name' variable before setting: " + secondProgram.GetName());
            secondProgram.SetName("The name is set now");
            Console.WriteLine("Value of the 'name' variable after setting: " + secondProgram.GetName());
        }
    }
}
