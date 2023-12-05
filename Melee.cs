class Melee : Enemy
{
    public bool Enragaged { get; set; }
    
    //Constructor
    public Melee(string name, List<Attack> attackList, bool rage = false, int health = 120) : base (name, health, attackList)
    {
        Enragaged = rage;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Rage?: {Enragaged}");
    }

    public void Rage(Enemy target)
    {
        Enragaged = true;
        Console.WriteLine($"{Name} is enraged!");
        Attack randomAttack = RandomAttack();
        PerformAttack(target, randomAttack);
    }

}