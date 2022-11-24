using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteEffect
{
    internal class Immunity : Effect
    {
        public Immunity(int time)
        {
            Name = "Nietykalność";
            Time = time;
            Type = 'P';
        }

        public override void Action(Hero hero)
        {
            Time--;
        }
    }
}
