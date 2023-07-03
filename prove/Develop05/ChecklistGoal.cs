public class ChecklistGoal : Goal {

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points) {
        _amountCompleted = 0;
    }

    public void SetAmountCompleted(int amountCompleted) {
        _amountCompleted = amountCompleted;
    }
    public void SetTarget(int target) {
        _target = target;
    }
    public void SetBonus(int bonus) {
        _bonus = bonus;
    }

    public override void RecordEvent() {
        _amountCompleted = _amountCompleted + 1;
        if (_amountCompleted == _target) {
            SetPoints(GetPoints() + _bonus);
        }
    }

    public override bool IsComplete() {
        if (_amountCompleted == _target) {
            return true;
        } else {
            return false;
        }
    }

    public override string GetDetailsString() {
        if (IsComplete() == false) {
            return $"[ ] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        } else {
            return $"[X] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation() {
        return $"ChecklistGoal~|~{GetName()}~|~{GetDescription()}~|~{GetPoints()}~|~{_bonus}~|~{_target}~|~{_amountCompleted}";
    }
    
}