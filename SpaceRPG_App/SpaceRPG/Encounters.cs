using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRPG
{
    class Encounters : Program
    {
        static readonly Random rand = new();
        public static void InitialEncounter()
        {
            Console.WriteLine("You ask the figure to identify themselves by telling you there name.");
            Console.WriteLine("The figure stays silent and pulls out a sword!");
            Console.ReadKey();
            Combat(false, "Elite Cyborg", 2, 3);
        }

        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;

            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }

            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("======================");
                Console.WriteLine("| (A)ttack (D)efend  |");
                Console.WriteLine("|   (R)un    (H)eal  |");
                Console.WriteLine("======================");
                Console.WriteLine("Potions: " + currentPlayer.Potion + "  Health: " + currentPlayer.Health);

                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    // Attack
                    Console.WriteLine("Your sword radiates with energy as you reach for it giving you strengh. The " + n + " attempts a powerful attack!");
                    Console.WriteLine("In an instance, the, " + n + " strikes with a furocious swing!");
                    int damage = currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, currentPlayer.weaponValue) + rand.Next(1, 5);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damege.");
                    currentPlayer.Health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    // Defend
                    Console.WriteLine("Unknowing, you realize your reflexes seem to allow you to evade his on-coming assault and escape..");
                    Console.WriteLine("In an instance, the, " + n + " strikes with a furocious swing!");
                    int damage = currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, currentPlayer.weaponValue) / 2;
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damege.");
                    currentPlayer.Health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    // Run
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("The strike from the " + n + " catches you off gaurd and sends you falling back in pain. You gather yourself.");
                        int damage = p - currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health and are unable to escape.");
                    }
                    else
                    {
                        Console.WriteLine("Your agility is high and are able to avoid the fight with " + n + " this time!");
                        Console.ReadKey();
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    // Heal
                    if (currentPlayer.Potion == 0)
                    {
                        Console.WriteLine("As you reach for a potion in your bag, you realize that all your bottles are empty.");
                        int damage = p - currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("The " + n + " strikes you with a mighty blow and you lose " + damage + " health!");
                    }
                    else
                    {
                        Console.WriteLine("You reach into your supply pouch and grap a bottle of green glowing energy. You drink it rapidly.");
                        int potionV = 5;
                        Console.WriteLine("You recover " + potionV + " health");
                        currentPlayer.Health += potionV;
                        Console.WriteLine("As you were occupied, the " + n + " advanced and struck.");
                        int damage = (p / 2) - currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health.");
                    }
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }
}
