using System;

class Program
{
    static void Main(string[] args)
    {
        Warrior warrior = new Warrior("Thorin", 150, 10, 50);
        Mage mage = new Mage("Gandalf", 100, 15, 200);
        Archer archer = new Archer("Legolas", 120, 12, 80);
        Healer healer = new Healer("Elrond", 110, 13, 150);

        warrior.DisplayStatus();
        warrior.Attack();

        mage.DisplayStatus();
        mage.CastSpell();

        archer.DisplayStatus();
        archer.ShootArrow();

        healer.DisplayStatus();
        healer.Heal();
    }
}