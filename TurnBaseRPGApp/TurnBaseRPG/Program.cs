using System;
using TurnBaseRPG;

Unit myPlayer = new Unit(14, 150, 16, 13, 25, 14, 9, "Ragar");
Unit enemyCPU = new Unit(10, 300, 15, 10, 20, 12, 15, "Horned Snake");
Random random = new Random();

while (!myPlayer.IsDead && !enemyCPU.IsDead)
{
    Console.WriteLine(myPlayer.UnitName + " current HP = " + myPlayer.HP + ". " + enemyCPU.UnitName + " current HP = " + enemyCPU.HP);
    Console.WriteLine("Player's turn! What will you do?");
    string select = Console.ReadLine();

    Console.WriteLine(myPlayer.UnitName + " current HP = " + myPlayer.HP + ". " + enemyCPU.UnitName + " current HP = " + enemyCPU.HP);
    if (select == "a")
        myPlayer.HeroeAttack(enemyCPU);

    if (select == "m")
        myPlayer.Magic(enemyCPU);

    if (select == "h" && myPlayer.HP == 120)
        Console.WriteLine(myPlayer.UnitName + " is already at full health.");
    else if (select == "h" && myPlayer.HP >= 25 || myPlayer.HP <= 35)
        myPlayer.Heal();

    if (myPlayer.IsDead || enemyCPU.IsDead) break;

    Console.WriteLine("Enemy turn!");

    int rand = random.Next(0, 2);

    if (rand == 0)
        enemyCPU.EnemyAttack(myPlayer);
    else
        enemyCPU.Heal();
}