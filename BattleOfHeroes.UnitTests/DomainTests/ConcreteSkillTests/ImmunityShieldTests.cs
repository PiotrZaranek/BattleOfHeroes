using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteHero;
using BattleOfHeroes.Domain.ConcreteSkill.Paladin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.UnitTests.DomainTests.ConcreteSkillTests
{
    public class ImmunityShieldTests
    {
        [Fact]
        public void ImmunityShieldAction_HeroMana_Expect_ReducedBySkillNeedMana()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new ImmunityShield(1);

            skill.Action(hero, target);

            Assert.Equal(hero.MaxMana - skill.NeedMana, hero.Mana);
        }

        [Fact]
        public void ImmunityShieldAction_TargetStates_Expect_AddImmunityState()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new ImmunityShield(1);

            skill.Action(hero, target);

            Assert.Equal(1, target.States.Count);
        }
    }
}
