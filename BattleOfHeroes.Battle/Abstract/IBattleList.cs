using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.BattleApp.Abstract
{
    internal interface IBattleList
    {
        List<PlayersMoves> PlayersMoves { get; set; }

        void AddMove(int turn, Player player, Operation operation);
        void AddMove(int turn, Player player, Skill skill);
        void AddMove(int turn, Player player, string message);

        void ListMoves();
    }
}
