public class Outdoor : Event {
    
    private string _weather;

    public Outdoor(string title, string description, DateOnly date, TimeOnly time, Address address, string weather) : base(title, description, date, time, address) {
        _weather = weather;

    }

    public override void FullDisplay() {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{this.GetTitle()}");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{this.GetDescription()}");
        Console.WriteLine($"Date: {this.GetDate()}");
        Console.WriteLine($"Time: {this.GetTime()}");
        Console.WriteLine($"Weather Forecast: {_weather}");
        Console.WriteLine($"Address: {this.GetAddress().GetAddress()}");

    }

    public override void ShortDisplay() {
        Console.Write("(Outdoor Gathering) ");
        Console.Write(this.GetTitle());
        Console.WriteLine($" - {this.GetDate()}");

    }

}