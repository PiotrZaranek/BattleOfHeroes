using BattleOfHeroes.App.Concrete;
using BattleOfHeroes.App.Helpers;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.App.Menager
{
    public class MenagerPlayerServices
    {
        public static Player CreatePlayer(int id, List<Player> ele)
        {
            string playerName;

            while (true)
            {
                Console.Clear();
                ServicesHelper.PlayerName(id);
                playerName = Console.ReadLine();
                
                if(playerName.Count() < 3)
                {
                    ServicesHelper.TooShortName();
                    continue;
                }

                Player player = new Player(id, playerName);
                return player;
            }            
        }        
    }
}
