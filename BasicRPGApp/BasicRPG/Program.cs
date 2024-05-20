using System;
using System.Reflection.PortableExecutable;
using BasicRPG;

Unit player = new(1, "Gerald", 100, 0, 10, 50, 20, 0, 0);
Unit goblin = new(4, "Wandering Imp", 155, 0, 13, 10, 5, 0, 0);
Random random = new();

Console.WriteLine("It is time for you, " + player.NameOfUnit + ". Go and fight for your village, for it is under attack!\n");


while (!player.IsDead && !goblin.IsDead)
{
    Console.WriteLine(player.NameOfUnit + " Level = " + player.UnitLevel + " - HP = " + player.HP + " - ExP = " + player.Experience + " - Mana = " + player.CurMagic + " |  | " + goblin.NameOfUnit + " - Level = " + goblin.UnitLevel + " - HP = " + goblin.HP + " --\n");

    Console.WriteLine("Your turn! What will you do?");
    string? selection = Convert.ToString(Console.ReadLine());


    if (selection == "a")
    {
        player.UnitAttack(goblin);
        player.GainExp(10, 50);
    }
    else if (selection == "a" && player.MaxHealth < 40)
        player.Heal();


    if (selection == "h" && player.HP == player.MaxHealth && selection != "m")
        Console.WriteLine(player.NameOfUnit + " is already at full health.");
    else if (selection == "h")
        player.Heal();


    if (selection == "m" && player.CurMagic >= 5 && selection != "a")
    {
        Console.WriteLine(player.NameOfUnit + " is casting a spell...\n");
        player.CastSpell(goblin);
    }
    else if (selection == "m" && player.CurMagic == 0)
        Console.WriteLine("You have " + player.CurMagic + " magic energy. Use Replenish to restore some magic.");

    if (selection == "r")
        player.Replenish(15);

    if (player.IsDead)
    {
        Console.WriteLine(player.NameOfPlayer + " has been slained!");
        break;
    }
    else if (goblin.IsDead)
    {
        Console.WriteLine(goblin.NameOfPlayer + " has been slained!");
        break;
    }

        Console.WriteLine("Enemy's turn!\n");

        int rand = random.Next(0, 2);

    if (rand == 0)
    {
        goblin.UnitAttack(player);
    }
    else if (rand == 1 && goblin.CurrentHP < 30)
    {
        goblin.AttackDamage(30);
        goblin.Heal();
    }

    List<int> level = new() { 200, 500, 900, 1400, 2000, 2600, 3200, 3500, 4000, 4200 };

    while (player.UnitLevel <= level.Count && player.Experience >= level[player.UnitLevel - 1])
    {
        player.LevelUp();
    }
}