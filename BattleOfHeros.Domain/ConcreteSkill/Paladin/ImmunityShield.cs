using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteState;

namespace BattleOfHeroes.Domain.ConcreteSkill.Paladin
{
    public class ImmunityShield : Skill
    {
        public ImmunityShield(int id)
        {
            Id = id;
            Name = "Tarcza nietykalności";
            NeedMana = 30;
            Type = 'P';
            IsActive = true;
            IsAura = false;
        }

        public override void Action(Hero hero, Hero target)
        {
            UpdateMana(hero);
            target.States.Add(new Immunity(2));
        }
    }
}
