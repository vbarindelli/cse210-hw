public class Bicycle : Activity
{
    private float _speed;

    public Bicycle(string date, int minutes, float speed) : base (date, minutes)
    {
        _speed = speed;

    }

    public override float GetDistance()
    {
        return _minutes * _speed / 60;
    }

    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        return  60 / _speed;
    }

     public override string  GetActivityName()
    {
        return "Cycling";
    }
   

}