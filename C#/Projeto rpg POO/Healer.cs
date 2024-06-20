public class Healer : Character
{
    public Healer(string name, int hp, int level, int mp)
        : base(name, hp, level, mp)
    {
        Class = "Healer";
    }

    public void Heal()
    {
        Console.WriteLine($"{Name} heals the party!");
    }
}