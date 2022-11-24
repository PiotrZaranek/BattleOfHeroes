using BattleOfHeroes.Domain.Abstract;
using BattleOfHeroes.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Concrete
{
    public class Player : IPlayer
    {
        public int Id { get; }
        public string PlayerName { get; }
        public List<Hero> Heroes { get; set; }
        public int SelectHero { get; set; }
        public Hero Hero { get; set; }
        public Hero Target { get; set; }

        public Player(int id, string name)
        {
            Id = id;
            PlayerName = name;
            Heroes = new List<Hero>();
            SelectHero = 0;
            Hero = null;
            Target = null;
        }
    }
}
