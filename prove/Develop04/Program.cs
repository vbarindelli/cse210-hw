using System;

//For the stretch challenge, I added a log of how many activities were performed in the session. I also made sure no random questions were repeated from 
//the reflecting activity until all of them have been shown.

class Program
{
    static void Main(string[] args)
    {
        string userInput="";
        int i = 0;

        while(userInput != "4")
        {           
            i++;
            switch (userInput)
            { 
                case "1":
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                break;
                case "2":
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                break;
                case "3":
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                break;
                case "4":
                default: 
                break;
                
            }
            userInput = Menu.showMenu();
        }
        i--;
        Console.WriteLine($"Congratulations on completing a sesion in Mindfullness, you did {i} activities.");
    }
}
    
