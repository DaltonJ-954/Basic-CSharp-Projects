using System;
using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System.Collections;
using BasicRPG;
using System.ComponentModel;

// Method to randomly pick a unit between specters and necrophages
static Enemy RandomlyPickUnit(Random random, Enemy specters, Enemy necrophages, Enemy ogroids)
{
    // Generates a random number 0 or 1
    int randomValue = random.Next(3);
    // Returns specters if randomValue is 0, otherwise returns necrophages
    if (randomValue == 2)
    {
        return ogroids;
    }
    return randomValue == 0 ? specters : necrophages;
}

// Initialize units
Unit player = new(1, "Geralt of Rivia", 120, 0, 10, 50, 20, 0, 0, 0);
Enemy specters = new(4, "Plague Maiden", 120, 0, 20, 20, 10, 0, 0, 0);
Enemy necrophages = new(1, "Rotfiend", 200, 0, 8, 30, 20, 0, 0, 0);
Enemy ogroids = new(8, "Cloud Giant", 350, 0, 21, 20, 15, 0, 0, 0);


//Item silver = new(1, "Silver", 75, 1.28, "Nuggets of silver with a moderate value. Can be sold to merchants, or used to craft items.", 3);
//Item gold = new(2, "Gold", 125, 1.08, "A bundle of gold nuggets with a high value. Can be sold to merchants, or used to craft items.", 2);
//Item titanium = new(3, "Titanium", 200, 1.78, "A nuggets of a very rare mineral of extreme vale that is high on merchants list. Can be used " +
//    "to craft some rare amulets that are fused mystical abilities!", 1);


//Weapon feline = new(1, "Feline Sword", 515, 6.38, "Feline Steel Sword - Mastercrafted is a Steel Sword in The Witcher 3: Wild Hunt. " +
//    "Steel Swords form one half of Geralt's primary Weapons which he uses to deal damage to Enemies in combat.", 1, 43, 1.23, "Sword");
//Weapon elvenBow = new(2, "Elven Crossbow", 420, 4.01, "Part of an elite set. Master tier with high attack power. Limited availability. High weight and buying price.", 
//    1, 32, 1.03, "Crossbow");
//Weapon cleaver = new(3, "Cleaver Hood", 340, 2.81, "Players can loot the Cleaver Hood from the Therazane earth elemental enemy during the contract quest, " +
//    "\"Doors Slamming Shut\". Sadly, it's fairly underwhelming and so is definitely not an endgame sword.", 1, 27, 4.02, "Sword");


//Inventory inventory = new();
 
// Initialize random number generator
Random random = new();

// Subscribe to events for unlocking achievements and special abilities
player.AchievementUnlocked += OnAchievementUnlocked;
player.SpecialUnlocked += CleaverSword;
player.CleaverSwordUnleashed += CleaverWrath;

// Display introduction message
Console.WriteLine("It is time for you, " + player.NameOfUnit + ". Go and fight for your purpose of vanquishing evil! For the world and its people are under grave danger!\n");

// ----------------------------------------------------------------------

// Event handler for unlocking achievements
static void OnAchievementUnlocked(int exp)
{
    Console.WriteLine($"Congratulations on your achievement! Your total experience gained is now {exp}!\n");
}


// Event handler for unlocking special ability
static void CleaverSword(int spec)
{
    Console.WriteLine($"Your Cleaver sword has gathered the energy from {spec} souls you've defeated!\n");
}


static void CleaverWrath(Enemy enemy, int att)
{
    Console.WriteLine($"The ether souls from dead enemies consume the Cleaver sword and unleashes {att} points of damage to its foe!\n");
}


// Select a random enemy unit
Enemy selectedUnit = RandomlyPickUnit(random, specters, necrophages, ogroids);

// Display message about the enemy unit approaching
Console.WriteLine($"You are being approached by the {selectedUnit.NameOfPlayer}. Prepare for battle!\n");


