using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteHero;
using BattleOfHeroes.Domain.ConcreteSkill.KeeperOfTheGrove;

namespace BattleOfHeroes.UnitTests.DomainTests.ConcreteSkillTests
{
    public class ThornsAuraTest
    {
        [Fact]
        public void ThornsAuraAction_TargetLife_Expect_LifeReducedBy10()
        {
            Hero hero = new KeeperOfTheGrove(1);
            Hero target = new Paladin(1);
            Skill skill = new ThornsAura(1);
            int expect = target.Life - 10;

            skill.Action(hero, target);

            Assert.Equal(expect, target.Life);
        }
    }
}
