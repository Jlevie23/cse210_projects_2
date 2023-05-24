public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display(){
        foreach(Entry entry in _entries) {
            Console.WriteLine($"{entry._date}, {entry._prompt}, {entry._response}");
        }
    }
}

   