﻿
Warrior warriorA = new Warrior("Ragnar");
Warrior warriorB = new Warrior("Lagertha");

Console.WriteLine("Before calls of LevelUp()");
Console.WriteLine($"Warrior A is named {warriorA.Name}, " +
                  $"and is Level {warriorA.Level}");
Console.WriteLine($"Warrior B is named {warriorB.Name}, " +
                  $"and is Level {warriorB.Level}");
Console.WriteLine();

warriorA.LevelUp();
warriorB.LevelUp();
warriorB.LevelUp();
warriorB.LevelUp();

Console.WriteLine("After calls of LevelUp()");
Console.WriteLine($"Warrior A is named {warriorA.Name}, " +
                  $"and is Level {warriorA.Level}");
Console.WriteLine($"Warrior B is named {warriorB.Name}, " +
                  $"and is Level {warriorB.Level}");
Console.WriteLine();
