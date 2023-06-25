class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points)
    {
    }

    public override void RecordEvent()
    {
        SetComplete();
        Console.WriteLine($"Congratulations! You have completed the goal: {Name}");
    }
}