using System;

class Program {
    static void Main(string[] args) {

        string[] lines = System.IO.File.ReadAllLines("Scripture.txt");
        int lineCount = File.ReadLines("Scripture.txt").Count();
        Random randomGenerator = new Random();
        int randNum = randomGenerator.Next(0, lineCount);
        string line = File.ReadLines("Scripture.txt").Skip(randNum).Take(1).First();
        string[] parts = line.Split("~|~");
        List<string> _scripture = new List<string>();
        int newChapter = int.Parse(parts[1]);
        int newVerse = int.Parse(parts[2]);
        int newEndVerse = int.Parse(parts[3]);
        Reference myReference = new Reference(parts[0],newChapter,newVerse,newEndVerse);
        Scripture myScripture = new Scripture(myReference, parts[4]);

        string userInput = "";

        while (userInput != "quit") {

            Console.Clear();
            myScripture.GetDisplayText();
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type \'quit\' to finish:");

            if (myScripture.IsCompletelyHidden() == true) {
                Console.WriteLine("");
                break;
            }

            myScripture.HideRandomWords(3);

            userInput = Console.ReadLine();

        }
        
    }
}