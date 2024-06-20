public abstract class Character
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Level { get; set; }
    public int MP { get; set; }
    public string Class { get; protected set; }

    public Character(string name, int hp, int level, int mp)
    {
        Name = name;
        HP = hp;
        Level = level;
        MP = mp;
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Name: {Name}, Class: {Class}, HP: {HP}, Level: {Level}, MP: {MP}");
    }
}