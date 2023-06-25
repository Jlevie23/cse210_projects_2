class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You've made progress on the eternal goal: {Name}");
    }
}