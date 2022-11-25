using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteEffect;

namespace BattleOfHeroes.Domain.ConcreteSkill.KeeperOfTheGrove
{
    internal class Entangling : Skill
    {
        public Entangling(int id)
        {
            Id = id;
            Name = "Splątanie";
            NeedMana = 30;
            Type = 'A';
            IsActive = true;
        }

        public override void Action(Hero hero)
        {
            hero.Effects.Add(new Entangl(3, 14));
        }
    }
}
