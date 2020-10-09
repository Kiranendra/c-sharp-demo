// This is importing all the classes that belong to the "System" namespace.
using System;

// Single line comment

/* 
    Multi-line 
    comments
*/

// "namespace" is a container for classes and methods.
namespace Practice_1
{
    /* 
        Name of the class "Program". Changing it is not a good idea. But we can change. */
    class Program
    {
        // Every program starts from the "Main" method
        static void Main(string[] args)
        {
            // Hello World
            Console.Write("Hello");
            Console.WriteLine(" Kiranendra");

            // Datatypes
            /* 
                int --> Integer --> 4 bytes
                long --> Integer --> 8 bytes
                float --> Decimal --> 4 bytes ==> float  a = 123.32F;
                double --> Decimal --> 8 bytes ==> double  b = 123.32D;
                char --> Character (single character) --> 2 bytes ==> char c = 'A';
                bool --> Boolean (true / false) --> 1 bit
                string --> String --> 2 bytes per charcter ==> string str = "ABC";
                var x = 1; --> To not define a datatype
            */

            // int a = 9;
            // Console.Write("The number is " + a);

            // "ReadLine()" returns a string
            // string input = Console.ReadLine();

            // Type Casting - Converting values from one datatype to other

            // 1. Implicit Casting [char --> int --> long --> float --> double]
                /* 
                    int a = 'A'; // valid
                    char b = 65; // invalid
                */

            // 2. Explicit Casting
                /*
                    int a = (int) 3.5; // Converting float into int
                    double b = (double) 3.5F; // Converting float into double
                    float c = (float) 3.5D; // Converting double into float
                    Console.WriteLine(a + " : " + b + " : " + c);
                */

            // Simple Calculator
                /*
                    Console.Write("Enter x: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Enter y: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    // Console.Write("Addition is " + (x + y));
                    int sum = x + y;
                    Console.Write("Addition is " + sum);
                */

            // "Math" class available in "System" class
                /* 
                    "Math.Max()", "Math.Min()", "Math.Abs()",..... 
                    "Math.Sqrt()" --> returns a double value 
                */

            // String methods
                /*
                    string a = "kiranendra";
                    a.Length
                    a.ToUpper()
                    a.ToLower()
                    string.Concat("String 1", "String 2")
                */
            
            // String interpolation --> Just like f-strings in PYTHON
            // int a = 9;
            // Console.WriteLine($"The number is {a}");

            // String indexing
            // string str = "ABCD";
            // Console.WriteLine(str[1]);
            // Console.WriteLine(str.IndexOf('C'));
            // Console.WriteLine(str.IndexOf("CD"));
            // Console.WriteLine(str.Substring(1)); // Substring(startIndex)

                /*
                    \", \n, \t
                */
        }
    }
}
