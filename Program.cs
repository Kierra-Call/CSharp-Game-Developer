// Attack FireArrow = new Attack("Fire Arrow", 150);
// Attack FrostArrow = new Attack("Frost Arrow", 150);
// Attack ExplosionArrow = new Attack("Explosion Arrow", 250);
// Attack PoisonArrow = new Attack("Poison Arrow", 50);

using System.Net.Http.Headers;

List<Attack> kevinList = new List<Attack>();
List<Attack> richardList = new List<Attack>();
List<Attack> williamList = new List<Attack>();

Ranged Kevin = new Ranged("Kevin", kevinList);
Melee Richard = new Melee("Richard", richardList);
Mage William = new Mage("William", williamList);

Kevin.AddAttack("Shoot an Arrow", 20);
Kevin.AddAttack("Throw a Knife", 15);

Richard.AddAttack("Punch", 20);
Richard.AddAttack("Kick", 15);
Richard.AddAttack("Tackle", 25);

William.AddAttack("Fireball", 25);
William.AddAttack("Lightning Bolt", 20);
William.AddAttack("Staff Strike", 10);

Kevin.ShowInfo();
Richard.ShowInfo();
William.ShowInfo();


// Console.WriteLine(kevinList.Count);
Richard.PerformAttack(Kevin, richardList[1]);
Richard.Rage(William);
Kevin.PerformAttack(Richard, kevinList[0]);
Kevin.Dash();
Kevin.PerformAttack(Richard, kevinList[0]);
William.PerformAttack(Richard, williamList[0]);
William.Heal(Kevin);
William.Heal(William);




// Ranged.ShowInfo();
// Ranged.RandomAttack();
// Ranged.RandomAttack();
// Ranged.AddAttack("Lightning Arrow", 100);
// Ranged.AddAttack("Frost Arrow", 50);
// Attack randomAttack = Ranged.RandomAttack();
// Ranged.ShowInfo();

// Ranged.PerformAttack(Melee, randomAttack);

// Melee.AddAttack("Punch", 20);
// Melee.AddAttack("Kick", 15);
// Melee.AddAttack("Tackle", 25);