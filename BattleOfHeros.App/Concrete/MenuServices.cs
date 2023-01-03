using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Concrete;
using BattleOfHeroes.App.Common;

namespace BattleOfHeroes.App.Concrete
{
    public class MenuServices : PrimaryServices<Menu>
    {
        public MenuServices()
        {
            Elements = new List<Menu>();
            Initialize();
        }
        
        protected override void Initialize()
        {
            AddElement(new Menu(1, "Graj", "Main"));
            AddElement(new Menu(2, "Księga bohaterów","Main"));
            AddElement(new Menu(3, "Historia walk","Main"));
            AddElement(new Menu(4, "Wyjdź z gry", "Main"));

            AddElement(new Menu(1, "Strażnik Gaju", "Hero"));
            AddElement(new Menu(2, "Paladyn", "Hero"));
            AddElement(new Menu(3, "Arcymag", "Hero"));
            AddElement(new Menu(4, "Wampir", "Hero"));
            AddElement(new Menu(5, "Dark Archer", "Hero"));
            AddElement(new Menu(6, "Blade Master", "Hero"));

            AddElement(new Menu(1, "Gra 1 vs 1", "GameMode"));
            AddElement(new Menu(2, "Gra 2 vs 2", "GameMode"));
        }
    }
}