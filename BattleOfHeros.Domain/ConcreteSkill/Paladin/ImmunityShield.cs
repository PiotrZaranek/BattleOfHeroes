using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteEffect;

namespace BattleOfHeroes.Domain.ConcreteSkill.Paladin
{
    internal class ImmunityShield : Skill
    {
        public ImmunityShield()
        {
            Name = "Tarcza nietykalności";
            NeedMana = 60;
            Type = 'P';
            IsActive = true;
        }

        public override void Action(Hero hero)
        {
            hero.Effects.Add(new Immunity(2));
        }
    }
}
