public class BreathingActivity : Activity {

    public BreathingActivity() {
        this.SetName("Breathing");
        this.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
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
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timePeriod);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime) {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.Write("Now Breathe out...");
            ShowCountDown(6);
            Console.WriteLine("");
            currentTime = DateTime.Now;
        }

        DisplayEndingMessage();
        ShowSpinner(4);

    }

}
