using System.Formats.Tar;

public class ChecklistGoal : Goal
{

    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
    _target = target;
    _bonus = bonus;

    }
        public override void RecordEvent()
        {
            _amountCompleted++;
            if (_amountCompleted >= _target)
            {
                _amountCompleted = _target;
                _isComplete = true;
            }
        }

        

        public override bool isComplete()
        {
            return _isComplete;
        }
        public override int getPoints()
        {
            int totalPoints = _points;
             if (_amountCompleted == _target)
            {
                totalPoints = totalPoints + _bonus;
            }
            return totalPoints;
        }

        public override string GetDetailsString()
        {
            string completed = isComplete() ? "X" : "";
            return $"[{completed}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{_shortName}*{_description}*{_points}*{_target}*{_bonus}";
        }


}