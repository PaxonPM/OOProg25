using RolePlayV23;

CharacterGroup redTeam = new CharacterGroup("Team Red");
redTeam.AddCharacter(new Character("Angor", 100, 15, 25));
redTeam.AddCharacter(new Character("Zurin", 85, 18, 30));
redTeam.AddCharacter(new Defender("DefenderRed", 60, 12, 44));
redTeam.AddCharacter(new Damager("DamagerRed", 76, 14, 42));


CharacterGroup greenTeam = new CharacterGroup("Team Green");
greenTeam.AddCharacter(new Character("Baldur", 120, 12, 18));
greenTeam.AddCharacter(new Character("Eliza", 80, 20, 35));
greenTeam.AddCharacter(new Defender("DefenderGreen", 60, 12, 44));
greenTeam.AddCharacter(new Damager("DamagerGreen", 76, 14, 42));
BattleHandler.DoBattle(redTeam, greenTeam);
