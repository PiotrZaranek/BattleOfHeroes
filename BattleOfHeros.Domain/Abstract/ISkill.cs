using BattleOfHeroes.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Abstract
{
    internal interface ISkill
    {
        int Id { get; set; }
        string Name { get; }
        int NeedMana { get; }
        char Type { get; set; }
        bool IsActive { get; set; }
        bool IsAura { get; set; }

        void Action(Hero hero, Hero target);
        void UpdateMana(Hero hero);
    }
}
