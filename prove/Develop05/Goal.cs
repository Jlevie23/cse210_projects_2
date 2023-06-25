abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; private set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false;
    }

    public abstract void RecordEvent();

    protected void SetComplete()
    {
        IsComplete = true;
    }

    public virtual void DisplayProgress()
    {
        Console.WriteLine($"Goal: {Name}");
        Console.WriteLine($"Points: {Points}");
        Console.WriteLine($"Status: {(IsComplete ? "[X] Completed" : "[ ] Incomplete")}");
    }
}