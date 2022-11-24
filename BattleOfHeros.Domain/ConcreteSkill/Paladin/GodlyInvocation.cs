using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteEffect;

namespace BattleOfHeroes.Domain.ConcreteSkill.Paladin
{
    internal class GodlyInvocation : Skill
    {
        public GodlyInvocation()
        {
            Name = "Boskie wezwanie";
            NeedMana = 100;
            Type = 'P';
            IsActive = true;
        }

        public override void Action(Hero hero)
        {
            if((hero.Life += 50) > hero.MaxLife)
            {
                hero.Life = hero.MaxLife;
            }
            else
            {
                hero.Life += 50;
            }

            if((hero.Mana += 30) > hero.MaxMana)
            {
                hero.Mana = hero.MaxMana;
            }
            else
            {
                hero.Mana += 30;
            }

            hero.Effects.Add(new DamageIncreased(3, 10));
            hero.Effects.Add(new DefendIncreased(3, 5));
        }
    }
}
