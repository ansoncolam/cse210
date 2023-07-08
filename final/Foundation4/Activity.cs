public abstract class Activity {

    private DateOnly _date;
    private int _length;

    public Activity(DateOnly date, int length) {
        _date = date;
        _length = length;
    }

    public int GetLength() {
        return _length;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public abstract string GetActivityType();

    public string GetSummary() {
        return $"{_date.Day.ToString("00")} {_date.ToString("MMM")} {_date.Year} {GetActivityType()} ({_length} min): Distance {Distance().ToString("0.0")} km, Speed: {Speed().ToString("0.0")} kph, Pace: {Pace().ToString("0.0")} min per km";
    }

}