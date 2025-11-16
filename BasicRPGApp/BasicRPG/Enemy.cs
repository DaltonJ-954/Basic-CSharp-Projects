using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG
{
    public class Enemy : Unit
    {
        private readonly Random random = new();

        private readonly List<Item> battleItems = new()
        {
            new Item(0, "Gold coins", 15, 0.34, "Valuable coins made of gold.", 0),
            new Item(1, "Dimeritium Ore", 100, 0.3, "A rare and valuable ore used in crafting powerful weapons and armor.", 0),
            new Item(2, "Mandrake Root", 25, 0.1, "A common herb used in alchemy, known for its healing properties.", 0),
            new Item(3, "Monster Hair", 15, 0.05, "Tough, coarse hair obtained from slain monsters, used in crafting.", 0),
            new Item(4, "Infused Shard", 150, 0.2, "A shard infused with magic, often used in advanced alchemical concoctions.", 0),
            new Item(5, "Powdered Monster Tissue", 120, 0.1, "A finely ground substance from monster tissue, valuable in alchemy.", 0),
            new Item(6, "Florens", 1, 0.01, "A coin used in transactions, minted in Novigrad. Typically exchanged for crowns.", 0),
            new Item(7, "Temerian Rye", 10, 1.0, "A strong alcoholic beverage, popular in the Northern Realms.", 0),
            new Item(8, "Wolf's Bane", 40, 0.2, "A poisonous plant used in the creation of deadly potions.", 0),
            new Item(9, "a Torn Page: Archgriffin Decoction", 200, 0.01, "A torn page containing a recipe for an Archgriffin decoction.", 1),
            new Item(10, "an Empty Bottle", 2, 0.05, "A simple empty bottle, can be used to store various liquids.", 15),
            new Item(11, "Bear Fat", 8, 0.5, "A rare fat obtained from bears, used in alchemy and cooking.", 6),
            new Item(12, "the Glyph of Igni", 500, 0.1, "A magical glyph that enhances Igni sign intensity when placed in armor.", 1),
            new Item(13, "Old Goat Hide", 5, 0.3, "The tattered hide of an old goat, often sold for a small amount of coin.", 4),
            new Item(14, "Lesser Morana Runestone", 300, 0.15, "A lesser runestone that adds bleeding damage to weapons.", 2),
            new Item(15, "a Black Pearl", 600, 0.05, "A rare and valuable pearl, highly sought after in the markets.", 1),
            new Weapon(16, "The Aerondight", 1600, 14.0, "Legendary Silver Sword", 1, 55.0, 1.8, "Silver Sword"),
            new Weapon(17, "An Iris Warrior Class", 1350, 11.5, "Viper Steel Sword", 2, 45.0, 2.2, "Sword"),
            new Weapon(18, "the Toussaint Knight's Steel Sword", 1200, 10.0, "Mastercrafted Steel Sword", 2, 40.0, 1.7, "Sword"),
            new Weapon(19, "Winter's Blade", 1450, 13.0, "Hero's Relic", 1, 48.0, 2.1, "Sword"),
            new Weapon(20, "A Dwarven Axe", 1300, 12.0, "Mastercrafted Axe", 1, 52.0, 2.5, "Axe"),
            new Weapon(21, "The mystical Black Unicorn", 1400, 12.8, "Nilfgaardian Relic", 1, 50.0, 1.9, "Sword"),
            new Weapon(22, "The ancient Tor Lara", 1550, 13.5, "Elven Silver Sword", 1, 54.0, 2.0, "Silver Sword"),
            new Weapon(23, "A Feline Steel Sword", 1250, 11.0, "Cat School Steel Sword", 1, 42.0, 2.0, "Sword"),
            new Weapon(24, "A Mahakaman Battle Axe", 1500, 14.0, "Dwarven Battle Axe", 1, 60.0, 3.0, "Axe"),
            new Weapon(25, "A Griffin Silver Sword", 1400, 12.0, "Griffin School Silver Sword", 1, 50.0, 1.8, "Silver Sword"),
            new Weapon(26, "A Viper Silver Sword", 1450, 13.0, "Viper School Silver Sword", 1, 53.0, 2.0, "Silver Sword"),
            new Weapon(27, "The crafty Harpy's Talon", 950, 8.0, "Common Sword", 1, 25.0, 1.6, "Sword")
        };

        public Enemy(int unitLevel, string nameOfUnit, int maxHealth, int experience, int attack, int maxMagic, int healPower, 
            int damage, int soulOrbs, int specialAbility) :
            base(unitLevel, nameOfUnit, maxHealth, experience, attack, maxMagic, healPower, damage, soulOrbs, specialAbility)
        {
        }

        public void EnemyAttack(Unit playerUnit)
        {
            // This method is using a similar concept a the CastSpell method
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(Attack * rng);
            playerUnit.AttackDamage(randDamage);
            Console.WriteLine(NameOfUnit + " attacks Geralt and deals " + randDamage + " damage!\n");
        }

        public void DarkMist(int lowUsage, int highUsage, double healPercent)
        {
            Random random = new();
            int totalUsage = random.Next(lowUsage, highUsage);

            // Ensure magic isn't over-used
            if (CurMagic <= totalUsage)
            {
                totalUsage = CurMagic;
                CurMagic = 0;

                Console.WriteLine($"Magic: [ - {totalUsage} ]");
                Console.WriteLine("Your magic is now depleted!");

                Console.Write("Would you like to use a Replenish Vial? (y/n): ");
                string? input = Console.ReadLine();

                if (input != null && input.Trim().ToLower() == "y")
                {
                    Replenish();
                }
                else
                {
                    Console.WriteLine("You chose not to replenish your magic.");
                }
            }
            else
            {
                CurMagic -= totalUsage;
                Console.WriteLine($"Magic: [ - {totalUsage} ]");
                Console.WriteLine($"Current Magic: {CurMagic}/{MaxMagic}");
            }

            // --- Healing Logic ---
            // Calculate heal amount based on percentage of max health
            int healAmount = (int)(MaxHealth * healPercent);

            // Clamp heal so it doesn’t exceed MaxHealth
            int oldHealth = CurrentHP;
            CurrentHP = Math.Min(CurrentHP + healAmount, MaxHealth);

            int actualHealed = CurrentHP - oldHealth;

            Console.WriteLine($"Dark Mist restores {actualHealed} health!");
            Console.WriteLine($"Current Health: {CurrentHP}/{MaxHealth}");
        }


        public void DarkMagic(Unit enemyUnit)
        {
            // Generate a random number between 0.0 and 1.0
            double rng = random.NextDouble();

            // Adjust the random number to be between 0.75 and 1.25
            rng = rng / 2 + 0.75f;

            // Calculate the damage to be dealt by multiplying the unit's attack by the adjusted random number
            int randDamage = (int)(Attack * rng);

            // Inflict the calculated damage to the enemy unit
            enemyUnit.AttackDamage(randDamage);

            // Print out a message indicating the spell's effect
            Console.WriteLine(NameOfUnit + "'s dark spell inflicts " + randDamage + " damage to " + enemyUnit.NameOfPlayer + "!\n");

            // Deducts a minimum of 8 and at max 15 magic points from the unit casting the spell
            ManaUse(6, 10);
        }

        public void ManaRestore()
        {
            int replenishAmount = random.Next(10, 20); // Amount restored your current mana
            CurMagic += replenishAmount;

            if (CurMagic > MaxMagic)
                CurMagic = MaxMagic;

            Console.WriteLine($"You have used a Mana Restore! Magic restored by {replenishAmount}.");
            Console.WriteLine($"Current Magic: {CurMagic}/{MaxMagic}");
        }

        public void LootDrop(Enemy enemy)
        {
            // Generate a random index
            Random random = new();
            int index = random.Next(battleItems.Count);

            // Get the item
            Item selectedItem = battleItems[index];

            selectedItem.Quantity = random.Next(1, 2);
            if(selectedItem.Id <= 15)
            {
                selectedItem.Quantity = random.Next(1, 50);
            }

            int totalValue = selectedItem.Value * selectedItem.Quantity;

            Console.WriteLine($"The {enemy.NameOfPlayer} has dropped something... It's {selectedItem.Name}! \n");

            // Display item details
            Console.WriteLine($"Total Value: {totalValue} coins");
            Console.WriteLine($"Weight: {selectedItem.ItemWeight} kg");
            Console.WriteLine($"Description: {selectedItem.Description}");
            Console.WriteLine($"Quantity: {selectedItem.Quantity}");

            // If it's a Weapon, show additional details
            if (selectedItem is Weapon weapon)
            {
                Console.WriteLine($"Damage: {weapon.Damage}");
                Console.WriteLine($"Bonus Damage: {weapon.BonusDmg}");
                Console.WriteLine($"Type: {weapon.Type}");
            }
        }
    }
}
