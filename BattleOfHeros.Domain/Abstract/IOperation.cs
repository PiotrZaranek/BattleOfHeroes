using BattleOfHeroes.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Abstract
{
    internal interface IOperation
    {
        string Name { get; set; }
        bool IsBlock { get; set; }
        int Time { get; set; }

        void Action(Hero hero, int value);
    }
}
