using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.Concrete;
using BattleOfHeroes.Domain.ConcreteHero;
using BattleOfHeroes.BattleApp.Concrete;
using FluentAssertions;

namespace BattleOfHeroes.UnitTests.BattleAppTests.Concrete
{
    public class BattleListTest
    {
        [Fact]
        public void BattleListAddMove_BattleListPlayersMovesWithOperationArgument_Expect_AddMoveToPlayersMoves()
        {
            BattleList battleList = new BattleList();
            Player player = new Player(1, "player");
            Hero hero = new Paladin(1);

            player.Move.Hero = hero;
            battleList.AddMove(1, player, hero.Operations[0]);

            battleList.PlayersMoves.Count.Should().Be(1);
            battleList.PlayersMoves[0].Turn.Should().Be(1);
            battleList.PlayersMoves[0].PlayerName.Should().Be(player.PlayerName);
            battleList.PlayersMoves[0].HeroName.Should().Be(hero.Name);
            battleList.PlayersMoves[0].Action.Should().Be(hero.Operations[0].Name);
        }

        [Fact]
        public void BattleListAddMove_BattleListPlayersMovesWithSkillArgument_Expect_AddMoveToPlayersMoves()
        {
            BattleList battleList = new BattleList();
            Player player = new Player(1, "player");
            Hero hero = new Paladin(1);

            player.Move.Hero = hero;
            battleList.AddMove(1, player, hero.Skills[0]);

            battleList.PlayersMoves.Count.Should().Be(1);
            battleList.PlayersMoves[0].Turn.Should().Be(1);
            battleList.PlayersMoves[0].PlayerName.Should().Be(player.PlayerName);
            battleList.PlayersMoves[0].HeroName.Should().Be(hero.Name);
            battleList.PlayersMoves[0].Action.Should().Be(hero.Skills[0].Name);
        }

        [Fact]
        public void BattleListAddMove_BattleListPlayersMovesWithMessageArgument_Expect_AddMoveToPlayersMoves()
        {
            BattleList battleList = new BattleList();
            Player player = new Player(1, "player");

            battleList.AddMove(1, player, "Pomija turę!");

            battleList.PlayersMoves.Count.Should().Be(1);
            battleList.PlayersMoves[0].Turn.Should().Be(1);
            battleList.PlayersMoves[0].PlayerName.Should().Be(player.PlayerName);
            battleList.PlayersMoves[0].Action.Should().Be("Pomija turę!");
        }

        [Fact]
        public void BattleListAddMove_BattleListPlayersMovesWithHeroArgument_Expect_AddMoveToPlayersMoves()
        {
            BattleList battleList = new BattleList();
            Player player = new Player(1, "player");
            Hero hero = new Paladin(1);

            battleList.AddMove(1, player, hero);

            battleList.PlayersMoves.Count.Should().Be(1);
            battleList.PlayersMoves[0].Turn.Should().Be(1);
            battleList.PlayersMoves[0].PlayerName.Should().Be(player.PlayerName);
            battleList.PlayersMoves[0].HeroName.Should().Be(hero.Name);
            battleList.PlayersMoves[0].Action.Should().Be("Umiera!");
        }
    }
}
