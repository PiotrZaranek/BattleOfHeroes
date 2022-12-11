using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteOperation
{
    public class ManaRegeneration : Operation
    {
        public ManaRegeneration()
        {
            Name = "Regeneracja many";
            IsActive = true;
            Type = 'C';
        }

        public override void Action(Hero hero, int value)
        {
            if (IsActive == true)
            {
                int chceck = hero.Mana + value;

                if (chceck > hero.MaxMana)
                {
                    hero.Mana = hero.MaxMana;
                }
                else
                {
                    hero.Mana = chceck;
                }
            }          
        }
    }
}
