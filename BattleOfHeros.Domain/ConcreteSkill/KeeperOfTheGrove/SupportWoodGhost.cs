using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteEffect;

namespace BattleOfHeroes.Domain.ConcreteSkill.KeeperOfTheGrove
{
    public class SupportWoodGhost : Skill
    {
        public SupportWoodGhost(int id)
        {
            Id = id;
            Name = "Wsparcie leśnych duchów";
            NeedMana = 15;
            Type = 'P';
            IsActive = true;
            IsAura = false;
        }

        public override void Action(Hero hero, Hero target)
        {
            UpdateMana(hero);

            Effect effect = new DefendIncreased(5, 5);
            target.Effects.Add(effect);
            effect.Active(target);
        }
    }
}
