public class SimpleGoal : Goal {

    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points) {
        _isComplete = false;
    }

    public void SetIsComplete(bool status) {
        _isComplete = status;
    }

    public override void RecordEvent() {
        SetIsComplete(true);
    }

    public override bool IsComplete() {
        return _isComplete;
    }

    public override string GetStringRepresentation() {
        return $"SimpleGoal~|~{GetName()}~|~{GetDescription()}~|~{GetPoints()}~|~{IsComplete()}";
    }

}