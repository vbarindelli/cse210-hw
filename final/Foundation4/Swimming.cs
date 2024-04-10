public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base (date, minutes)
    {
        _laps = laps;

    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override float GetSpeed()
    {
        return GetDistance() / _minutes *60;
    }
    public override float GetPace()
    {
        return  _minutes / GetDistance();
    }

     public override string  GetActivityName()
    {
        return "Swimming";
    }
   
}