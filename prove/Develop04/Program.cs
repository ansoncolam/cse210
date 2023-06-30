using System;

class Program
{
    static void Main(string[] args)
    {

        int userInput = 0;
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (userInput != 4) {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            if (int.TryParse(userChoice, out _)) {
                userInput = int.Parse(userChoice);

                if (userInput == 1) {
                    Console.Clear();
                    BreathingActivity myActivity = new BreathingActivity();
                    myActivity.Run();
                    breathingCount = breathingCount + 1;
                } else if (userInput == 2) {
                    Console.Clear();
                    ReflectingActivity myActivity = new ReflectingActivity();
                    myActivity.Run();
                    reflectingCount = reflectingCount + 1;
                } else if (userInput == 3) {
                    Console.Clear();
                    ListingActivity myActivity = new ListingActivity();
                    myActivity.Run();
                    listingCount = listingCount + 1;
                } else if (userInput == 4) {
                    Console.WriteLine("");
                    int totalCount = breathingCount + reflectingCount + listingCount;
                    Console.WriteLine($"You have done {totalCount} activities this time:");
                    Console.WriteLine($"  - Breathing Activity  x {breathingCount}");
                    Console.WriteLine($"  - Reflecting Activity x {reflectingCount}");
                    Console.WriteLine($"  - Listing Activity    x {listingCount}");
                    Console.WriteLine("");
                    Console.WriteLine("Good Bye!");
                    break;
                }

            }

        }

    }
}