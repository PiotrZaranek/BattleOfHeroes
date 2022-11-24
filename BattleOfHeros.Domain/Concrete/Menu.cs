using BattleOfHeroes.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Concrete
{
    public class Menu : IMenu
    {
        public int Id { get; }

        public string Name { get; }

        public string MenuType { get; }

        public Menu(int i, string name ,string type)
        {
            Id = i;
            Name = name;
            MenuType = type;
        }
    }
}
