using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Abstract;

namespace BattleOfHeroes.Domain.Common
{
    public abstract class Skill : ISkill, IAction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NeedMana { get; set; }
        public char Type { get; set; }
        public bool IsActive { get; set; }
        public abstract void Action(Hero hero);        
    }
}
