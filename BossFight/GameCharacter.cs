using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class GameCharacter
    {
        //Properties
        public int Health;
        public int Strength;
        public int Stamina;
        private int _maxStamina;

        //Constructor ctor
        //var Player = new GameCharacter(100, 20, 40)
        public GameCharacter(int health, int strength, int stamina)
        {
            Health = health;
            Strength = strength;
            Stamina = stamina;
            _maxStamina = stamina;
        }

        //Metoder
        public void Fight(int str)
        {
            if (Stamina == 0)
            {
                Recharge();
            }
            else
            {
                Health -= str;
                Stamina -= 10;
            }


        }
        public void Recharge()
        {
            //stamina = maxstamina
            Stamina = _maxStamina;
        }

    }

}
