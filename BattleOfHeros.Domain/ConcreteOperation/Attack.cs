using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteOperation
{
    internal class Attack : Operation
    {
        public Attack()
        {
            Name = "Atak";
            IsBlock = false;
            Time = 0;
        }

        public override void Action(Hero hero, int value)
        {
            if (IsBlock == false)
            {
                Random r = new Random();
                value = r.Next(value - 5, value + 1);
                hero.Life -= (value - hero.Defend);
            }            
            else
            {
                Time--;
                if (Time == 0)
                {
                    IsBlock = false;
                }
            }
        }
    }
}
