using System;

namespace Practice_7
{
    class Program
    {
        private static int fact = 5;
        private static int reverse_Integer = 115;
        private static string reverse_String = "abcd";
        private static int palindrome_integer = 121;
        private static string palindrome_string = "aba";
        private static int armstrong_integer = 153;

        static void Main(string[] args)
        {
            // Factorial - int
            Factorial factorial = new Factorial();
            factorial.SetFactorial(fact);
            
            Console.WriteLine("Factorial without recursion: " + factorial.FactorialWithoutRecursion());
            Console.WriteLine("Factorial with recursion: " + factorial.FactorialWithRecursion(fact));

            // Reverse - string and int
            Reverse reverse = new Reverse();
            reverse.SetInteger(reverse_Integer);
            reverse.SetString(reverse_String);

            Console.WriteLine("Reverse of an Integer without recursion: " + reverse.ReverseIntegerWithoutRecursion());
            Console.WriteLine("Reverse of an Integer with recursion: " + reverse.ReverseIntegerWithRecursion(reverse_Integer));

            Console.WriteLine("Reverse of a String without recursion: " + reverse.ReverseStringWithoutRecursion());
            Console.WriteLine("Reverse of a String with recursion: " + reverse.ReverseStringWithRecursion(reverse_String));

            // Palindrome or not - string and int
            Palindrome palindrome = new Palindrome();
            palindrome.SetInteger(palindrome_integer);
            palindrome.SetString(palindrome_string);

            Console.WriteLine($"Is given integer a Palindrome: {palindrome.PalindromeCheckInteger()}");
            Console.WriteLine($"Is given string a Palindrome: {palindrome.PalindromeCheckString()}");

            // Armstrong - int
            Armstrong armstrong = new Armstrong();
            armstrong.SetNumber(armstrong_integer);

            Console.WriteLine($"Is given number an Armstrong: {armstrong.CheckArmstrong()}");
        }
    }
}
