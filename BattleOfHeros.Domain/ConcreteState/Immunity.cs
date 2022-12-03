using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteState
{
    internal class Immunity : State
    {
        public Immunity(int time)
        {
            Name = "Nietykalność";
            Time = time + 1;
            Type = 'P';
            Color = ConsoleColor.Green;
        }
    }
}
