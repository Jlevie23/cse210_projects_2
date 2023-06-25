class ChecklistGoal : Goal
{
    private int target;
    private int current;
    private int bonus;

    public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)
    {
        this.target = target;
        this.current = 0;
        this.bonus = bonus;
    }

    public override void RecordEvent()
    {
        current++;
        if (current >= target)
        {
            SetComplete();
            Points += bonus;
            Console.WriteLine($"Congratulations! You have completed the checklist goal: {Name}");
            Console.WriteLine($"You earned a bonus of {bonus} points!");
        }
        else
        {
            Console.WriteLine($"You've made progress on the checklist goal: {Name}");
            Console.WriteLine($"Progress: {current}/{target} times");
        }
    }

    public override void DisplayProgress()
    {
        base.DisplayProgress();
        Console.WriteLine($"Progress: {current}/{target} times");
    }
}