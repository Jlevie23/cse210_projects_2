using System;
using System.Threading;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        SetDuration();
        PrepareToBegin();
        PerformActivity();
        ConcludeActivity();
    }

    protected void SetDuration()
    {
        Console.Write("Enter the duration (in seconds): ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
    }

    protected void ConcludeActivity()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(3000);
    }

    protected abstract void PerformActivity();
}

// abstract class Activity
// {
//     protected string name;
//     protected string description;
//     protected int duration;

//     protected Activity(string name, string description)
//     {
//         this.name = name;
//         this.description = description;
//         duration = 0;
//     }

//     protected abstract void PerformActivity();

//     public void Start()
//     {
//         Console.WriteLine($"----- {name} Activity -----");
//         Console.WriteLine(description);
//         SetDuration();
//         Console.WriteLine("Get ready to begin...");
//         Pause(3);
//         PerformActivity();
//         Console.WriteLine("Good job!");
//         Console.WriteLine($"You have completed the {name} activity for {duration} seconds.");
//         Pause(3);
//     }

//     protected void SetDuration()
//     {
//         Console.Write("Enter the duration in seconds: ");
//         duration = Convert.ToInt32(Console.ReadLine());
//     }

//     protected void Pause(int seconds)
//     {
//         for (int i = 0; i < seconds; i++)
//         {
//             Thread.Sleep(1000);
//             Console.Write(".");
//         }
//         Console.WriteLine();
//     }
// }