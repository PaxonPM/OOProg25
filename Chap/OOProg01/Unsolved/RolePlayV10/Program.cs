
Warrior warriorA = new Warrior("Ragnar");
Warrior warriorB = new Warrior("Lagertha");

Console.WriteLine($"Warrior A is named {warriorA.Name}");
Console.WriteLine($"Warrior B is named {warriorB.Name}");

Console.WriteLine("------------------------------------");
Console.WriteLine($"\nThe Current Level of the warriorA is: {warriorA.Level}");
warriorA.LevelIncrease();
warriorA.LevelIncrease();
warriorA.LevelIncrease();
warriorA.LevelIncrease();
warriorA.LevelIncrease();
Console.WriteLine($"After increase the level of the warriorA is: {warriorA.Level}");
