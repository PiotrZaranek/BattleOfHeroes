using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteEffect;
using BattleOfHeroes.Domain.ConcreteHero;
using Xunit.Sdk;

namespace BattleOfHeroes.UnitTests.DomainTests.ConcreteEffectTests
{
    public class DefendIncreasedTests
    {
        [Fact]
        public void DefendIncreasedActive_HeroDefend_Expect_DefendIncreasedByValue()
        {
            Hero hero = new Paladin(1);
            Effect effect = new DefendIncreased(1, 1);
            int basicDefend = hero.Defend;
            effect.Active(hero);

            Assert.Equal(basicDefend + 1, hero.Defend);
        }

        [Fact]
        public void DefendIncreasedExecute_EffectTime_Execute_DecrementTimeProp()
        {
            Hero hero = new Paladin(1);
            Effect effect = new DefendIncreased(3, 1);

            effect.Execute(hero);

            Assert.Equal(3, effect.Time);
        }

        [Fact]
        public void DefendIncreasedExecute_EffectTimeEqual1_Execute_TimeEqual0AndRunDeactiveateMethod()
        {
            Hero hero = new Paladin(1);
            Effect effect = new DefendIncreased(0, 1);
            int basicDefend = hero.Defend;

            effect.Active(hero);
            effect.Execute(hero);            

            Assert.Equal(0, effect.Time);
            Assert.Equal(basicDefend, hero.Defend);
        }

        [Fact]
        public void DefendIncreasedDeactivate_HeroDefend_Expect_DefendReducedByValue()
        {
            Hero hero = new Paladin(1);
            Effect effect = new DefendIncreased(1, 1);
            int basicDefend = hero.Defend;

            effect.Active(hero);
            effect.Deactivate(hero);

            Assert.Equal(basicDefend, hero.Defend);            
        }
    }
}
