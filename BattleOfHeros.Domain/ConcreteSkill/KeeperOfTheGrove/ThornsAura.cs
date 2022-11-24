using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteSkill.KeeperOfTheGrove
{
    internal class ThornsAura : Skill
    {
        public ThornsAura()
        {
            Name = "Ciernista Aura";
            NeedMana = 0;            
            Type = 'C';
            IsActive = true;
        }

        public override void Action(Hero hero)
        {
            hero.Life -= 10;
        }
    }
}
