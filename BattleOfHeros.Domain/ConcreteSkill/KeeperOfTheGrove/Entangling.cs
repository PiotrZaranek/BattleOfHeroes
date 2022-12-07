using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteEffect;

namespace BattleOfHeroes.Domain.ConcreteSkill.KeeperOfTheGrove
{
    public class Entangling : Skill
    {
        public Entangling(int id)
        {
            Id = id;
            Name = "Splątanie";
            NeedMana = 15;
            Type = 'A';
            IsActive = true;
            IsAura = false;
        }

        public override void Action(Hero hero, Hero target)
        {
            UpdateMana(hero);

            Entangl entangl = new Entangl(3, 14);
            target.Effects.Add(entangl);
            entangl.Active(target);
        }
    }
}
