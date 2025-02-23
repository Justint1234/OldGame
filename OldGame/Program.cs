using System;

namespace OldGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 200;
            int enemyHp = 200;

            int playerAttack = 20;
            int enemyAttack = 20;

            int healAmount = 12;

            Random random = new Random();



            while (playerHp > 0 && enemyHp > 0)
            {
                //player turn
                Console.Write("--Player turn--");
                Console.WriteLine("Player HP: " + playerHp + ", Enemy Hp: " + enemyHp);
                Console.WriteLine("Press 'a' to attack or 'h' to heal.");

                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("You attacked the enemy and dealt " + playerAttack + " damage.");
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("You healed yourself for " + healAmount + " health points.");
                }

                //Enemy turn
                if (enemyHp > 0)
                {
                    Console.WriteLine("--Enemy turn--");
                    Console.WriteLine("Player HP: " + playerHp + ", Enemy Hp:" +
                        "a " + enemyHp);
                    int enemyChoice = random.Next(0, 2);

                    if(enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage ");
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy heals for " + healAmount + " health points.");
                    }
                }
            }

            if (playerHp > 0)
            {
                Console.WriteLine("You won CONGRATUALTINS!");
            }
            else
            {
                Console.WriteLine("You lost, you suck!");
            }

        }
    }
}