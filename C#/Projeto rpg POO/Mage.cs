public class Mage : Character
{
    public Mage(string name, int hp, int level, int mp)
        : base(name, hp, level, mp)
    {
        Class = "Mage";
    }

    public void CastSpell()
    {
        Console.WriteLine($"{Name} casts a powerful spell!");
    }
}