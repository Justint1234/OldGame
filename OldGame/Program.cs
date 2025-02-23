using System;

namespace OldGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 200;
            int enemyHp = 100;

            int playerAttack = 10;
            int enemyAttack = 9;

            int healAmount = 12;

            while (playerHp > 0 && enemyHp > 0)
            {
                //player turn
                Console.Write("--Player turn--");
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
                    Console.WriteLine("You healed yourself for " + healAmount + " health.");
                }

                //Enemy turn
                if (enemyHp > 0)
                {
                    Console.WriteLine("--Enemy turn--");
                }
            }

        }
    }
}