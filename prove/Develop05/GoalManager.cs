public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Run()
    {
        Start();
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    DisplayPlayerInfo();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    DisplayPlayerInfo();
                    break;
                case 6:
                    quit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Goal Manager!");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Current Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Current Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. SimpleGoal");
        Console.WriteLine("2. EternalGoal");
        Console.WriteLine("3. ChecklistGoal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = Convert.ToInt32(Console.ReadLine());

        Goal goal;
        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(goalName, goalPoints, goalDescription);
                break;
            case 2:
                goal = new EternalGoal(goalName, goalPoints, goalDescription);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int goalTarget = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int goalBonus = Convert.ToInt32(Console.ReadLine());

                goal = new ChecklistGoal(goalName, goalPoints, goalDescription, goalTarget, goalBonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select the goal number to record an event:");
        ListGoalNames();
        Console.Write("Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice > 0 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent();
            _score += selectedGoal._points;
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal choice.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Goal goal in _goals)
                {
                    string goalType = goal.GetType().Name;
                    string goalName = goal._name;
                    string goalDescription = goal._description;
                    int goalPoints = goal._points;

                    writer.WriteLine($"{goalType}:{goalName}:{goalDescription}:{goalPoints}");
                }
            }

            Console.WriteLine($"Goals saved to file: {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _goals.Clear();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(':');

                    if (parts.Length >= 4)
                    {
                        string goalType = parts[0];
                        string goalName = parts[1];
                        string goalDescription = parts[2];
                        int goalPoints = Convert.ToInt32(parts[3]);

                        Goal goal;
                        switch (goalType)
                        {
                            case nameof(SimpleGoal):
                                goal = new SimpleGoal(goalName, goalPoints, goalDescription);
                                break;
                            case nameof(EternalGoal):
                                goal = new EternalGoal(goalName, goalPoints, goalDescription);
                                break;
                            case nameof(ChecklistGoal):
                                int goalTarget = Convert.ToInt32(parts[4]);
                                int goalBonus = Convert.ToInt32(parts[5]);
                                goal = new ChecklistGoal(goalName, goalPoints, goalDescription, goalTarget, goalBonus);
                                break;
                            default:
                                Console.WriteLine($"Unknown goal type: {goalType}");
                                continue;
                        }

                        _goals.Add(goal);
                    }
                }
            }

            Console.WriteLine($"Goals loaded from file: {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}