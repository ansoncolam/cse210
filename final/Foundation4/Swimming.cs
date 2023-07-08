public class Swimming : Activity {

    private double _lap;

    public Swimming(DateOnly date, int length, double lap) : base(date, length) {
        _lap = lap;
    }

    public override double Distance() {
        return _lap * 50 / 1000;
    }
    public override double Speed() {
        return Distance() / GetLength() * 60;
    }
    public override double Pace() {
        return 60 / Speed();
    }

    public override string GetActivityType() {
        return "Swimming";
    }


}