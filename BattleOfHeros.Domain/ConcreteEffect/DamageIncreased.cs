using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteEffect
{
    public class DamageIncreased : Effect
    {
        public DamageIncreased(int time, int value)
        {
            Name = "Zwiększony atak";
            Time = time + 1;
            Value = value;
            Type = 'P';
            Color = ConsoleColor.Green;
        }

        public override void Active(Hero hero)
        {
            hero.Damage += Value;            
        }

        public override void Execute(Hero hero)
        {
            if (Time > 1)
            {
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
            hero.Damage -= Value;
        }
    }
}
