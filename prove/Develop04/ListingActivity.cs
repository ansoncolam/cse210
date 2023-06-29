public class ListingActivity : Activity {

    private int _count;
    private List<string> _prompts;

    public ListingActivity() {
        this.SetName("Listing");
        this.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
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

        Console.WriteLine("List as many responses you can to the following prompt:");

        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timePeriod);
        DateTime currentTime = DateTime.Now;

        _count = 0;

        while (currentTime < futureTime) {
            Console.Write("> ");
            string userType = Console.ReadLine();
            _count = _count + 1;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("");

        DisplayEndingMessage();

        ShowSpinner(4);
    }

    public void GetRandomPrompt() {
        Random randomNumber = new Random();
        int randNum = randomNumber.Next(0, _prompts.Count());
        Console.WriteLine($" --- {_prompts[randNum]} --- ");
    }

    // public List<string> GetListFromUser() {



    // }

}