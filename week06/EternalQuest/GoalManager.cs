public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice = 0; 
        do
        {
            Console.WriteLine("Menu options :");
            Console.WriteLine("1.Create new goal");
            Console.WriteLine("2.List goals");
            Console.WriteLine("3.Save goals");
            Console.WriteLine("4.Load goals");
            Console.WriteLine("5.Record Event");
            Console.WriteLine("6.Quit");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalNames();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename to save goals: ");
                string filename = Console.ReadLine();
                SaveGoals(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to load goals: ");
                string filename = Console.ReadLine();
                LoadGoals(filename);
            }
            else if (choice == 5)
            {
                if (_goals.Count == 0)
                {
                    Console.WriteLine("There are no goals to record. Please create a goal first.");
                }
                else
                {
                    Console.WriteLine("Which goal did you accomplish?");
                    for (int i = 0; i < _goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
                    }

                    Console.Write("Enter the number of the completed goal: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int index) && index >= 1 && index <= _goals.Count)
                    {
                        Goal selectedGoal = _goals[index - 1];
                        
                        selectedGoal.RecordEvent();
                        
                        int basePoints = int.Parse(selectedGoal.GetStringRepresentation().Split('|')[3]);
                        _score += basePoints;
                        
                        if (selectedGoal is CheckListGoal checklist && checklist.IsComplete())
                        {
                            int bonus = int.Parse(checklist.GetStringRepresentation().Split('|')[4]);
                            _score += bonus;
                        }

                        Console.WriteLine($"Points earned! Your current score is {_score}.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }
            }
        
            else if (choice == 6)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number from 1 to 6.");
            }
        } while (choice != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current score is :{_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }
        Console.ReadKey();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are :");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.WriteLine("Which type of goal would you like to create: ");
        int goalChoice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("what is the short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        if (goalChoice == 1)
        {
            Goal simpleGoal = new SimpleGoal(goalName, goalDescription, points);
            _goals.Add(simpleGoal);
        }
        else if (goalChoice == 2)
        {
            Goal eternalGoal = new EternalGoal(goalName, goalDescription, points);
            _goals.Add(eternalGoal);
        }
        else if (goalChoice == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing this many times");
            int bonus = int.Parse(Console.ReadLine());

            Goal checklistGoal = new CheckListGoal(goalName, goalDescription, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }

    }
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Saved!");
    }

    public void LoadGoals(string filename)
    {
        // if (!File.Exists(filename))
        // {
        //     Console.WriteLine("File not found.");
        //     return;
        // }

        // _goals.Clear(); // Clear old goals
        string[] lines = File.ReadAllLines(filename);

        // First line is the score
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, description, points);
                goal.SetComplete(isComplete);
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (type == "CheckListGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);

                CheckListGoal goal = new CheckListGoal(name, description, points, target, bonus);
                goal.SetAmountCompleted(completed);
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }


    public void RecordEvent(int goalIndex)
    {
        Goal goal = _goals[goalIndex];
        goal.RecordEvent();

        int basePoints = int.Parse(goal.GetStringRepresentation().Split('|')[3]);
        _score += basePoints;

        if (goal is CheckListGoal checklist && checklist.IsComplete())
        {
            int bonus = int.Parse(checklist.GetStringRepresentation().Split('|')[4]);
            _score += bonus;
        }
    }


}