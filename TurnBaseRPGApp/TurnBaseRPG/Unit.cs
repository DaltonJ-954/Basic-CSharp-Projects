using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBaseRPG
{
    internal class Unit
    {
        private int unitLevel;
        private int currentHP;
        private int maxHP;
        private int attackPower;
        private int magicPower;
        private int currentMagic;
        private int healPower;
        private string unitName;
        private int defensiveGuard;
        private int agilityStrentgh;
        private Random random;

        public int HP { get { return currentHP; } }
        public string UnitName { get { return unitName; } }
        public bool IsDead {  get { return currentHP <= 0; } }

        public Unit(int unitLevel, int maxHP, int attackPower, int magicPower, int healPower, int defensiveGuard, int agilityStrentgh, string unitName)
        {
            this.unitLevel = unitLevel;
            this.maxHP = maxHP;
            this.currentHP = maxHP;
            this.attackPower = attackPower;
            this.magicPower = magicPower;
            this.currentMagic = magicPower;
            this.healPower = healPower; 
            this.unitName = unitName;
            this.defensiveGuard = defensiveGuard;
            this.agilityStrentgh = agilityStrentgh;
            this.random = new Random();
        }

        public void HeroeAttack(Unit unitToAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(attackPower * rng);
            unitToAttack.HeroeDamage(randDamage);
            Console.WriteLine(unitName + " attacks " + unitToAttack.unitName + " and deals " + randDamage + " damage!\n");

            if (currentHP <= 60)
                attackPower = attackPower + 2;
            else if (currentHP <= 35)
                attackPower = attackPower + 5;
        }

        public void Magic(Unit magicAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 3 + 0.60f;
            int randDamage = (int)(magicPower * rng);
            magicAttack.HeroeDamage(randDamage);
        }

        public void EnemyAttack(Unit unitToAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(attackPower * rng);
            unitToAttack.EnemyDamage(randDamage);
            Console.WriteLine(unitName + " attacks " + unitToAttack.unitName + " and deals " + randDamage + " damage!\n");

            if (currentHP <= 70)
                attackPower = attackPower + 3;
        }

        public void HeroeDamage(int damage)
        {
            currentHP -= damage;

            if (currentHP <= 80)
                defensiveGuard = defensiveGuard + 25;

            if (IsDead)
                Console.WriteLine(UnitName + " has been defeated!");
        }

        public void EnemyDamage(int damage)
        {
            currentHP -= damage;

            if (IsDead)
                Console.WriteLine(UnitName + " has been defeated!");
        }

        public void Heal()
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int heal = (int)(rng * healPower);
            currentHP = heal + currentHP > maxHP ? maxHP : currentHP + heal;
            Console.WriteLine(UnitName + " heals " + heal);
        }

        public bool Guard(int enemyAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int guardChance = defensiveGuard + agilityStrentgh;
            return rng < guardChance;
        }
    }
}
