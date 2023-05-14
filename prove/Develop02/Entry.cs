public class Entry 
{
    private string response = "";


    public void CreateEntry()
    {
        Prompt prompt = new Prompt();
        string p = prompt.GetRandomPrompt();
        Console.WriteLine(p);
        response = Console.ReadLine();
    }

}