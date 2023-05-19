public class Player
{
    private string _name;
    private string _position = "";
    private int _jersey;

    // public void InputPlayerInfo(string name, string postion)
    // {

    // }
    public Player(string name, int jersey)
    {
        _name = name;
        _jersey = jersey;
    }

    public Player(string name, int jersey, string position)
    {
        _name = name;
        _jersey = jersey;
        _position = position;
    }

    public void SetPosition(string position)
    {
        _position = position;
    }

    public void DisplayPlayer(string name, int jersey, string position)
    {
        
    }

    public string Display()
    {
        return $"{_name}, {_jersey}, {_position}";
    }

}