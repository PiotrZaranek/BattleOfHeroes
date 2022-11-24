using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteEffect
{
    internal class DefendIncreased : Effect
    {
        public DefendIncreased(int time, int value)
        {
            Name = "Zwiększona obrona";
            Time = time;
            Value = value;
            Type = 'P';
        }

        public override void Action(Hero hero)
        {
            if (Time > 0)
            {
                hero.Defend += Value;
                Time--;
            }            
            else
            {
                hero.Defend -= Value;
            }
        }
    }
}
