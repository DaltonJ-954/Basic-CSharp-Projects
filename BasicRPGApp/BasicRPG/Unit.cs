using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BasicRPG
{
    public class Unit
    {
        public int UnitLevel;
        public string NameOfUnit;
        public int MaxHealth;
        public int CurrentHP;
        public int Experience;
        public int Attack;
        public int MaxMagic;
        public int CurMagic;
        public int HealPower;
        public int Damage;
        public int SoulOrbs = 0;
        public int SpecialAbility;
        public int CurSpecial;
        private static readonly Random random = new();

        

        public string NameOfPlayer { get { return NameOfUnit; } }
        public int HP { get { return CurrentHP; } }
        public int MP { get { return CurMagic; } }
        public int SA { get { return CurSpecial; } }
        public int ExpGained { get; private set; }
        public bool IsDead { get { return CurrentHP <= 0; } }


        public delegate void AchievementDelegate(int exp);
        public delegate void SpecialDelegate(int spec);
        public delegate void SwordAttackDelegate(Enemy enemy, int att);

        public event AchievementDelegate? AchievementUnlocked;
        public event SpecialDelegate? SpecialUnlocked;
        public event SwordAttackDelegate? SwordUnleashed;

        public Unit(int unitLevel, string nameOfUnit, int maxHealth, int experience, int attack, int maxMagic, int healPower, int damage,int soulOrbs, int specialAbility)
        {
            this.UnitLevel = unitLevel;
            this.NameOfUnit = nameOfUnit;
            this.MaxHealth = maxHealth;
            this.CurrentHP = maxHealth;
            this.Experience = experience;
            this.Attack = attack;
            this.MaxMagic = maxMagic;
            this.CurMagic = maxMagic;
            this.HealPower = healPower;
            this.Damage = damage;
            this.SoulOrbs = soulOrbs;
            this.SpecialAbility = specialAbility;
            this.CurSpecial = specialAbility;
        }

        public void PlayerAttack(Enemy enemyUnit)
        {
            // This method is using a similar concept a the CastSpell method
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(Attack * rng);
            enemyUnit.AttackDamage(randDamage);
            Console.WriteLine($"{NameOfUnit} attacks {enemyUnit.NameOfUnit} and deals {randDamage} damage!\n");
        }

        public async Task SuperGauge(int minExp, int maxExp)
        {
            // Initialize a new instance of the Random class

            // Generate a random number between minExp and maxExp (inclusive).
            // The poweringUp + 1 is used because the Next() method is exclusive of the upper bound.
            int poweringUp = random.Next(minExp, maxExp + 1);

            // Add the gained special points to the total SpecialAbility.
            SpecialAbility += poweringUp;
            await Task.Delay(500);

            // Output the amount of special gained and the new total special to the console.
            Console.WriteLine($"Soul Ether: {poweringUp} - Total Ether: {SpecialAbility}\n");

            if (SpecialAbility >= 100)
            {
                OrbLevel();
                SpecialUnlocked?.Invoke(SpecialAbility);

                SpecialAbility = 0;
            }
        }

        public void OrbLevel()
        {
            SoulOrbs++;
            if (SoulOrbs <= 1)
            {
                Console.WriteLine($"You have {SoulOrbs} soul orb in your inventory! ()\n");
            }
            else
            {
                Console.WriteLine($"You now have {SoulOrbs} soul orbs in your inventory! ()\n");
            }
        }

        public void ManaSpell(Enemy enemyUnit)
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
            Console.WriteLine($"{NameOfUnit}'s spell deals {randDamage} damage to {enemyUnit.NameOfUnit}!\n");

            // Deducts a minimum of 8 and at max 15 magic points from the unit casting the spell
            ManaUse(8, 15);
        }

        public void ManaUse(int lowUsage, int highUsage)
        {
            Random random = new();
            int totalUsage = random.Next(lowUsage, highUsage);

            if (CurMagic <= totalUsage)
            {
                totalUsage = CurMagic;
                CurMagic = 0;

                Console.WriteLine($"Magic: [ - {totalUsage} ]");
                Console.WriteLine("Your magic is now depleted!");

                // Prompt the player to replenish
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
        }

        public void Replenish()
        {
            int replenishAmount = random.Next(1, 15); // Amount restored by a vial
            CurMagic += replenishAmount;

            if (CurMagic > MaxMagic)
                CurMagic = MaxMagic;

            Console.WriteLine($"You used a Replenish Vial! Magic restored by {replenishAmount}.");
            Console.WriteLine($"Current Magic: {CurMagic}/{MaxMagic}");
        }

        //public void ReplenishVial(int fill)
        //{
        //    // Ensure that the fill amount is positive
        //    if (fill <= 0)
        //    {
        //        Console.WriteLine("Replenish amount must be positive.\n");
        //        return;
        //    }
        //    // Ensure that amount is within bounds
        //    else if (CurMagic >= MaxMagic)
        //    {
        //        Console.WriteLine("Your magic is already full.\n");
        //    }
        //    else
        //    {
        //        // Calculate the new currentMagic after replenishing
        //        int newMagic = CurMagic + fill;
        //        if (newMagic > MaxMagic)
        //        {
        //            CurMagic = MaxMagic;
        //            Console.WriteLine("Your magic is now full.\n");
        //        }
        //        else
        //        {
        //            CurMagic = newMagic;
        //            Console.WriteLine("You have replenished " + fill + " points of magic back!\n");
        //        }
        //    }
        //}

        public void MagicDamage(int damage)
        {
            // Subtract the damage from the current health points (HP)
            CurrentHP -= damage;

            // Check if the unit is dead (if its HP drops to or below zero)
            if (IsDead)
                return;
        }

        public void AttackDamage(int damage)
        {
            // Same syntax as the MagicDamgae method
            CurrentHP -= damage;

            if (IsDead)
                return;
        }

        public void Heal()
        {
            if (CurrentHP < 60)
            {
                // Generate a random number between 0.0 (inclusive) and 2.0 (exclusive)
                double rngTwo = random.NextDouble();

                // Adjust the random number to be within the range [0.75, 2.25)
                rngTwo = rngTwo / 2 + 1.75f;

                // Calculate the amount of healing based on the adjusted random number and HealPower
                int healPlus = (int)(rngTwo * HealPower);

                // Ensure that healing doesn't exceed the maximum health using a ternary operator based on a condition
                CurrentHP = healPlus + CurrentHP > MaxHealth ? MaxHealth : CurrentHP + healPlus;

                // Print a message indicating the amount of healing done
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{NameOfUnit} heals {healPlus} points.\n");
                Console.ResetColor();

            }
            else
            {
                // Generate a random number between 0.0 (inclusive) and 1.0 (exclusive)
                double rng = random.NextDouble();

                // Adjust the random number to be within the range [0.75, 1.25)
                rng = rng / 2 + 0.75f;

                // Calculate the amount of healing based on the adjusted random number and HealPower
                int heal = (int)(rng * HealPower);

                // Ensure that healing doesn't exceed the maximum health using a ternary operator based on a condition
                CurrentHP = heal + CurrentHP > MaxHealth ? MaxHealth : CurrentHP + heal;

                // Print a message indicating the amount of healing done
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{NameOfUnit} heals {heal} points.\n");
                Console.ResetColor();
            }
        }

        public async Task GainExp(int minExp, int maxExp)
        {
            // Initialize a new instance of the Random class

            // Generate a random number between minExp and maxExp (inclusive).
            // The maxExp + 1 is used because the Next() method is exclusive of the upper bound. 
            int gainedExp = random.Next(minExp, maxExp + 1);

            // Add the gained experience points to the total Experience.
            Experience += gainedExp;

            // Output the amount of experience gained and the new total experience to the console.
            Console.WriteLine($"XP [ + {gainedExp} ] - Total XP: {Experience}\n");
            await Task.Delay(500);


            // Initialize a list of integers representing the experience points required to reach each level.
            List<int> level = new() { 200, 500, 900, 1400, 2000, 2600, 3200, 3500, 4000, 4200 };

            // While the player's unit level is less than or equal to the number of levels in the list
            // and the player's experience is greater than or equal to the experience required for the next level
            while (UnitLevel <= level.Count && Experience >= level[UnitLevel - 1])
            {
                // This method is designed to level up the player
                LevelUp();
                AchievementUnlocked?.Invoke(Experience);
            }
        }

        public void LevelUp()
        {
            // += increases the variable's level with a value, respectfully.
            UnitLevel += 1;
            CurrentHP = MaxHealth += 5;
            Attack += 3;
            CurMagic += 5;
        }

        public async Task SpecialAttack(Enemy enemyUnit)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 8.25f;
            int randDamage = (int)(Attack * rng);
            enemyUnit.AttackDamage(randDamage);
            await Task.Delay(1000);

            SwordUnleashed?.Invoke(enemyUnit, randDamage + CurSpecial);
            SoulOrbs--;
        }
    }
}