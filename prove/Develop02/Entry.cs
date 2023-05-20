public class Entry 
{
    private string _response = "";


    public void CreateEntry()
    {
        Prompt prompt = new Prompt();
        string p = prompt.GetRandomPrompt();
        Console.WriteLine(p);
        _response = Console.ReadLine();
        Console.Write(_response);
    }

   

    public string DisplayEntry()
    {
        return $"{_response}";
    }

}