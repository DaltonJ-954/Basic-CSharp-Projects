using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRPG
{
    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
            Encounters.InitialEncounter();
        }

        static void Start()
        {
            Console.WriteLine("Space Within Galaxies!");
            Console.WriteLine("Name:");
            currentPlayer.Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You awake in a cold and dark room. You are feeling dizzy, confused, and in dyer need of knowing what");
            Console.WriteLine("happened up to this point.");

            if (currentPlayer.Name == "")
                Console.WriteLine("You don't know your name?");
            else
                Console.WriteLine("You do remember that your name is " + currentPlayer.Name + " which is great!");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("As you feel your way through the area in darkness, you grab hold of something that resembles a door handle. As you try and open the door");
            Console.WriteLine("a loud noise pierces your ears and the doors shatters into hundreds of shards. You hear whispers creap through the entrance from an odd figure.");
        }
    }
}
