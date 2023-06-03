using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        int guess = magic + 1;

        while (magic != guess) {
            Console.Write("What is your guess? ");
            string userInput2 = Console.ReadLine();
            guess = int.Parse(userInput2);
            if (magic > guess) {
                Console.WriteLine("Higher");
            } else if (magic < guess) {
                Console.WriteLine("Lower");
            } else if (magic == guess) {
                Console.WriteLine("You guessed it!");
            }
        }

        

    }
}