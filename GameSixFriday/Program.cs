using System;

namespace GameSixFriday
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Nº de inimigos?");
            int x = Int32.Parse(Console.ReadLine());
            Foe[] enemies = new Foe[x];

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Nome de inimigo?");
                string s = Console.ReadLine();
                enemies[i] = new Foe(s);
            }

            for (int i = 0; i < enemies.Length; i++)
            {
                Console.WriteLine($"Nome do inimigo {i + 1} : {enemies[i].GetName()}");
            }

            enemies[0].PickUpPowerUp(PowerUp.PowerUps.Shield, 25);
            enemies[1].TakeDamage(35);
            
            Console.WriteLine($"{enemies[0].GetName()} health = {enemies[0].GetHealth()}");
            Console.WriteLine($"{enemies[0].GetName()} shield = {enemies[0].GetShield()}");
            Console.WriteLine($"{enemies[1].GetName()} health = {enemies[1].GetHealth()}");
            Console.WriteLine($"{enemies[1].GetName()} shield = {enemies[1].GetShield()}");
            Console.WriteLine($"Power Count: {Foe.GetPowerCount()}");
        }
    }
}
