public class Entry {
    public string _date;
    public string _time;
    public string _promptText;
    public string _entryText;

    public Entry() {
        DateTime theCurrentTime = DateTime.Now;
        _date = DateTime.Now.ToShortDateString();
        _time = DateTime.Now.ToShortTimeString();
        _promptText = "";
        _entryText = "";
    }

    public string GetPrompt() {
        return _promptText;
    }

    public void SetPrompt(string promptText) {
        _promptText = promptText;
    }

    public void SetEntry(string entryText) {
        _entryText = entryText;
    }

    public void Display() {
        Console.WriteLine($"Date: {_date}   Time: {_time}   Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine("");
    }
}