using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number_grade = int.Parse(userInput);

        string letter = "";

        if (number_grade > 100 || number_grade < 0) {
            Console.WriteLine("Please try again. ");
        } else if (number_grade >= 90) {
            letter = "A";
        } else if (number_grade >= 80) {
            letter = "B";
        } else if (number_grade >= 70) {
            letter = "C";
        } else if (number_grade >= 60) {
            letter = "D";
        } else if (number_grade < 60 && number_grade >= 0) {
            letter = "F";
        } else {
        }

        if (number_grade >= 70) {
            Console.WriteLine($"Your grade is {letter}.");
            Console.WriteLine("Congratulations! You passed!");
        } else if (number_grade < 70) {
            Console.WriteLine($"Your grade is {letter}.");
            Console.WriteLine("You did not pass. Work hard next time.");
        }

    }
}