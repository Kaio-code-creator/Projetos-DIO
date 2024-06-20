public class Archer : Character
{
    public Archer(string name, int hp, int level, int mp)
        : base(name, hp, level, mp)
    {
        Class = "Archer";
    }

    public void ShootArrow()
    {
        Console.WriteLine($"{Name} shoots an arrow with precision!");
    }
}