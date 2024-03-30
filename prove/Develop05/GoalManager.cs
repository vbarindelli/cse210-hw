using System.IO;
public class GoalManager
{
    public List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        ;
    }
    public void Start()
    {
        Console.WriteLine();
        DisplayPLayerInfo();
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
    }
    public static string PromptUserChoice()
    {
        Console.Write("Select a choice from the menu: ");
        string userChoice = Console.ReadLine();
        return userChoice;
    }


    public void DisplayPLayerInfo()
    {

        Console.WriteLine($"Your score is {_score} points");
    }

    public void ListGoalNames()
    {
        int i = 0;
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal._shortName}");
        }
    }

    public void ListGoalDetails()

    {
        Console.WriteLine("The goals are:");
        int i = 0;
        foreach (Goal goal in _goals)
        {
            i++;
            string completed = goal.isComplete() ? "X" : "";
            
            string strLine = $"{i}. {goal.GetDetailsString()}";
            Console.WriteLine($"{strLine}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        string userGoal = Console.ReadLine();
        switch (userGoal)
        {
            case "1":

                Console.WriteLine("What is the name of your goal? ");
                string nameSimple = Console.ReadLine();
                Console.WriteLine("What is the short description of it: ");
                string descriptionSimple = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                string userPointsSimple = Console.ReadLine();
                int pointsSimple = int.Parse(userPointsSimple);
                SimpleGoal simpleGoal = new SimpleGoal(nameSimple, descriptionSimple, pointsSimple);
                _goals.Add(simpleGoal);
                break;

            case "2":

                Console.WriteLine("What is the name of your goal? ");
                string nameEternal = Console.ReadLine();
                Console.WriteLine("What is the short description of it: ");
                string descriptionEternal = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                string userPointsEternal = Console.ReadLine();
                int pointsEternal = int.Parse(userPointsEternal);
                EternalGoal eternalGoal = new EternalGoal(nameEternal, descriptionEternal, pointsEternal);
                _goals.Add(eternalGoal);
                break;

            case "3":
                Console.WriteLine("What is the name of your goal? ");
                string nameChecklist = Console.ReadLine();
                Console.WriteLine("What is the short description of it: ");
                string descriptionChecklist = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                string userPointsChecklist = Console.ReadLine();
                int pointsChecklist = int.Parse(userPointsChecklist);
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                string userTimesBonus = Console.ReadLine();
                int timesBonusChecklist = int.Parse(userTimesBonus);
                Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                string userBonus = Console.ReadLine();
                int bonusChecklist = int.Parse(userBonus);
                ChecklistGoal checklistGoal = new ChecklistGoal(nameChecklist, descriptionChecklist, pointsChecklist, timesBonusChecklist, bonusChecklist);
                _goals.Add(checklistGoal);

                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string userChoice = Console.ReadLine();
        int userChoiceInt = int.Parse(userChoice);
        _goals[userChoiceInt - 1].RecordEvent();
        int summedPoints = _goals[userChoiceInt - 1].getPoints();
        _score = _score + summedPoints;
        Console.WriteLine($"Congratulations! you have earned {summedPoints} points");
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals(string fileName)
    {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }


    public void LoadGoals(string filename)
    {

        string[] lines = System.IO.File.ReadAllLines(filename);
        {
            _score = int.Parse(lines.First());
            for(int i = 1; i < lines.Length; i++)
            {
                
                string[] parts = lines[i].Split(":");
                string goalType = parts[0];
                string[] properties = parts[1].Split("*");
                string name = properties[0];
                string description = properties[1];
                int points = int.Parse(properties[2]);
                if (goalType == "ChecklistGoal")
                {
                    int target = int.Parse(properties[3]);
                    int bonus = int.Parse(properties[4]);
                    ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(newGoal);
                }
                else if (goalType == "EternalGoal")
                {
                    EternalGoal newGoal = new EternalGoal(name, description, points);
                    _goals.Add(newGoal);
                }
                else if (goalType == "SimpleGoal")
                {
                    SimpleGoal newGoal = new SimpleGoal(name, description, points);
                    _goals.Add(newGoal);
                }
                
            }

        }
    }
}