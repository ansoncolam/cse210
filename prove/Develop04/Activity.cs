public class Activity {

    private string _name;
    private string _description;
    private int _duration;

    public Activity() {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public string GetName() {
        return _name;
    }
    public string GetDescription() {
        return _description;
    }
    public void SetName(string name) {
        _name = name;
    }
    public void SetDescription(string description) {
        _description = description;
    }
    public void SetDuration(int time) {
        _duration = time;
    }

    public void DisplayStartingMessage() {
        Console.WriteLine($"Welcome to the {GetName()} Activity.");
        Console.WriteLine("");
        Console.WriteLine(GetDescription());
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
    }

    public void DisplayEndingMessage() {
        Console.WriteLine("Well done!!");
        ShowSpinner(4);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
    }

    public void ShowSpinner(int seconds) {

        List<string> spinner = new List<string>();
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime) {
            foreach (string s in spinner) {
                currentTime = DateTime.Now;
                Console.Write(s);
                Thread.Sleep(200);
                Console.Write("\b \b");
            }
        }

    }

    public void ShowCountDown(int seconds) {

        for (int i = seconds; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");

    }

}