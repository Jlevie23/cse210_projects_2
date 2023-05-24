public class Entry 
{
    public string _response;

    public string _prompt;

    public string _date;



    public void CreateEntry()
    {
        Prompt prompt = new Prompt();
        _prompt = prompt.GetRandomPrompt();
        Console.WriteLine(_prompt);
        Console.WriteLine("Please enter your entry here: ");
        _response = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

   

    public string DisplayEntry()
    {
        return $"{_response}";
    }

}