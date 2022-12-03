using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Abstract;

namespace BattleOfHeroes.Domain.Concrete
{
    public class PlayersMoves : IPlayersMoves
    {
        public int Turn { get; }
        public string PlayerName { get; }
        public string HeroName { get; }
        public string Action { get; }

        public PlayersMoves(int turn, string playerName, string heroName, string action)
        {
            Turn = turn;
            PlayerName = playerName;
            HeroName = heroName;
            Action = action;
        }

        public void ShowMove()
        {
            Console.Write($"|{Turn}-{PlayerName}-{HeroName}-{Action}|");
        }
    }
}
