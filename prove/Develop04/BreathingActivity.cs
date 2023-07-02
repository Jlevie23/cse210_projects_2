class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 60)
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Start breathing...");
        int secondsElapsed = 0;
        while (secondsElapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000);
            secondsElapsed += 4;
        }
    }
}

// class BreathingActivity : Activity
// {
//     public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
//     {
//     }

//     protected override void PerformActivity()
//     {
//         for (int i = 0; i < duration; i++)
//         {
//             Console.WriteLine("Breathe in...");
//             Pause(3);
//             Console.WriteLine("Breathe out...");
//             Pause(3);
//         }
//     }
// }