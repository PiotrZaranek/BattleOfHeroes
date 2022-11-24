using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Abstract;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.Concrete
{
    public class Battle : IBattle
    {
        public List<Player> Players { get; }
        public int Turn { get; set; }
        public List<PlayersMoves> BattleDiget { get; set; }

        public Battle(List<Player> players)
        {
            Players = new List<Player>();
            BattleDiget = new List<PlayersMoves>();
            Players = players;
            Turn = 0;
        }

        public void Main()
        {

        }

        public void SelectHero()
        {

        }

        public void HeroAndAction(Hero attack, Hero defend) 
        {

        }

        public void ExecuteEffectAndAura()
        {

        }
    }
}
