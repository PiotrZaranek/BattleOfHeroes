using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.Concrete;

namespace BattleOfHeroes.Domain.Abstract
{
    internal interface IPlayer
    {
        int Id { get; }
        string PlayerName { get; }        
        List<Hero> Heroes { get; set; }
        int SelectHero { get; set; }
        Move Move { get; set; }
    }
}
