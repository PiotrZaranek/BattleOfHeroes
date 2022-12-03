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
        public ConsoleColor Color { get; set; }
        public abstract void Active(Hero hero);
        public abstract void Execute(Hero hero);
        public abstract void Deactivate(Hero hero);
    }
}
