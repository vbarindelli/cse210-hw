using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public abstract class Goal
{
    public string _shortName;
    public string _description;
    public int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();


    public abstract bool isComplete();

    
    public virtual int getPoints()
    {
        return _points;
    }


    public virtual string GetDetailsString()
    {
        string completed = isComplete() ? "X" : "";
        return $"[{completed}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();





}