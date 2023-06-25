abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    protected Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
        duration = 0;
    }

    protected abstract void PerformActivity();

    public void Start()
    {
        Console.WriteLine($"----- {name} Activity -----");
        Console.WriteLine(description);
        SetDuration();
        Console.WriteLine("Get ready to begin...");
        Pause(3);
        PerformActivity();
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {name} activity for {duration} seconds.");
        Pause(3);
    }

    protected void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
    }
}