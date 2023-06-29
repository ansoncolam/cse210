public class ReflectingActivity : Activity {

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() {
        this.SetName("Reflecting");
        this.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run() {

        DisplayStartingMessage();

        string userInput = Console.ReadLine();
        int timePeriod = int.Parse(userInput);

        while (timePeriod < 10) {
            Console.Write("Please enter at least 10 seconds. ");
            userInput = Console.ReadLine();
            timePeriod = int.Parse(userInput);
        }
        
        SetDuration(timePeriod);

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.WriteLine("");

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");

        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        DisplayPrompt();
        Console.WriteLine("");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you? ");
        _questions.Add("Have you ever done anything like this before? ");
        _questions.Add("How did you get started? ");
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What made this time different than other times when you were not as successful? ");
        _questions.Add("What is your favorite thing about this experience? ");
        _questions.Add("What could you learn from this experience that applies to other situations? ");
        _questions.Add("What did you learn about yourself through this experience? ");
        _questions.Add("How can you keep this experience in mind in the future? ");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timePeriod);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime) {
            DisplayQuestions();
            ShowSpinner(10);
            Console.WriteLine("");
            currentTime = DateTime.Now;
        }

        Console.WriteLine("");

        DisplayEndingMessage();

        ShowSpinner(4);

    }

    public string GetRandomPrompt() {
        Random randomNumber = new Random();
        int randNum = randomNumber.Next(0, _prompts.Count());
        return _prompts[randNum];
    }

    public string GetRandomQuestion() {
        Random randomNumber = new Random();
        int randNum = randomNumber.Next(0, _questions.Count());
        return _questions[randNum];
    }

    public void DisplayPrompt() {
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
    }

    public void DisplayQuestions() {
        Console.Write($"> {GetRandomQuestion()}");
    }
}