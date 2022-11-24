using BattleOfHeroes.App.Common;
using BattleOfHeroes.Domain.Concrete;
using BattleOfHeroes.App.Menager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BattleOfHeroes.App.Concrete
{
    public class PlayerServices : PrimaryServices<Player>
    {
        public PlayerServices()
        {
            Elements = new List<Player>();
            Initialize();
        }

        protected override void Initialize()
        {
            AddElement(MenagerPlayerServices.CreatePlayer(1, Elements));
            AddElement(MenagerPlayerServices.CreatePlayer(2, Elements));
        }
    }
}
