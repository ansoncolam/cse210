public class Reception : Event {

    private string _email;

    public Reception(string title, string description, DateOnly date, TimeOnly time, Address address, string email) : base(title, description, date, time, address) {
        _email = email;

    }

    public override void FullDisplay() {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{this.GetTitle()}");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"{this.GetDescription()}");
        Console.WriteLine($"Date: {this.GetDate()}");
        Console.WriteLine($"Time: {this.GetTime()}");
        Console.WriteLine($"RSVP: {_email}");
        Console.WriteLine($"Address: {this.GetAddress().GetAddress()}");

    }

    public override void ShortDisplay() {
        Console.Write("(Reception) ");
        Console.Write(this.GetTitle());
        Console.WriteLine($" - {this.GetDate()}");

    }

}