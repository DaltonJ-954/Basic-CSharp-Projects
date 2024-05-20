using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicRPG
{
    class Unit
    {
        public int UnitLevel;
        public string NameOfUnit;
        public int MaxHealth;
        public int CurrentHP;
        public int Experience;
        public int CurrentXP;
        public int Attack;
        public int MaxMagic;
        public int CurMagic;
        public int HealPower;
        public int Damage;
        public int SpecialAbility;
        public Random random;

        public string NameOfPlayer { get { return NameOfUnit; } }
        public int HP { get { return CurrentHP; } }
        public int MP { get { return CurMagic; } }
        public int ExpGained { get; private set; }
        public bool IsDead { get { return CurrentHP <= 0; } }

        public Unit(int unitLevel, string nameOfUnit, int maxHealth, int experience, int attack, int maxMagic, int healPower, int damage, int specialAbility)
        {
            this.UnitLevel = unitLevel;
            this.NameOfUnit = nameOfUnit;
            this.MaxHealth = maxHealth;
            this.CurrentHP = maxHealth;
            this.Experience = experience;
            this.CurrentXP = experience;
            this.Attack = attack;
            this.MaxMagic = maxMagic;
            this.CurMagic = maxMagic;
            this.HealPower = healPower;
            this.Damage = damage;
            this.SpecialAbility = specialAbility;
            this.random = new Random();
        }

        public void UnitAttack(Unit enemyUnit)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(Attack * rng);
            enemyUnit.AttackDamage(randDamage);
            Console.WriteLine(NameOfUnit + " attacks " + enemyUnit.NameOfPlayer + " and deals " + randDamage + " damage!\n");
        }

        public void CastSpell(Unit enemyUnit)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(Attack * rng);
            enemyUnit.AttackDamage(randDamage);
            Console.WriteLine(NameOfUnit + "'s spell against " + enemyUnit.NameOfUnit + " hits and deals " + randDamage + " damage!\n");

            MagicUse(7);
        }

        public void MagicUse(int usage)
        {
            CurMagic -= usage;

            if (usage <= CurMagic) // Changed from < to <=
                Console.WriteLine("-" + usage + " magic..");
            else
                Console.WriteLine("Your current magic is " + CurMagic + ", use Replenish.");
        }

        public void Replenish(int fill)
        {
            // Ensure that the fill amount is positive
            if (fill <= 0)
            {
                Console.WriteLine("Replenish amount must be positive.");
                return;
            }
            // Ensure that amount is within bounds
            else if (CurMagic >= MaxMagic)
            {
                Console.WriteLine("Your magic is already full.");
            }
            else
            {
                // Calculate the new currentMagic after replenishing
                int newMagic = CurMagic + fill;
                if (newMagic > MaxMagic)
                {
                    CurMagic = MaxMagic;
                    Console.WriteLine("Your magic is now full.");
                }
                else
                {
                    CurMagic = newMagic;
                    Console.WriteLine("You have replenished " + fill + " points of magic back!");
                }
            }
        }

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
            // Generate a random number between 0.0 (inclusive) and 1.0 (exclusive)
            double rng = random.NextDouble();

            // Adjust the random number to be within the range [0.75, 1.25)
            rng = rng / 2 + 0.75f;

            // Calculate the amount of healing based on the adjusted random number and HealPower
            int heal = (int)(rng * HealPower);

            // Ensure that healing doesn't exceed the maximum health using a ternary operator based on a condition
            CurrentHP = heal + CurrentHP > MaxHealth ? MaxHealth : CurrentHP + heal;

            // Print a message indicating the amount of healing done
            Console.WriteLine(NameOfUnit + " heals " + heal + " points.\n");
        }

        public void GainExp(int minExp, int maxExp)
        {
            // Initialize a new instance of the Random class
            random = new Random();

            // Generate a random number between minExp and maxExp (inclusive).
            // The maxExp + 1 is used because the Next() method is exclusive of the upper bound.
            int gainedExp = random.Next(minExp, maxExp + 1);

            // Add the gained experience points to the total Experience.
            Experience += gainedExp;

            // Output the amount of experience gained and the new total experience to the console.
            Console.WriteLine("Gained " + gainedExp + " experience points. Total experience: " + Experience + ".\n");
        }

        public void LevelUp()
        {
            // += increases the variables's level with a value, respectfully.
            UnitLevel += 1;
            CurrentHP = MaxHealth += 10;
            Attack += 5;
            CurMagic += 5;
            GainExp(20, 55);

            // Output a message to the console indicating the player's new level and a progress update
            Console.WriteLine(NameOfPlayer + " has grown stronger! Level: " + UnitLevel + " - Progress updated!\n");
        }
    }
}
