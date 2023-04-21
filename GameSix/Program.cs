using System;

namespace GameSix
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
                Console.WriteLine($" Nome do inimigo {i+1} : {enemies[i].GetName()}");
            }
        }
    }
}
