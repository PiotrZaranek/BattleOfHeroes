using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Abstract
{
    internal interface IMenu
    {
        int Id { get; }
        string Name { get; }
        string MenuType { get; }
    }
}
