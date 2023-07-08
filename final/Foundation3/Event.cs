public abstract class Event {

    private string _title;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _address;

    public Event(string title, string description, DateOnly date, TimeOnly time, Address address) {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle() {
        return _title;
    }
    public string GetDescription() {
        return _description;
    }
    public DateOnly GetDate() {
        return _date;
    }
    public TimeOnly GetTime() {
        return _time;
    }
    public Address GetAddress() {
        return _address;
    }

    public void StandardDisplay() {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{_title}");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public abstract void FullDisplay();

    public abstract void ShortDisplay();

}