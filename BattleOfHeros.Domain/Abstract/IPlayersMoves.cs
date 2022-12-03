using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Abstract
{
    internal interface IPlayersMoves
    {
        int Turn { get; }
        string PlayerName { get; }
        string HeroName { get; }
        string Action { get; }

        void ShowMove();
    }
}
