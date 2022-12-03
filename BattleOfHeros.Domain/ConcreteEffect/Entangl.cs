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
            Time = time + 1;
            Value = value;
            Type = 'N';
            Color = ConsoleColor.Red;
        }

        public override void Active(Hero hero)
        {            
            hero.Operations[0].IsActive = false;
        }

        public override void Execute(Hero hero)
        {
            if(Time > 1)
            {
                hero.Life -= Value;
                Time--;
            }
            else
            {
                Time = 0;
                Deactivate(hero);
            }
        }

        public override void Deactivate(Hero hero)
        {
            hero.Operations[0].IsActive = true;
        }
    }
}
