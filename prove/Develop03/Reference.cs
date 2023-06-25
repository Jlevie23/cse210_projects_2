 class Reference
{
    private string book;
    private int chapter;
    private int verseStart;
    private int verseEnd;
    private bool isVerseRange;

    public Reference(string referenceString)
    {
        string[] parts = referenceString.Split(':');
        book = parts[0];

        if (parts[1].Contains('-'))
        {
            isVerseRange = true;
            string[] verses = parts[1].Split('-');
            verseStart = int.Parse(verses[0]);
            verseEnd = int.Parse(verses[1]);
        }
        else
        {
            isVerseRange = false;
            verseStart = int.Parse(parts[1]);
        }
    }

    public string GetFormattedReference()
    {
        if (isVerseRange)
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        else
            return $"{book} {chapter}:{verseStart}";
    }
}

// public class Reference
// {
//     private string _book = "";
//     private int startVerse = 0;
//     private int endVerse = 0;
//     private int chapter = 0;

//     public Reference(){

//     }


//     public void DisplayRef()
//     {
//         // logic that deals with startVerse and endVerse
//     }
// }