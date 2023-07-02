class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 60)
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000);

        Console.WriteLine("Start listing items:");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            count++;
        }
        Console.WriteLine($"Number of items listed: {count}");
    }
}


// class ListingActivity : Activity
// {
//     private string[] prompts = {
//         "Who are people that you appreciate?",
//         "What are personal strengths of yours?",
//         "Who are people that you have helped this week?",
//         "When have you felt the Holy Ghost this month?",
//         "Who are some of your personal heroes?"
//     };

//         public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
//     {
//     }

//     protected override void PerformActivity()
//     {
//         Random random = new Random();
//         string prompt = prompts[random.Next(prompts.Length)];
//         Console.WriteLine(prompt);
//         Pause(3);
//         Console.WriteLine("Start listing items:");
//         int count = 0;
//         DateTime endTime = DateTime.Now.AddSeconds(_duration);
//         while (DateTime.Now < endTime)
//         {
//             string item = Console.ReadLine();
//             count++;
//         }
//         Console.WriteLine($"Number of items listed: {count}");
//     }
// }
