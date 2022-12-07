using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteHero;
using BattleOfHeroes.Domain.ConcreteSkill.KeeperOfTheGrove;

namespace BattleOfHeroes.UnitTests.DomainTests.ConcreteSkillTests
{
    public class EntanglingTests
    {
        [Fact]
        public void EntanglingAction_HeroMana_Expect_ReducedBySkillNeedMana()
        {
            Hero hero = new KeeperOfTheGrove(1);
            Hero target = new Paladin(1);
            Skill skill = new Entangling(1);

            skill.Action(hero, target);

            Assert.Equal(hero.MaxMana - skill.NeedMana, hero.Mana);
        }

        [Fact]
        public void EntanglingAction_TargetEffects_Expect_AddEntanglEffect()
        {
            Hero hero = new KeeperOfTheGrove(1);
            Hero target = new Paladin(1);
            Skill skill = new Entangling(1);

            skill.Action(hero, target);

            Assert.NotEmpty(target.Effects);
        }

        [Fact]
        public void EntanglingAction_TargetOperations_Expect_AttackIsActivePropertyIsFalse()
        {

            Hero hero = new KeeperOfTheGrove(1);
            Hero target = new Paladin(1);
            Skill skill = new Entangling(1);

            skill.Action(hero, target);

            Assert.False(target.Operations[0].IsActive);
        }
    }
}
