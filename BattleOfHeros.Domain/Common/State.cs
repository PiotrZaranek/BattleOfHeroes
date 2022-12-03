using BattleOfHeroes.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Common
{
    public abstract class State : IState
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public char Type { get; set; }
        public ConsoleColor Color { get; set; }

        public void Execute()
        {
            if(Time > 0)
            {
                Time--;
            }                        
        }
    }
}
