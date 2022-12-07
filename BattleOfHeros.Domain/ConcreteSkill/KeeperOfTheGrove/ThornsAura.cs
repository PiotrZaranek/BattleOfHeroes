using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.Abstract;

namespace BattleOfHeroes.Domain.ConcreteSkill.KeeperOfTheGrove
{
    public class ThornsAura : Skill
    {
        public ThornsAura(int id)
        {
            Id = id;
            Name = "Ciernista Aura";
            NeedMana = 0;            
            Type = 'A';
            IsActive = true;
            IsAura = true;
        }

        public override void Action(Hero hero, Hero target)
        {
            target.Life -= 10;
        }
    }
}
