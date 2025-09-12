
Warrior warriorA = new Warrior("Ragnar", 50);
Warrior warriorB = new Warrior("Lagertha", 50);
Thread.Sleep(2000);
Console.WriteLine($"The two warriors {warriorA.Name} and {warriorB.Name} gets ready to battle!!");
Thread.Sleep(1000);
Console.WriteLine("3");
Thread.Sleep(1000);
Console.WriteLine("2");
Thread.Sleep(1000);
Console.WriteLine("1");
Thread.Sleep(1000);
Console.WriteLine("FIGHT");
Console.WriteLine("------------------------------------------------");
Thread.Sleep(1000);

int tempDmg = 0;
int i = 1;
bool someoneIsDead = false;

while (someoneIsDead == false)
{
    Console.WriteLine($"ROUND {i}");
    Thread.Sleep(1000);

    // warrior A towards B
    Console.WriteLine($"{warriorA.Name} attacks {warriorB.Name}!!!");
    tempDmg = warriorA.DealDamage();
    warriorB.Damagetaken(tempDmg);
    Thread.Sleep(1000);

    Console.WriteLine($"{warriorB.Name} takes {tempDmg}dmg. He now has {warriorB.Hp}hp\n");
    Thread.Sleep(2000);

    // warrior B towards A
    Console.WriteLine($"{warriorB.Name} attacks {warriorA.Name}!!!");
    tempDmg = warriorB.DealDamage();
    warriorA.Damagetaken(tempDmg);
    Thread.Sleep(1000);

    Console.WriteLine($"{warriorA.Name} takes {tempDmg}dmg. He now has {warriorA.Hp}hp");
    //Console.WriteLine($"The state of dead for warrior A {warriorA.Dead} and the state of dead for warriorB {warriorB.Dead}");

    someoneIsDead = ((warriorA.Dead == true) || (warriorB.Dead == true)) ? true : false;
    i++;

    Console.WriteLine("\n\n");
    Thread.Sleep(2500);
}
string winner = (warriorA.Dead == false) ? warriorA.Name : warriorB.Name;
Console.WriteLine($"\n----------------*DINGDINGDING*---------------");
Console.WriteLine($"The fight is over the winner is {winner}");
Thread.Sleep(3000);

