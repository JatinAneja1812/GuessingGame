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
            int counter = 0;
            int choice;
            do
            {
                Console.WriteLine("Select the Level..");
                Console.WriteLine("1. Easy (number range: 1-100 and 20 turns)");
                Console.WriteLine("2. Medium (number range: 1-500 and 15 turns)");
                Console.WriteLine("3. Hard (number range: -1000 to +1000 and 7 turns)");
                Console.WriteLine("4. To Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        counter = Easylevel();
                        break;
                    case 2:
                        counter = Mediumlevel();
                        break;
                    case 3:
                        counter = Hardlevel();
                        break;
                    case 4:
                        Console.WriteLine("Thanks For Playing..");
                        break;
                    default: Console.WriteLine("Choose between 1 - 4");
                        break;
                           
                }
                Console.WriteLine("Thanks For Playing..");
                Console.ReadLine();
            } while (counter != 0 || choice > 4);
        }

        
        private static int Hardlevel()
        {
            Console.WriteLine("You have selected Hard difficulty...");
            Console.WriteLine("You have just 7 attempts to guess the number in range -1000 - 1000");
            Console.WriteLine("Let the Game Begins...");

            while (true)
            {
                int randomNumber = GenerateNumber(-1000, 1001);
                int counter = 7;
                int counter2 = 1;
                while (true)
                {
                    Console.Write(counter + "th attempt : " + "Enter a number between -1000 and 1001(0 to quit):");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == 0)
                        return counter=-1;
                    else if (input < randomNumber)
                    {
                        Console.WriteLine("Too low, try again.");
                        --counter;
                        counter2++;
                        if (counter < 0)
                        {
                            Console.WriteLine("sorry attempts over!! Try again..");
                            return counter;
                            
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
                            return counter;
                            
                        }
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!", randomNumber);
                        if (counter < 0)
                        {
                            Console.WriteLine("sorry attempts over!! Try again..");
                            return counter;

                        }
                        else
                        {
                            Console.WriteLine("It took you {0} {1}.\n", counter2, counter2 == 1 ? "try" : "tries");
                            return counter = -1;
                        }
                        
                    }
                }
            }
        }

        private static int Mediumlevel()
        {
            Console.WriteLine("You have selected Medium difficulty...");
            Console.WriteLine("You have 15 attempts to guess the number in range 1 - 500");
            Console.WriteLine("Let the Game Begins...");

            while (true)
            {
                int randomNumber = GenerateNumber(1, 500);
                int counter = 15;
                int counter2 = 1;
                while (true)
                {
                    Console.Write(counter + "th attempt : " + "Enter a number between 1 and 100(0 to quit):");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == 0)
                        return counter = -1;
                    else if (input < randomNumber)
                    {
                        Console.WriteLine("Too low, try again.");
                        --counter;
                        counter2++;
                        if (counter < 0)
                        {
                            Console.WriteLine("sorry attempts over!! Try again..");
                            return counter;
                          
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
                            return counter;
                            
                        }
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!", randomNumber);
                        if (counter < 0)
                        {
                            Console.WriteLine("sorry attempts over!! Try again..");
                            return counter;

                        }
                        else
                        {
                            Console.WriteLine("It took you {0} {1}.\n", counter2, counter2 == 1 ? "try" : "tries");
                            return counter = -1;
                        }
                       
                    }
                }
            }
        }

        public static int Easylevel()
        {
            Console.WriteLine("You have selected Easy difficulty...");
            Console.WriteLine("You have 20 attempts to guess the number in range 1 - 100");
            Console.WriteLine("Let the Game Begins...");
            while (true)
            {
                int randomNumber = GenerateNumber(1, 101);
                int counter = 20;
                int counter2 = 1;
                while (true)
                {
                    Console.Write(counter + "th attempt : " + "Enter a number between 1 and 100(0 to quit):");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == 0)
                        return counter = -1;
                    else if (input < randomNumber)
                    {
                        Console.WriteLine("Too low, try again.");
                        --counter;
                        counter2++;
                        if (counter < 0)
                        {
                            Console.WriteLine("sorry attempts over!! Try again..");
                            return counter;
                           
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
                            return counter;
                          
                        }
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!", randomNumber);
                        if (counter < 0)
                        {
                            Console.WriteLine("sorry attempts over!! Try again..");
                            return counter;
                        }
                        else
                        {
                            Console.WriteLine("It took you {0} {1}.\n", counter2, counter2 == 1 ? "try" : "tries");
                            return counter = -1;
                        }
                        
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

