class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Game!");

        Scripture scripture1 = new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");
        Scripture scripture2 = new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths.");

        List<Scripture> scriptures = new List<Scripture> { scripture1, scripture2 };

        foreach (var scripture in scriptures)
        {
            PlayScriptureGame(scripture);
        }

        Console.WriteLine("Thank you for playing the Scripture Game. Press any key to exit...");
        Console.ReadKey();
    }

    static void PlayScriptureGame(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetReference());
        Console.WriteLine(scripture.GetText());

        List<Word> words = scripture.GetWords();
        List<int> hiddenWordIndices = new List<int>();

        while (hiddenWordIndices.Count < words.Count)
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                return;

            Console.Clear();

            // Generate a random index to hide a word
            int randomIndex = GenerateRandomIndex(words.Count);

            // Check if the word at the random index is already hidden
            if (!hiddenWordIndices.Contains(randomIndex))
            {
                hiddenWordIndices.Add(randomIndex);
                words[randomIndex].HideWord();
            }

            Console.WriteLine(scripture.GetReference());
            Console.WriteLine(scripture.GetHiddenText());
        }
    }

    static int GenerateRandomIndex(int maxValue)
    {
        Random random = new Random();
        return random.Next(0, maxValue);
    }
}