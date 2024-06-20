public class Warrior : Character
{
    public Warrior(string name, int hp, int level, int mp)
        : base(name, hp, level, mp)
    {
        Class = "Warrior";
    }

    public void Attack()
    {
        Console.WriteLine($"{Name} attacks with a mighty sword!");
    }
}