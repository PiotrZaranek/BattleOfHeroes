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
        int Id { get; set; }
        string Name { get; set; }
        bool IsActive { get; set; }        
        char Type { get; set; }
        void Action(Hero hero, int value);
    }
}
