﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        private readonly int _maxStamina;

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
        public bool Fight(GameCharacter opponent, string opponentName, int dmg)
        {
            Random rnd = new Random();

            if (Stamina == 0)
            {
                Recharge();
                return false;
            }

            if (opponent.Health - dmg < 0)
            {
                opponent.Health = 0;
            }
            else
            {
                opponent.Health -= dmg;
            }

            Stamina -= 10;


            return true;


        }
        public void Recharge()
        {
            Stamina = _maxStamina;
        }

    }

}
