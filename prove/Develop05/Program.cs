class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;
    private static string saveFileName = "goals.txt";

    static void Main(string[] args)
    {
        LoadGoals();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Exit");

            Console.Write("\nEnter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:
                    ShowGoals();
                    break;
                case 4:
                    ShowScore();
                    break;
                case 5:
                    SaveGoals();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    static void CreateGoal()
    {
        Console.Write("\nEnter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSelect goal type:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                goals.Add(new SimpleGoal(name, points));
                Console.WriteLine("Simple goal created.");
                break;
            case 2:
                goals.Add(new EternalGoal(name, points));
                Console.WriteLine("Eternal goal created.");
                break;
            case 3:
                Console.Write("Enter checklist target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter checklist bonus: ");
                int bonus = int.Parse(Console.ReadLine());

                goals.Add(new ChecklistGoal(name, points, target, bonus));
                Console.WriteLine("Checklist goal created.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("\nSelect goal to record event for:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice > 0 && choice <= goals.Count)
        {
            Goal selectedGoal = goals[choice - 1];
            selectedGoal.RecordEvent();
            score += selectedGoal.Points;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void ShowGoals()
    {
        Console.WriteLine("\nGoals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"Goal {i + 1}:");
            goals[i].DisplayProgress();
            Console.WriteLine();
        }
    }

    static void ShowScore()
    {
        Console.WriteLine($"\nCurrent Score: {score}");
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(saveFileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetType().Name);
                writer.WriteLine(goal.Name);
                writer.WriteLine(goal.Points);
                writer.WriteLine(goal.IsComplete);

                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine(checklistGoal.ChecklistTarget);
                    writer.WriteLine(checklistGoal.ChecklistCurrent);
                    writer.WriteLine(checklistGoal.ChecklistBonus);
                }
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals()
    {
        if (File.Exists(saveFileName))
        {
            using (StreamReader reader = new StreamReader(saveFileName))
            {
                while (!reader.EndOfStream)
                {
                    string goalType = reader.ReadLine();
                    string name = reader.ReadLine();
                    int points = int.Parse(reader.ReadLine());
                    bool isComplete = bool.Parse(reader.ReadLine());

                    Goal goal = null;

                    if (goalType == nameof(SimpleGoal))
                    {
                        goal = new SimpleGoal(name, points);
                    }
                    else if (goalType == nameof(EternalGoal))
                    {
                        goal = new EternalGoal(name, points);
                    }
                    else if (goalType == nameof(ChecklistGoal))
                    {
                        int target = int.Parse(reader.ReadLine());
                        int current = int.Parse(reader.ReadLine());
                        int bonus = int.Parse(reader.ReadLine());
                        goal = new ChecklistGoal(name, points, target, bonus);
                        ((ChecklistGoal)goal).SetChecklistCurrent(current);
                    }

                    if (goal != null)
                    {
                        goal.SetComplete();
                        goals.Add(goal);
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
    }
}