using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteHero;
using BattleOfHeroes.Domain.ConcreteEffect;
using Xunit.Sdk;
using System.ComponentModel.DataAnnotations;

namespace BattleOfHeroes.UnitTests.DomainTests.ConcreteEffectTests
{
    public class EntanglTests
    {
        [Fact]
        public void EntanglActive_HeroOperations_Expect_AttackOperationIsActiveIsFalse()
        {
            Hero hero = new Paladin(1);
            Effect effect = new Entangl(1,1);

            effect.Active(hero);

            Assert.False(hero.Operations[0].IsActive);
        }

        [Fact]
        public void EntanglExecute_EffectTimeHeroLife_Expect_DecremetTimeAndLifeReducedByValue()
        {
            Hero hero = new Paladin(1);
            Effect effect = new Entangl(3, 10);            

            effect.Active(hero);
            effect.Execute(hero);

            Assert.Equal(hero.MaxLife - 10, hero.Life);
            Assert.Equal(3, effect.Time);
        }

        [Fact]
        public void EntanglDeactivate_HeroOperation_Expect_AttackOperatrionIsActiveIsTrue()
        {
            Hero hero = new Paladin(1);
            Effect effect = new Entangl(1, 1);

            effect.Active(hero);
            effect.Deactivate(hero);

            Assert.True(hero.Operations[0].IsActive);
        }
    }
}
