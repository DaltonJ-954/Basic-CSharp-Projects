using System;
using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System.Collections;
using BasicRPG;
using System.ComponentModel;


public class Program
{
    static async Task Main(string[] args)
    {
        static Enemy RandomlyPickUnit(Random random, Enemy specters, Enemy necrophages, Enemy ogroids, Enemy necrophages2)
        {
            int randomValue = random.Next(4); // generates 0–3

            switch (randomValue)
            {
                case 0:
                    return specters;
                case 1:
                    return necrophages;
                case 2:
                    return ogroids;
                case 3:
                    return necrophages2;
                default:
                    return necrophages; // fallback (should never happen)
            }
        }


        // Initialize units
        Unit player = new(1, "Geralt", 120, 0, 10, 50, 20, 0, 0, 0);
        WitcherAttack sword = new("The Witcher", AttackType.Sword);
        WitcherAttack sign = new("The Witcher", AttackType.Sign);
        WitcherAttack crossbow = new("The Witcher", AttackType.Crossbow);
        WitcherAttack bomb = new("The Witcher", AttackType.Bomb);

        Enemy specters = new(4, "Plague Maiden", 120, 0, 20, 20, 10, 0, 0, 0);
        Enemy necrophages = new(1, "Rotfiend", 200, 0, 8, 30, 20, 0, 0, 0);
        Enemy ogroids = new(8, "Cloud Giant", 350, 0, 21, 20, 15, 0, 0, 0);
        Enemy necrophages2 = new(4, "Dark Hag", 315, 0, 25, 25, 25, 0, 0, 0);


        // Initialize random number generator
        Random random = new();

        // Subscribe to events for unlocking achievements and special abilities
        player.AchievementUnlocked += OnAchievementUnlocked;
        player.SpecialUnlocked += CleaverSword;
        player.SwordUnleashed += CleaverWrath;


        // Display introduction message
        Console.WriteLine($"It is time for you, {player.NameOfPlayer}. Go and fight for your purpose of vanquishing evil! For the world and its people are under grave danger!\n");

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
            Console.WriteLine($"The ether souls from dead enemies consume the Cleaver sword and unleashes {att} points of damage to {enemy.NameOfUnit}!\n");
        }


        // Select a random enemy unit
        Enemy selectedUnit = RandomlyPickUnit(random, specters, necrophages, ogroids, necrophages2);

        // Display message about the enemy unit approaching
        Console.WriteLine($"You are being approached by the {selectedUnit.NameOfUnit}. Prepare for battle!\n");


        // Battle loop until either player or enemy unit is dead
        while (!player.IsDead && !selectedUnit.IsDead)
        {
            // Display player and enemy unit stats
            Console.WriteLine($"{player.NameOfPlayer} | Level = {player.UnitLevel} | HP = {player.HP} | Exp = {player.Experience} | Mana = {player.CurMagic} | Special Meter = {player.SpecialAbility} | Soul Orbs = {player.SoulOrbs} |\n");
            Console.WriteLine($"{selectedUnit.NameOfUnit} | Level = {selectedUnit.UnitLevel} | HP = {selectedUnit.HP} | Mana = {selectedUnit.CurMagic} |\n");
            // Prompt player for action
            Console.WriteLine("-- Attack the enemy! --");
            string? selection = Convert.ToString(Console.ReadLine());

            // Player attacks the enemy unit

            if (selection == "a")
            {
                sword.PerformAttack(selectedUnit);
                await player.GainExp(10, 50); // Gain experience points
                await player.SuperGauge(15, 30); // Gain ether points

                // Check if player's max health is less than 40 after the attack
                if (selection == "a" && player.CurrentHP < 50)
                {
                    sword.PerformAttack(selectedUnit);
                    await player.GainExp(30, 40);
                    player.Heal(); // Perform healing action
                }
            }

            if (selection == "b")
            {
                bomb.PerformAttack(selectedUnit);
            }

            if (selection == "sh")
            {
                sign.PerformAttack(selectedUnit);
            }

            if (selection == "c")
            {
                crossbow.PerformAttack(selectedUnit);
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

            // If the player selects "h" (heal) and has at least 4 magic points (and the selection isn’t "m"),
            // the player performs a healing action that consumes magic (4 to 6 points).
            // Otherwise, if the player tries to heal with less than 4 magic points,
            // display a message reminding them to replenish their magic energy.

            if (selection == "h")
            {
                player.Heal();
                player.ManaUse(4, 6);
            }
            else if (selection == "h" && player.CurMagic < 4)
            {
                Console.WriteLine($"You have {player.CurMagic} magic energy. Use Replenish to restore magic.\n");
            }



            // Player casts a magic spell if there are enough magic points

            if (selection == "m")
            {
                Console.WriteLine($"{player.NameOfPlayer} is gathering the energy for his spell attack...\n");

                await Task.Delay(1000);
                player.ManaSpell(selectedUnit);
            }
            else if (selection == "m" && player.CurMagic <= 3)
            {
                Console.WriteLine($"You have {player.CurMagic} magic energy. Use Replenish to restore magic.\n");
                return;
            }

            // Player replenishes resources

            if (selection == "r")
            {
                player.Replenish();
            }

            // Check if the player is dead

            if (player.CurrentHP <= 0)
            {
                Console.WriteLine($"{player.NameOfPlayer} has perished!!\n");
                break;
            }

            // Check if the enemy unit is dead

            if (selectedUnit.CurrentHP <= 0)
            {
                Console.WriteLine(selectedUnit.NameOfUnit + " has been slain!\n");

                selectedUnit.LootDrop(selectedUnit);
                break;
            }


            // Declares enemy's turn
            // ------------------------------------------------------ //


            Console.WriteLine($"** It's the {selectedUnit.NameOfUnit}'s turn! **\n");

            // Generate a random action for the enemy unit
            int rand = random.Next(0, 5);

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
            else if (rand == 3)
            {
                Console.WriteLine($"{selectedUnit.NameOfUnit} is casting a spell...\n");

                await Task.Delay(1000);
                selectedUnit.DarkMagic(player);

            }
            else if (selectedUnit.CurMagic <= 3)
            {
                Console.WriteLine($"You have {selectedUnit.CurMagic} magic energy. Use Dark Mist to gain magic.\n");
                selectedUnit.ManaRestore();
            }
        }
    }
}
