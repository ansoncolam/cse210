using System;

class Program {

    public static void Main(string[] args) {

        int userInputN = 999;
        Journal userJournal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        while (userInputN != 5) {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string userInputS = Console.ReadLine();

            if (int.TryParse(userInputS, out _)) {
                userInputN = int.Parse(userInputS);

                if (userInputN == 5) {
                    Console.WriteLine("Bye!");

                } else if (userInputN == 1) {
                    Entry userEntry = new Entry();
                    DateTime theCurrentTime = DateTime.Now;
                    userEntry._date = DateTime.Now.ToShortDateString();
                    userEntry._promptText = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine(userEntry._promptText);
                    userEntry._entryText = Console.ReadLine();
                    userJournal.AddEntry(userEntry);

                } else if (userInputN == 2) {
                    userJournal.DisplayAll();

                } else if (userInputN == 3) {
                    Console.WriteLine("What is the filename?");
                    string fileName1 = Console.ReadLine();
                    userJournal.LoadFromFile(fileName1);

                } else if (userInputN == 4) {
                    Console.WriteLine("What is the filename?");
                    string fileName2 = Console.ReadLine();
                    userJournal.SaveToFile(fileName2);

                } else {
                    Console.WriteLine("Please enter a number from 1 to 5.");
                }
            } else {
                Console.WriteLine("Please enter a number from 1 to 5.");

            }
        }

    }
}