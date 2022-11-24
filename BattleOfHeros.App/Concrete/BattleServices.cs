using BattleOfHeroes.App.Menager;
using BattleOfHeroes.Domain.Concrete;
using BattleOfHeroes.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.App.Concrete
{
    public class BattleServices
    {
        public int GameMode { get; set; }

        public void ChooseHeroPlayer(List<Hero> heroes, int id, PlayerServices playerServices)
        {
            playerServices.Elements[id].Heroes = heroes;
        }

        public Battle CreateBattle(PlayerServices playerServices)
        {
            return new Battle(playerServices.Elements);
        }

        public void StartBattle(Battle battle, MenagerBattleServices menagerBattleServices)
        {
            menagerBattleServices.ListAllHeros(battle);            
            menagerBattleServices.SelectHero(battle.Players[0]);
            menagerBattleServices.SelectTarget(battle.Players[0], battle.Players[1]);
            menagerBattleServices.SelectHero(battle.Players[1]);
            menagerBattleServices.SelectTarget(battle.Players[1], battle.Players[0]);
            


            Console.ReadKey();
        }

        
    }
}
