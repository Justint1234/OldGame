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

            string choice = Console.ReadLine();

            if(choice == "a")
            {
                enemyHp -= playerAttack;
                Console.WriteLine("You attacked the enemy! and dealt " + playerAttack + " damage ");
            }
        }
    }
}