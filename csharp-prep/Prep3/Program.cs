using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,101);

            //Console.Write("What is the magic number? ");
            //int magicNumber = int.Parse(Console.ReadLine());

            int guess = 0;

            while (number != guess)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (number == guess)
                {
                    Console.WriteLine("You guessed it!");
                } else if (number > guess)
                {
                    Console.WriteLine("Higher");
                } else if (number < guess)
                {
                    Console.WriteLine("Lower");
                }
            }

            Console.Write("Would you like to play again? (yes/no) ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}