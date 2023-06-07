public class Book : Loanable
{
    private string _title;
    private string _isbn;
    private string _upc;

    public Book(string title, string isbn, string upc) //: base(title)
    {
        _title = title;
        _isbn = isbn;
        _upc = upc;
    }

    // public Book() : base()
    // {

    // }

    public void ShowBookDetails()
    {
        Console.WriteLine($"{_title} : {_isbn} : {_upc} : {_isCheckedIn}");
    }

    public override void Display()
    {
        base.Display();
        ShowBookDetails();
    }

    
}