public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points) :
    base(name, description, points)
    {
        ;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}*{_description}*{_points}";
    }

}