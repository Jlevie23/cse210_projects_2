// Entry TodayEntry = new Entry();

// TodayEntry.CreateEntry();

// TodayEntry.DisplayEntry();

Journal journal = new Journal();

Console.WriteLine("Welcome to the Journal Program. Please choose one of the following: ");

while(true){

    Console.WriteLine("Type [1] for entry, type [2] for Display, type [3] for Load, type [4] for Save, or type [5] to quit.");
    string input = Console.ReadLine();
    if(input == "1"){
        Entry entry = new Entry();
        entry.CreateEntry();
        journal._entries.Add(entry);

    }
    if(input == "2"){
        journal.Display();
    }
}