using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.Abstract
{
    internal interface IPlayer
    {
        int Id { get; }
        string PlayerName { get; }        
        List<Hero> Heroes { get; set; }
        int SelectHero { get; set; }
        Hero Hero { get; set; }
        Hero Target { get; set; }
    }
}
