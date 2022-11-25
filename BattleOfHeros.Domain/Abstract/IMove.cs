using BattleOfHeroes.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Abstract
{
    internal interface IMove
    {
        Hero Hero { get; set; }
        IAction Action { get; set; }
        Hero Target { get; set; }
    }
}
