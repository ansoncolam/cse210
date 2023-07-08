public class Lecture : Event {

    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, DateOnly date, TimeOnly time, Address address, string name, int capacity) : base(title, description, date, time, address) {
        _speakerName = name;
        _capacity = capacity;
    }

    public override void FullDisplay() {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{this.GetTitle()}");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{this.GetDescription()}");
        Console.WriteLine($"Date: {this.GetDate()}");
        Console.WriteLine($"Time: {this.GetTime()}");
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"Address: {this.GetAddress().GetAddress()}");
        Console.WriteLine($"Location Capacity: {_capacity}");

    }

    public override void ShortDisplay() {
        Console.Write("(Lecture) ");
        Console.Write(this.GetTitle());
        Console.WriteLine($" - {this.GetDate()}");

    }

}