// Battle loop until either player or enemy unit is dead
while (!player.IsDead && !selectedUnit.IsDead)
{
    // Display player and enemy unit stats
    Console.WriteLine(player.NameOfUnit + " | Level = " + player.UnitLevel + " | HP = " + player.HP + " | ExP = " + player.Experience + " | Mana = " + player.CurMagic + " | Special Meter = " + player.SpecialAbility + " | Soul Orbs = " + player.SoulOrbs + " |  | " + selectedUnit.NameOfUnit + " | Level = " + selectedUnit.UnitLevel + " | HP = " + selectedUnit.HP + " --\n");

    // Prompt player for action
    Console.WriteLine("-- Attack the enemy! --");
    string? selection = Convert.ToString(Console.ReadLine());

    // Player attacks the enemy unit

    if (selection == "a")
    {
        player.PlayerAttack(selectedUnit);
        await player.GainExp(10, 50); // Gain experience points
        await player.SuperGauge(15, 30); // Gain ether points

        // Check if player's max health is less than 40 after the attack
        if (player.MaxHealth < 40)
        {
            player.AttackDamage(20);
            player.Heal(); // Perform healing action
        }
    }

    // Player uses special attack if there are enough soul orbs

    if (selection == "s" && player.SoulOrbs > 0)
    {
        await player.SpecialAttack(selectedUnit);
        await player.GainExp(30, 40);

    }
    else if (selection == "s" && player.SoulOrbs <= 0)
    {
        Console.WriteLine($"You have {player.SoulOrbs} soul orbs. Continue killing enemies and collect a 100 souls or more to acquire soul orbs.\n");
        await player.GainExp(5, 10);
    }

    // HEAL code
    // Check if the player selected "h" and if the player's health (HP) is already at the maximum (MaxHealth),
    // and also confirm that the selection is not "m" 
    if (selection == "h" && player.HP == player.MaxHealth && selection != "m")
    {
        // If all conditions are true, output a message indicating that the player is already at full health.
        Console.WriteLine(player.NameOfUnit + " is already at full health.");
    }
    else if (selection == "h")
    {
        // If the selection is "h" but the player is not at full health, call the Heal method on the player to restore health.
        player.Heal();
        player.MagicUse(4, 8);
    }

    // Player casts a magic spell if there are enough magic points

    if (selection == "m" && player.CurMagic >= 5 && selection != "a")
    {
        Console.WriteLine(player.NameOfUnit + " is casting a spell...\n");

        await Task.Delay(1000);
        player.CastSpell(selectedUnit);
    }
    else if (selection == "m" && player.CurMagic == 0)
    {
        Console.WriteLine("You have " + player.CurMagic + " magic energy. Use Replenish to restore magic.\n");
    }

    // Player replenishes resources

    if (selection == "r")
    {
        player.ReplenishVial(15);
    }

    // Check if the player is dead

    if (player.CurrentHP == 0)
    {
        Console.WriteLine(player.NameOfPlayer + " has been slain!\n");
        break;
    }
    // Check if the enemy unit is dead
    else if (selectedUnit.CurrentHP <= 0)
    {
        Console.WriteLine(selectedUnit.NameOfPlayer + " has been slain!\n");

        selectedUnit.LootDrop(selectedUnit);
        break;
    }

    // Declares enemy's turn
    Console.WriteLine("** It's the " + selectedUnit.NameOfPlayer + "'s turn! **\n");

    // Generate a random action for the enemy unit
    int rand = random.Next(0, 4);

    // Enemy unit attacks the player
    if (rand == 0)
    {
        selectedUnit.EnemyAttack(player);
    }
    // Enemy unit heals itself
    else if (rand == 1)
    {
        Console.Write("The enemy is meditating... \n"); await Task.Delay(1000); selectedUnit.Heal();
    }
    // Enemy unit performs a special action if its HP is low
    else if (rand == 2)
    {
        selectedUnit.AttackDamage(3);
        selectedUnit.EnemyAttack(player);
    }
    else if(rand == 3)
    {
        selectedUnit.DarkMagic(player);
    }
}