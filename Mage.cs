class Mage : Enemy
{
    
    //Constructor
    public Mage(string name, List<Attack> attackList, int health = 80) : base (name, health, attackList)
    {

    }

    public void Heal(Enemy target)
    {
        target.Health += 40;
        Console.WriteLine($"{Name} has healed {target.Name} for 40, {target.Name}'s health is now {target.Health}");
    }

}