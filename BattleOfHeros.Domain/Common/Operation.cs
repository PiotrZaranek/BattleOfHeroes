using BattleOfHeroes.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Common
{
    public abstract class Operation : IOperation, IAction
    {
        public string Name { get; set; }
        public bool IsBlock { get; set; }        

        public abstract void Action(Hero hero, int value);
    }
}
