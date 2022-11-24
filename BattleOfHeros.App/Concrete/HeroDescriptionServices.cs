using BattleOfHeroes.App.Common;
using BattleOfHeroes.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.App.Concrete
{
    public class HeroDescriptionServices : PrimaryServices<HeroDescription>
    {
        public HeroDescriptionServices()
        {
            Elements = new List<HeroDescription>();
            Initialize();
        }

        protected override void Initialize()
        {
            AddElement(new HeroDescription('1', "Strażnik Gaju", @"..\..\..\Description\CeeperOfTheGrove.txt"));
            AddElement(new HeroDescription('2', "Paladyn", @"..\..\..\Description\Paladin.txt"));
        }
    }
}
