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
        public IAction Action { get; set; }
        public Hero Target { get; set; }

        public Move()
        {
            Hero = null;
            Action = null;
            Target = null;
        }
    }
}
