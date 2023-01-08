using BattleOfHeroes.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.BattleApp.Concrete
{
    public class BattleStory : IBattleStory
    {
        public int Id { get; set; }
        public string PlayerOne { get; set; }
        public string PlayerTwo { get; set; }
        public BattleList BattleList { get; set; }

        public BattleStory(int id, string po, string pt, BattleList bl)
        {
            Id = id;
            PlayerOne = po;
            PlayerTwo = pt;
            BattleList = bl;
        }
    }
}
