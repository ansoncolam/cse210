using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int squareNumber = SquareNumber(PromptUserNumber());

        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
        return userNumber;
    }

    static int SquareNumber(int userNumber) {
        int squareNumber = userNumber * userNumber; 
        return squareNumber;
    }

    static void DisplayResult(string userName, int squareNumber) {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }

}