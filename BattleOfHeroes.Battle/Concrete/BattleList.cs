using BattleOfHeroes.BattleApp.Abstract;
using BattleOfHeroes.BattleApp.Helper;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.BattleApp.Concrete
{
    public class BattleList : IBattleList
    {
        public List<PlayerMove> PlayersMoves { get; set; }

        public BattleList()
        {
            PlayersMoves = new List<PlayerMove>();
        }

        public void AddMove(int turn, Player player, Operation operation)
        {
            PlayerMove move = new PlayerMove(turn, player.PlayerName, player.Move.Hero.Name, operation.Name);
            PlayersMoves.Add(move);
        }

        public void AddMove(int turn, Player player, Skill skill)
        {
            PlayerMove move = new PlayerMove(turn, player.PlayerName, player.Move.Hero.Name, skill.Name);
            PlayersMoves.Add(move);
        }

        public void AddMove(int turn, Player player, string message)
        {
            PlayerMove move = new PlayerMove(turn, player.PlayerName, "", message);
            PlayersMoves.Add(move);
        }

        public void AddMove(int turn, Player player, Hero hero)
        {
            PlayerMove move = new PlayerMove(turn, player.PlayerName, hero.Name, "Umiera!");
            PlayersMoves.Add(move);
        }

        public void ListMoves()
        {
            Console.Clear();
            BattleHelper.Legend();

            foreach (var move in PlayersMoves)
            {
                if (move.Turn % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    move.ShowMove();
                    Console.Write("\n");
                }
                else
                { 
                    Console.ForegroundColor = ConsoleColor.White;
                    move.ShowMove();
                    Console.Write("\n");
                }                
            }

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
