using System;

namespace BossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Boss = new GameCharacter(400, 30, 10);
            var Hero = new GameCharacter(100, 20, 40);

            Random rnd = new Random();


            while (Boss.Health > 0)
            {
                bool isPlayer = true;
                var playerName = isPlayer ? "Hero" : "Boss";
                var player = isPlayer ? Hero : Boss;
                int dmg = rnd.Next(0, player.Strength + 1);

                player.Fight(dmg);
                Console.WriteLine($"{playerName} hit {playerName} with {dmg} damage, {playerName} has {player.Health} left.");
                isPlayer = !isPlayer;
            }


        }
    }
}
