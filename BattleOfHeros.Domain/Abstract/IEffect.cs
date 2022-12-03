using BattleOfHeroes.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Abstract
{
    internal interface IEffect
    {
        string Name { get; set; }
        int Time { get; set; }
        int Value { get; set; }
        char Type { get; set; }
        ConsoleColor Color { get; set; }

        void Active(Hero hero);

        void Execute(Hero hero);

        void Deactivate(Hero hero);
    }
}
