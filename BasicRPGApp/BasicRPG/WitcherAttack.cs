using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG
{
    public enum AttackType
    {
        Sword,
        Sign,
        Crossbow,
        Bomb
    }

    public enum GetShieldStrength
    {
        Light,
        Medium,
        Heavy
    }

    public class WitcherAttack : Unit
    {
        public string WitcherName { get; set; }
        public AttackType Type { get; set; }
        public bool IsCritical { get; private set; }

        private static readonly Random random = Random.Shared;

        public WitcherAttack(string witcherName, AttackType type)
            : base(1, witcherName, 100, 100, 0, 10, 50, 50, 10, 10) // Provide default values for Unit's constructor
        {
            WitcherName = witcherName;
            Type = type;
        }

        public void PerformAttack(Enemy enemyUnit)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;

            int baseDamage = CalculateDamage(Type);
            int randDamage = (int)(baseDamage * rng);

            double critChance = 0.2; // 20%
            double critMultiplier = 2.0;

            if (random.NextDouble() < critChance)
            {
                randDamage = (int)(randDamage * critMultiplier);
                IsCritical = true;
            }
            else
            {
                IsCritical = false;
            }

            // Choose the type of attack
            switch (Type)
            {
                case AttackType.Sword:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{WitcherName} slashes {enemyUnit.NameOfUnit} with a sword for {randDamage} damage!");
                    break;

                case AttackType.Sign:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{WitcherName} casts a magical Sign on {enemyUnit.NameOfUnit}, dealing {randDamage} damage!");
                    break;

                case AttackType.Crossbow:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{WitcherName} fires a crossbow bolt at {enemyUnit.NameOfUnit}, hitting for {randDamage} damage!");
                    break;

                case AttackType.Bomb:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{WitcherName} throws a bomb at {enemyUnit.NameOfUnit}, causing {randDamage} explosive damage!");
                    break;

                default:
                    Console.ResetColor();
                    Console.WriteLine($"{WitcherName} tries to attack but seems confused!");
                    break;
            }

            if (IsCritical)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚡ CRITICAL HIT! ⚡\n");
            }

            Console.ResetColor();

            // Apply damage to the enemy
            enemyUnit.AttackDamage(randDamage);
        }



        private int CalculateDamage(AttackType type)
        {
            return type switch
            {
                AttackType.Sword => random.Next(30, 40),
                AttackType.Sign => random.Next(15, 35),
                AttackType.Crossbow => random.Next(10, 25),
                AttackType.Bomb => random.Next(20, 40),
                _ => 0
            };
        }
    }
}
