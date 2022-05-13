using System;

namespace BossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Boss = new GameCharacter(400, 30, 10);
            var Hero = new GameCharacter(100, 20, 40);


            bool isPlayer = true;
            Random rnd = new Random();

            while (Boss.Health > 0 && Hero.Health > 0)
            {

                string playerName = isPlayer ? "Hero" : "Boss";
                string opponentName = isPlayer ? "Boss" : "Hero";
                var player = isPlayer ? Hero : Boss;
                var opponent = isPlayer ? Boss : Hero;
                int dmg = opponentName == "Boss" ? player.Strength : rnd.Next(0, opponent.Strength + 1);

                Console.WriteLine(player.Fight(opponent, opponentName, dmg)
                    ? $"{playerName} hit {opponentName} with {dmg} damage, {opponentName} has {opponent.Health} hp left. {playerName} has {player.Stamina} stamina left"
                    : $"{playerName} recharged!");

                isPlayer = !isPlayer;
            }

            string winnerName = isPlayer ? "Boss" : "Hero";

            Console.WriteLine(winnerName + " won!");



        }
    }
}
