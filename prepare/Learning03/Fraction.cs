using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = _bottom = 1;
        
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int getTop()
    {
        return _top;
    }

    public int getBottom()
    {
        return _bottom;
    }

    public void setTop(int top)
    {
        _top = top;
    }

    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {

        return Convert.ToDouble(_top)/Convert.ToDouble(_bottom);
    }
}