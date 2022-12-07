using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteHero;
using BattleOfHeroes.Domain.ConcreteSkill.KeeperOfTheGrove;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.UnitTests.DomainTests.ConcreteSkillTests
{
    public class SupportWoodGhostTests
    {
        [Fact]
        public void SupportWoodGhostAction_HeroMana_Expect_ReducedBySkillNeedMana()
        {
            Hero hero = new KeeperOfTheGrove(1);
            Hero target = new Paladin(1);
            Skill skill = new SupportWoodGhost(1);

            skill.Action(hero, target);

            Assert.Equal(hero.MaxMana - skill.NeedMana, hero.Mana);
        }

        [Fact]
        public void SupportWoodGhostAction_TargetEffects_Expect_AddDefendIncreasedEffect()
        {
            Hero hero = new KeeperOfTheGrove(1);
            Hero target = new Paladin(1);
            Skill skill = new SupportWoodGhost(1);

            skill.Action(hero, target);

            Assert.NotEmpty(target.Effects);
        }

        [Fact]
        public void SupportWoodGhostAction_HeroDefend_Expect_IncreasedDefend()
        {
            Hero hero = new KeeperOfTheGrove(1);            
            Skill skill = new SupportWoodGhost(1);

            skill.Action(hero, hero);

            Assert.Equal(8, hero.Defend);
        }
    }
}
