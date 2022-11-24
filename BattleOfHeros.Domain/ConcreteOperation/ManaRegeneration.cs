using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteOperation
{
    internal class ManaRegeneration : Operation
    {
        public ManaRegeneration()
        {
            Name = "Regeneracja many";
            IsBlock = false;
            Time = 0;
        }

        public override void Action(Hero hero, int value)
        {
            if (IsBlock == false)
            {
                if ((hero.Mana += value) > hero.MaxMana)
                {
                    hero.Mana = hero.MaxMana;
                }
                else
                {
                    hero.Mana += value;
                }
            }
            else
            {
                Time--;
                if (Time == 0)
                {
                    IsBlock = false;
                }
            }            
        }
    }
}
