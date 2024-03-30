using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        string userInput = "";
        while (userInput != "6")
        {
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    goalManager.CreateGoal();
                    break;
                case "2":
                    Console.Clear();
                    goalManager.ListGoalDetails();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("What is the filename?");
                    string saveFileName = Console.ReadLine();
                    goalManager.SaveGoals(saveFileName);
                    break;
                case "4":
                    Console.WriteLine("What is the filename?");
                    string loadFileName = Console.ReadLine();
                    goalManager.LoadGoals(loadFileName);
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                default:
                    break;

            }
            goalManager.Start();
            userInput = GoalManager.PromptUserChoice();
        }
    }
}