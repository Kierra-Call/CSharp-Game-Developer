

class Enemy
{
    public string Name { get; set; }

    public int Health { get; set; }

    public List<Attack> AttackList { get; set; } = new List<Attack>();

    public Enemy(string name, int health, List<Attack> attackList)
    {
        Name = name;
        Health = health;
        AttackList = attackList;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("----Start----");
        Console.WriteLine($"Enemy Name: {Name}");
        Console.WriteLine($"Enemy Health: {Health}");

        for (int idx = 0; idx < AttackList.Count; idx ++)
        {
            Console.WriteLine($"Enemy Attack {idx}: {AttackList[idx].Name}");
        }
    }

    public Attack RandomAttack() //Attack is here because that is what it is returning in the method
    {
    Random rand = new Random();
    int randomNumber = rand.Next(0,AttackList.Count);
        Console.WriteLine($"Random Attack Chosen: {AttackList[randomNumber].Name}");
        return AttackList[randomNumber];
    }

    public void AddAttack(string name, int damageAmount)
    {
        Attack NewAttack = new Attack(name, damageAmount);
        AttackList.Add(NewAttack);
    }

    // Inside of the Enemy class
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.Health -= ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }


}