using System;

class Program
{
    static void Main(string[] args)
    {
       
        Running running1 = new Running("22 Sept 2023", 45, 8.5F);
        Running running2 = new Running("25 Sept 2023", 30, 6.5F);
        Bicycle bicycle1 = new Bicycle("21 Oct 2023", 60, 25);
        Bicycle bicycle2 = new Bicycle("23 Sept 2023", 120, 30);
        Swimming swimming = new Swimming("11 Dec 2023", 90, 15);

       List<Activity> _activity = new List<Activity>
        {
            running1,
            running2,
            bicycle1, 
            bicycle2, 
            swimming

        };

        foreach (Activity activity in _activity)
        {
            Console.WriteLine(activity.GetSummary());
        }




    }
}