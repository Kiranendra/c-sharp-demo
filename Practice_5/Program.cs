using System;

namespace Practice_5
{
    // Number Guessing Game
    class Program
    {
        static void Main(string[] args)
        {
            // To clear the console before starting the game
            Console.Clear();

            Console.WriteLine("---------------------");
            Console.WriteLine("Guess the number game");
            Console.WriteLine("---------------------");
            int number = 9;
            int numberOfGuess = 3;
            int input = 0;
            while (true && numberOfGuess != 0)
            {
                Console.Write("Enter the number(Guesses remaining " + numberOfGuess + "): ");
                // input = Convert.ToInt32(Console.ReadLine()); // This is valid
                input = int.Parse(Console.ReadLine()); // This is valid
                if (input == number)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Your guess is correct!");
                    Console.WriteLine("----------------------");
                    break;
                }
                else if (input < number)
                {
                    Console.WriteLine("Enter a large number.");
                }
                else
                {
                    Console.WriteLine("Enter a low number.");
                }
                numberOfGuess--;
                if (numberOfGuess == 0)
                {
                    Console.WriteLine("---------");
                    Console.WriteLine("Game Over");
                    Console.WriteLine("---------");
                    break;
                }
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Thank You for playing.");
            Console.WriteLine("----------------------");
        }
    }
}
