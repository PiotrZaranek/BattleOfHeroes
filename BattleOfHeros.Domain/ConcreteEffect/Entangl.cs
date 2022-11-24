using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteEffect
{
    internal class Entangl : Effect
    {
        public Entangl(int time, int value)
        {
            Name = "Splątanie";
            Time = time;
            Value = value;
            Type = 'N';
        }

        public override void Action(Hero hero)
        {
            if(Time > 0)
            {
                hero.Operations[0].IsBlock = true;
                hero.Life -= Value;
                Time--;
            }
            else
            {
                hero.Operations[0].IsBlock = false;
            }
        }
    }
}
