using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteHero;
using BattleOfHeroes.Domain.ConcreteSkill;
using BattleOfHeroes.Domain.ConcreteSkill.KeeperOfTheGrove;
using BattleOfHeroes.Domain.ConcreteSkill.Paladin;
using System.Globalization;
using System.Net.Http.Headers;

namespace BattleOfHeroes.UnitTests.DomainTests.ConcreteSkillTests
{
    public class GodlyInvocationTests
    {
        [Fact]
        public void GodlyInvocationAction_HeroMana_Expect_ReducedBySkillNeedMana()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new GodlyInvocation(1);

            skill.Action(hero, target);

            Assert.Equal(hero.MaxMana - skill.NeedMana, hero.Mana);
        }

        [Fact]
        public void GodlyInvocationAction_TargetLife_Expect_LifeIncreasedBy50()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new GodlyInvocation(1);

            target.Life -= 200;
            skill.Action(hero, target);

            Assert.Equal(100, target.Life);
        }

        [Fact]
        public void GodlyInvocationAction_TargetMana_Expect_ManaIncreasedBy30()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new GodlyInvocation(1);

            target.Mana -= 50;
            skill.Action(hero, target);

            Assert.Equal(80, target.Mana);
        }

        [Fact]
        public void GodlyInvocationAction_TargetLifeIsFull_Expect_LifeNoChange()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new GodlyInvocation(1);
            
            skill.Action(hero, target);

            Assert.Equal(target.MaxLife, target.Life);
        }

        [Fact]
        public void GodlyInvocationAction_TargetLifeReducedBy1_Expect_LifeEqualMaxLife()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new GodlyInvocation(1);

            target.Life -= 1;
            skill.Action(hero, target);

            Assert.Equal(target.MaxLife, target.Life);
        }

        [Fact]
        public void GodlyInvocationAction_TargetManaIsFull_Expect_ManaNoChange()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new GodlyInvocation(1);

            skill.Action(hero, target);

            Assert.Equal(target.MaxMana, target.Mana);
        }

        [Fact]
        public void GodlyInvocationAction_TargetManaReducedBy1_Expect_ManaEqualMaxMana()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new GodlyInvocation(1);

            target.Mana -= 1;
            skill.Action(hero, target);

            Assert.Equal(target.MaxMana, target.Mana);
        }

        [Fact]
        public void GodlyInvocationAction_TargetEffects_Expect_AddIncreasedDefendAdnDamageEffect()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new GodlyInvocation(1);

            skill.Action(hero, target);

            Assert.Equal(2, target.Effects.Count);
        }

        [Fact]
        public void GodlyInvocationAction_TargetDemage_Expect_IncreasedDamageBy7()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new GodlyInvocation(1);
            int basicDamage = target.Damage;

            skill.Action(hero, target);

            Assert.Equal(basicDamage + 7, target.Damage);
        }

        [Fact]
        public void GodlyInvocationAction_TargetDefend_Expect_IncreasedDefendBy3()
        {
            Hero hero = new Paladin(1);
            Hero target = new KeeperOfTheGrove(1);
            Skill skill = new GodlyInvocation(1);
            int basicDefend = target.Defend;

            skill.Action(hero, target);

            Assert.Equal(basicDefend + 3, target.Defend);
        }
    }
}
