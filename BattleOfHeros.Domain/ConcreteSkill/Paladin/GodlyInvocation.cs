using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteEffect;

namespace BattleOfHeroes.Domain.ConcreteSkill.Paladin
{
    public class GodlyInvocation : Skill
    {
        public GodlyInvocation(int id)
        {
            Id = id;
            Name = "Boskie wezwanie";
            NeedMana = 50;
            Type = 'P';
            IsActive = true;
            IsAura = false;
        }

        public override void Action(Hero hero, Hero target)
        {
            UpdateMana(hero);
            int check = target.Life + 50;

            if (check > target.MaxLife)
            {
                target.Life = target.MaxLife;
            }
            else
            {
                target.Life += 50;
            }

            check = target.Mana + 30;

            if(check > target.MaxMana)
            {
                target.Mana = target.MaxMana;
            }
            else
            {
                target.Mana += 30;
            }

            Effect effect = new DamageIncreased(3, 7);
            target.Effects.Add(effect);
            effect.Active(target);

            effect = new DefendIncreased(3, 3);
            target.Effects.Add(effect);
            effect.Active(target);
        }
    }
}
