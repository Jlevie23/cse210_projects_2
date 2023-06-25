class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(string referenceString, string text)
    {
        reference = new Reference(referenceString);
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetReference()
    {
        return reference.GetFormattedReference();
    }

    public string GetText()
    {
        return string.Join(" ", words.Select(word => word.GetText()));
    }

    public List<Word> GetWords()
    {
        return words;
    }

    public string GetHiddenText()
    {
        return string.Join(" ", words.Select(word => word.IsHidden() ? new string('*', word.GetText().Length) : word.GetText()));
    }
}

// public class Scripture
// {
//     List<string> _words = new List<string>();
//     // Reference ref = new Reference();

//     public void HideRandomWord(){
//         // are all words hidden? if not hide more
//     }

//     public void DisplayRef(){

//     }

//     public void ConvertStringsToWords(string text){
        
//         // split words into an array

//         // for each string create a new word

//         // save the word into the List<Word> _words

//     }

//     public void IsVerseDone(){
        
//     }



// }