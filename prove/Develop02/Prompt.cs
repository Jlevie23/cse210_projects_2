using System;

public class Prompt
{

    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List<string>();

    public Prompt()
    {
        _prompts.Add("How was your day?");
        _prompts.Add("What was your favorite thing about today?");
        _prompts.Add("How did you respond to adversity today?");
        _prompts.Add("If you could change one thing about today, what would it be?");

        // Console.WriteLine(_prompts.Count);
    }


    public string GetRandomPrompt()
    {
        var random = new Random();
        var rnum = random.Next(0,_prompts.Count);
        return _prompts[rnum];
    }



}