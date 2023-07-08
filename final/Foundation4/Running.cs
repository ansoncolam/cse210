public class Running : Activity {

    private double _distance;

    public Running(DateOnly date, int length, double distance) : base(date, length) {
        _distance = distance;
    }

    public override double Distance() {
        return _distance;
    }
    public override double Speed() {
        return _distance / GetLength() * 60;
    }
    public override double Pace() {
        return 60 / Speed();
    }

    public override string GetActivityType() {
        return "Running";
    }

}