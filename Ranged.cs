class Ranged : Enemy
{
    public int Distance { get; set; }
    
    //Constructor
    public Ranged(string name, List<Attack> attackList, int distance = 5, int health = 80) : base (name, health, attackList)
    {
        Distance = distance;

    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Distance: {Distance}");
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Distance >= 10)
        {
            base.PerformAttack(Target, ChosenAttack);
        } else {
            Console.WriteLine("Cannot use attack, distance too close!");
        }
    }

    public void Dash()
    {
        Distance = 20;
        Console.WriteLine($"{Name} has a dashed and now has a distance of {Distance}");
    }

}