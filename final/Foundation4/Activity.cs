public abstract class Activity
{
    public string _date;
    public int _minutes;
    public string _name;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
     
    }

    public virtual float GetDistance()
    {
        return 0;
    }

    public virtual float GetSpeed()
    {
        return 0;
    }
    public virtual float GetPace()
    {
        return 0;
    }

    public virtual string GetActivityName()
    {
        return "";
    }
    public virtual string GetSummary()
    {
        return $"* {_date} {GetActivityName()} ({_minutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()}, Pace: {GetPace()} min per km."; 
    }

}