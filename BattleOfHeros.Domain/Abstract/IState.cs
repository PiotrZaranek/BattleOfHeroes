using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Abstract
{
    public interface IState
    {
        string Name { get; set; }
        int Time { get; set; }
        char Type { get; set; }
        ConsoleColor Color { get; set; }
        void Execute();        
    }
}
