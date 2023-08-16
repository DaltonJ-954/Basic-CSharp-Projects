using System;

namespace Game_of_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandNum; // Intergers representing the player and cpu.
            int enemyRandNum;

            int playerPoints = 0; // Integers that will keep track of the player, cpu, and draw points.
            int enemyPoints = 0;
            int drawPoints = 0;

            Console.WriteLine("Enter your name: ");
            string myName = Convert.ToString(Console.ReadLine()); // Convert string method used for input of characters.

            Random random = new Random(); // This class created an instantiated variable that will generate random numbers

            for (int i = 0; i < 10; i++) // For loop
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();


                playerRandNum = random.Next(2, 12); // Integer variable using an instantiated variable that genreates numbers from the parameters.
                Console.WriteLine($"{myName} rolled a {playerRandNum}.");

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000); // Suspends the current thread for the specified amount of time.

                enemyRandNum = random.Next(2, 12);
                Console.WriteLine($"Enemy AI rolled a {enemyRandNum}.");

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                if (playerRandNum > enemyRandNum) // If and else if statement that tracks the points between player and cpu.
                {
                    playerPoints++;
                    Console.WriteLine($"{myName} wins the round!");
                }
                else if (playerRandNum < enemyRandNum)
                {
                    enemyPoints++;
                    Console.WriteLine("The CPU wins the round!");
                }
                else
                {
                    drawPoints++;
                    Console.WriteLine("This round ended in a draw.");
                }
                // Concatenate variabls into a sentence.
                Console.WriteLine($"The score is now - {myName} : " + playerPoints + " Enemy : " + enemyPoints + " Draw : " + drawPoints + ".");
                Console.WriteLine();
            }

            if (playerPoints > enemyPoints) // An if/else if statement that determines the winner.
            {
                Console.WriteLine($"{myName} win!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.ReadKey(); 
        }
    }
}