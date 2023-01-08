using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BattleOfHeroes.Domain.Concrete;
using BattleOfHeroes.BattleApp.Concrete;

namespace BattleOfHeroes.Domain.Abstract
{
    internal interface IBattle
    {
        List<Player> Players { get; }
        int Turn { get; set; }
        BattleList BattleList { get; set; }        

        void Main();      
    }
}
