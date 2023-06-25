    public class Word
{
    private string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        hidden = false;
    }

    public string GetText()
    {
        return text;
    }

    public void HideWord()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }
}

// public class Word
// {
//     private string _word = "";
//     private bool _isShown = true;

//     public Word(string word)
//     {
//         _word = word;
//     }


//     public void HideWord()
//     {
//         _isShown = false;
//     }

//     public void ShowWord()
//     {
//         _isShown = true;
//     }


//     public void Display()
//     {
//         if(_isShown == true){

//         Console.WriteLine($"Show the word: {_word}");
//         }
//         else{
//             Console.WriteLine("_____");
//         }
        
//     }






// }