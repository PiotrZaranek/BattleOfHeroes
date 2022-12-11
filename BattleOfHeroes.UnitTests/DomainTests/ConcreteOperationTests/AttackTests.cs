using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteHero;
using BattleOfHeroes.Domain.ConcreteOperation;
using FluentAssertions;
using NuGet.Frameworks;

namespace BattleOfHeroes.UnitTests.DomainTests.ConcreteOperationTests
{
    public class AttackTests
    {
        [Fact]
        public void AttackAction_HeroLife_Expect_LifeReducedByFrom5To10()
        {
            Hero hero = new Paladin(1);
            Operation oper = new Attack(1);

            oper.Action(hero, 15);  

            hero.Life.Should().BeInRange(hero.MaxLife - 10, hero.MaxLife - 5);
        }

        [Fact]
        public void AttackAction_HeroLifeOperationIsActiveIsFalse_Expect_NoHeroLifeChanges()
        {
            Hero hero = new Paladin(1);
            Operation oper = new Attack(1);

            oper.IsActive = false;
            oper.Action(hero, 15);

            hero.Life.Should().Be(hero.MaxLife);
        }
    }
}
