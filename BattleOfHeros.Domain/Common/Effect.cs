using BattleOfHeroes.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Common
{
    public abstract class Effect : IEffect
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public int Value { get; set; }
        public char Type { get; set; }
        public abstract void Action(Hero hero);
    }
}
