using System;
using System.Reflection.PortableExecutable;
using BasicRPG;


Unit player = new(1, "Geralt of Rivia", 100, 0, 10, 50, 20, 0, 0);
Unit goblin = new(4, "Royal Wyvern", 200, 0, 24, 20, 5, 0, 0);
Random random = new();

player.AchievementUnlocked += OnAchievementUnlocked;

Console.WriteLine("It is time for you, " + player.NameOfUnit + ". Go and fight for your the purpose of vanquishing evil, for the world and its people are under attack!\n");

static void OnAchievementUnlocked()
{
    Console.WriteLine("Congratulations! Achievement unlocked for gaining more experience!.\n");
    // Output a message to the console indicating the player's new level and a progress update
    Console.WriteLine("You have grown stronger and reached a new level!\n");
}

while (!player.IsDead && !goblin.IsDead)
{
    Console.WriteLine(player.NameOfUnit + " Level = " + player.UnitLevel + " - HP = " + player.HP + " - ExP = " + player.Experience + " - Mana = " + player.CurMagic + " |  | " + goblin.NameOfUnit + " - Level = " + goblin.UnitLevel + " - HP = " + goblin.HP + " --\n");

    Console.WriteLine("Your turn! What will you do?");
    string? selection = Convert.ToString(Console.ReadLine());


    if (selection == "a")
    {
        // Player attacks the goblin unit
        player.UnitAttack(goblin);
        // Player gains experience points (10 current exp, 50 total required exp)
        await player.GainExp(10, 50);
        // Check if player's max health is less than 40 after the attack
        if (player.MaxHealth < 40)
        {
            // Player performs a healing action
            player.Heal();
        }
    }


    // Check if the player selected "h" and if the player's health (HP) is already at the maximum (MaxHealth),
    // and also confirm that the selection is not "m" 
    if (selection == "h" && player.HP == player.MaxHealth && selection != "m")
        // If all conditions are true, output a message indicating that the player is already at full health.
        Console.WriteLine(player.NameOfUnit + " is already at full health.");
    else if (selection == "h")
        // If the selection is "h" but the player is not at full health, call the Heal method on the player to restore health.
        player.Heal();


    // Check if the player has chosen to cast a magic spell ("m") and has at least 5 magic points, and did not choose an attack ("a")
    if (selection == "m" && player.CurMagic >= 5 && selection != "a")
    {
        // Inform the player that their unit is casting a spell
        Console.WriteLine(player.NameOfUnit + " is casting a spell...\n");
        await Task.Delay(500);

        // Call the CastSpell method on the player object, targeting the goblin
        player.CastSpell(goblin);
    }
    // If the player has chosen to cast a spell but has no magic points left
    else if (selection == "m" && player.CurMagic == 0)
    {
        // Inform the player that they have no magic energy and suggest using Replenish to restore magic
        Console.WriteLine("You have " + player.CurMagic + " magic energy. Use Replenish to restore some magic.");
    }

    // Check if the player's selection is "r" (replenish action)
    if (selection == "r")
        // Call the Replenish method on the player object, restoring 15 units of whatever resource is being replenished
        player.Replenish(15);

    // Check if the player is dead
    if (player.IsDead == true)
    {
        // Output a message indicating the player has been slain
        Console.WriteLine(player.NameOfPlayer + " has been slain!");
        // Exit the loop or method where this code is executed
        break;
    }
    // This is a repeat of the player.IsDead code, only the goblin object being the difference
    else if (goblin.IsDead == true)
    {
        Console.WriteLine(goblin.NameOfPlayer + " has been slain!");
        break;
    }


    // Output a message to indicate that it is the enemy's turn
    Console.WriteLine("Enemy's turn!\n");

    // Generate a random number, either 0 or 1
    int rand = random.Next(0, 2);

    // If the random number is 0, execute the attack on the player
    if (rand == 0)
    {
        goblin.UnitAttack(player); // Goblin attacks the player
    }
    // If the random number is 1 and the goblin's current health is less than 30, heal the goblin
    else if (rand == 1 && goblin.CurrentHP < 30)
    {
        goblin.AttackDamage(30); // Deal 30 damage (possibly to itself or to indicate some cost)
    }
    else
        goblin.Heal(); // Goblin heals itself
}