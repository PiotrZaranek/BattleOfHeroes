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
            NeedMana = 20;
            Type = 'P';
            IsActive = true;
            IsAura = false;
        }

        public override void Action(Hero hero, Hero target)
        {
            UpdateMana(hero);

            int check = target.Life + 75;
            if (check > target.MaxLife)
            {
                target.Life = target.MaxLife;
            }
            else
            {
                target.Life += 75;
            }
        }
    }
}
