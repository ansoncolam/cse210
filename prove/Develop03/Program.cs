using System;

class Program {
    static void Main(string[] args) {

        Reference myReference = new Reference("Proverbs", 3, 5, 6);
        Scripture myScripture = new Scripture(myReference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        
        string userInput = "";

        while (userInput != "quit") {

            Console.Clear();
            myScripture.GetDisplayText();
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type \'quit\' to finish:");

            myScripture.HideRandomWords(1);

            userInput = Console.ReadLine();

        }

    }
}