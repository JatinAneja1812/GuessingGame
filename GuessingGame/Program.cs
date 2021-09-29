using System;

namespace GuessingGame
{
    class Game
    {
        static int Guess = 0;
        static int Target = 5;
        static string Input = "";
        static Random RandomNumber = new Random();

        public static void Play()
        {
            Target = RandomNumber.Next(10) + 1;
            Console.Write("Guess what number I am thinking of... ");
            Input = Console.ReadLine();
            if (int.TryParse(Input, out Guess))
            {
                if (Guess == Target)
                {
                    Console.WriteLine("Congratulations! You guessed " + Guess + " and the number I was thinking of was " + Target + ".");
                }
                else
                {
                    Console.WriteLine("Too bad. You guessed " + Guess + " and the number I was thinking of was " + Target + ". Try again!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Play();
            }

            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main()
        {
            Game.Play();
        }
    }
}