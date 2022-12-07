using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteHero;
using BattleOfHeroes.Domain.ConcreteSkill.Paladin;

namespace BattleOfHeroes.UnitTests.DomainTests.ConcreteSkillTests
{
    public class HolyLightTests
    {
        [Fact]
        public void HolyLightAction_HeroMana_Expect_ReducedBySkillNeedMana()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new HolyLight(1);

            skill.Action(hero, target);

            Assert.Equal(hero.MaxMana - skill.NeedMana, hero.Mana);
        }

        [Fact]
        public void HolyLightAction_TargetLife_Expect_LifeInceasedBy75()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new HolyLight(1);

            target.Life -= 150;
            skill.Action(hero, target);

            Assert.Equal(175, target.Life );
        }

        [Fact]
        public void HolyLightAction_TargetLifeIsFull_Expect_LifeEqualMaxLife()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new HolyLight(1);

            skill.Action(hero, target);

            Assert.Equal(target.MaxLife, target.Life);
        }

        [Fact]
        public void HolyLightAction_TargetLifeReducedBy1_Expect_LifeEqualMaxLife()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new HolyLight(1);

            target.Life -= 1;
            skill.Action(hero, target);

            Assert.Equal(target.MaxLife, target.Life);
        }
    }
}
