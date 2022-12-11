using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteHero;
using BattleOfHeroes.Domain.ConcreteOperation;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.UnitTests.DomainTests.ConcreteOperationTests
{
    public class ManaRegenerationTests
    {
        [Fact]
        public void ManaRegenerationAction_OperationIsActiveIsFalseHeroManaReducedTo10_Expect_NoHeroManaChanges()
        {
            Hero hero = new Paladin(1);
            Operation oper = new ManaRegeneration();
            int currentMana = 10;

            hero.Mana = currentMana;
            oper.IsActive = false;
            oper.Action(hero, 10);

            hero.Mana.Should().Be(currentMana);
        }

        [Fact]
        public void ManaregenerationAction_HeroManaReducedTo10_Expect_ManaIncreaseByHeroManaRegeneration()
        {
            Hero hero = new Paladin(1);
            Operation oper = new ManaRegeneration();

            hero.Mana = 10;
            oper.Action(hero, hero.ManaRegeneration);

            hero.Mana.Should().Be(10 + hero.ManaRegeneration);
        }

        [Fact]
        public void ManaRegenerationAction_HeroManaIsFull_Expect_ManaNoChanges()
        {
            Hero hero = new Paladin(1);
            Operation oper = new ManaRegeneration();

            oper.Action(hero, hero.ManaRegeneration);

            hero.Mana.Should().Be(hero.MaxMana);
        }

        [Fact]
        public void ManaRegenerationAction_HeroManaReducedBy1_Expect_ManaEqualHeroMaxMana()
        {
            Hero hero = new Paladin(1);
            Operation oper = new ManaRegeneration();

            hero.Mana -= 1;
            oper.Action(hero, hero.ManaRegeneration);

            hero.Mana.Should().Be(hero.MaxMana);
        }
    }

}
