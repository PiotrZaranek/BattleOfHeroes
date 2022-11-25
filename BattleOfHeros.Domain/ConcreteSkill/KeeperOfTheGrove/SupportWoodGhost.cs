using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteEffect;

namespace BattleOfHeroes.Domain.ConcreteSkill.KeeperOfTheGrove
{
    internal class SupportWoodGhost : Skill
    {
        public SupportWoodGhost(int id)
        {
            Id = id;
            Name = "Wsparcie leśnych duchów";
            NeedMana = 30;
            Type = 'P';
            IsActive = true;
        }

        public override void Action(Hero hero)
        {
            hero.Effects.Add(new DefendIncreased(5, 7));
        }
    }
}
