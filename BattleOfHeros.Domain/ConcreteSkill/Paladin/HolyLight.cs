using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteSkill.Paladin
{
    public class HolyLight : Skill
    {
        public HolyLight(int id)
        {
            Id = id;
            Name = "Święty Blask";
            NeedMana = 40;
            Type = 'P';
            IsActive = true;
        }

        public override void Action(Hero hero)
        {
            if ((hero.Life += 75) > hero.MaxLife)
            {
                hero.Life = hero.MaxLife;
            }
            else
            {
                hero.Life += 75;
            }
        }
    }
}
