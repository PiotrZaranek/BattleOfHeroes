using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BattleOfHeroes.Domain.Concrete;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.Abstract
{
    internal interface IBattle
    {
        List<Player> Players { get; }
        int Turn { get; set; }
        List<PlayersMoves> BattleDiget { get; set; }

        void Main();
        void SelectHero();
        void HeroAndAction(Hero attack, Hero defend);
        void ExecuteEffectAndAura();        
    }
}
