using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteEffect;
using BattleOfHeroes.Domain.ConcreteHero;
using Xunit.Sdk;

namespace BattleOfHeroes.UnitTests.DomainTests.ConcreteEffectTests
{
    public class DamageIncreasedTests
    {
        [Fact]
        public void DamageIncreasedActive_HeroDamage_Expect_DamageIncreasedByValue()
        {
            Hero hero = new Paladin(1);
            Effect effect = new DamageIncreased(1, 1);
            int basicDamage = hero.Damage;
            effect.Active(hero);

            Assert.Equal(basicDamage + 1, hero.Damage);
        }

        [Fact]
        public void DamageIncreasedExecute_EffectTime_Execute_DecrementTimeProp()
        {
            Hero hero = new Paladin(1);
            Effect effect = new DamageIncreased(3, 1);

            effect.Execute(hero);

            Assert.Equal(3, effect.Time);
        }

        [Fact]
        public void DamageIncreasedExecute_EffectTimeEqual1_Execute_TimeEqual0AndRunDeactiveateMethod()
        {
            Hero hero = new Paladin(1);
            Effect effect = new DamageIncreased(0, 1);
            int basicDamage = hero.Damage;

            effect.Active(hero);
            effect.Execute(hero);            

            Assert.Equal(0, effect.Time);
            Assert.Equal(basicDamage, hero.Damage);
        }

        [Fact]
        public void DamageIncreasedDeactivate_HeroDamage_Expect_DamageReducedByValue()
        {
            Hero hero = new Paladin(1);
            Effect effect = new DamageIncreased(1, 1);
            int basicDamage = hero.Damage;

            effect.Active(hero);
            effect.Deactivate(hero);

            Assert.Equal(basicDamage, hero.Damage);            
        }
    }
}
