using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<float> numbers = new List<float>();
        float Number = -999999999;
        float sum = 0;
        int count = 0;
        float largest = -999999999;

        while (Number != 0) {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            Number = float.Parse(userInput);
            numbers.Add(Number);
            sum = sum + Number;
            count = count + 1;
            if (largest < Number) {
                largest = Number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / (count - 1)}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}