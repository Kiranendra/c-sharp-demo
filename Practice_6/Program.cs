using System;

namespace Practice_6
{
    class Program
    {
        private static string theName = "abc";
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("   ------------------");
            Console.WriteLine("   Welcome to Hangman");
            Console.WriteLine("   ------------------\n");
            PrintDashes(theName.Length);
            string[] inputName = GenerateDashes(theName.Length);
            StartTheGame(inputName);
        }

        static void StartTheGame(string[] inpName)
        {
            bool arrayUpdated = false;
            int hangManCount = 0;
            string[] inputName = inpName;
            char inputCharacter = 'A';
            while (true)
            {
                arrayUpdated = false;
                if (string.Join("", inputName) == theName)
                {
                    Console.WriteLine("\n   --------");
                    Console.WriteLine("   You win!");
                    break;
                }
                Console.Write("   Enter letter: ");
                inputCharacter = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < theName.Length; i++)
                {
                    if (inputCharacter == theName[i])
                    {
                        inputName[i] = Convert.ToString(inputCharacter);
                        arrayUpdated = true;
                    }
                }
                if (!arrayUpdated)
                {
                    hangManCount++;
                    DisplayHangMan(hangManCount);
                    if (hangManCount == 6)
                    {
                        break;
                    }
                }
                PrintinputName(inputName);   
            }
            Console.WriteLine("   ---------------------");
            Console.WriteLine("   Thank you for playing");
            Console.WriteLine("   ---------------------\n");
        }

        static void PrintDashes(int NumberOfDashes)
        {
            Console.Write("\t");
            for (int i = 0; i < NumberOfDashes; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("\n");
        }

        static string[] GenerateDashes(int NumberOfDashes)
        {
            string[] tempVariable = new string[theName.Length];
            for (int i = 0; i < NumberOfDashes; i++)
            {
                tempVariable[i] = "-";
            }
            return tempVariable;
        }

        static void PrintinputName(string[] name)
        {
            Console.Write("\n\t");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine("\n");
        }

        static void DisplayHangMan(int count)
        {
            switch(count)
            {
                case 1:
                    Console.WriteLine("\n   O");
                    break;
                case 2:
                    Console.WriteLine("\n   O");
                    Console.WriteLine("   |");
                    break;
                case 3:
                    Console.WriteLine("\n   O");
                    Console.Write("  /");
                    Console.WriteLine("|");
                    break;
                case 4:
                    Console.WriteLine("\n   O");
                    Console.Write("  /");
                    Console.Write("|");
                    Console.WriteLine("\\");
                    break;
                case 5:
                    Console.WriteLine("\n   O");
                    Console.Write("  /");
                    Console.Write("|");
                    Console.WriteLine("\\");
                    Console.WriteLine("  / ");
                    break;
                case 6:
                    Console.WriteLine("\n   O");
                    Console.Write("  /");
                    Console.Write("|");
                    Console.WriteLine("\\");
                    Console.Write("  / ");
                    Console.WriteLine("\\");
                    Console.WriteLine("\n   ----------------------------------");
                    Console.WriteLine("   You Lose! You let a poor human die");
                    Console.WriteLine("   ----------------------------------");
                    break;
            }
        }
    }
}
