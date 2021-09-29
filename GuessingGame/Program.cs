// A simple guess the number game. 
// An exercise I came up with to test my current C# knowledge.

using System;
using System.Collections.Generic;
using System.Text;
namespace GuessingGame
{
    class Game
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int randomNumber = GenerateNumber(1, 101);
                int counter = 20;
                int counter2 = 1;
                while (true)
                {
                    Console.Write(counter+"th attempt : " + "Enter a number between 1 and 100(0 to quit):");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == 0)
                        return;
                    else if (input < randomNumber)
                    {
                        Console.WriteLine("Too low, try again.");
                        --counter;
                        counter2++;
                        if (counter < 0)
                        {
                            Console.WriteLine("sorry attempts over!! Try again..");
                            break;
                        }
                        continue;
                    }
                    else if (input > randomNumber)
                    {
                        Console.WriteLine("Too high, try again.");
                        --counter;
                        counter2++;
                        if (counter < 0)
                        {
                            Console.WriteLine("sorry attempts over!! Try again..");
                            break;
                        }
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!", randomNumber);
                        if (counter < 0)
                        {
                            Console.WriteLine("sorry attempts over!! Try again..");
                            break;
                        }
                        else
                            Console.WriteLine("It took you {0} {1}.\n", counter2, counter2 == 1 ? "try" : "tries");
                        break;
                    }
                }
            }

        }
        static int GenerateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}

