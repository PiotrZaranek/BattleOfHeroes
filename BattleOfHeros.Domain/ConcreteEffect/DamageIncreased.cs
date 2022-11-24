using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteEffect
{
    internal class DamageIncreased : Effect
    {
        public DamageIncreased(int time, int value)
        {
            Name = "Ziększony Atak";
            Time = time;
            Value = value;
            Type = 'P';
        }

        public override void Action(Hero hero)
        {
            if(Time > 0)
            {
                hero.Damage += Value;
                Time--;
            }
            else
            {
                hero.Damage -= Value;
            }
        }
    }
}
