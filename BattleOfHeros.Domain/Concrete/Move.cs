using BattleOfHeroes.Domain.Abstract;
using BattleOfHeroes.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Concrete
{
    public class Move : IMove
    {
        public Hero Hero { get; set; }
        public int Action { get; set; }
        public char Type { get; set; }
        public Hero Target { get; set; }

        public Move()
        {
            Hero = null;
            Action = 0;
            Target = null;
        }
    }
}
