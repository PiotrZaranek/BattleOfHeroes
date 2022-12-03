using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;

namespace BattleOfHeroes.Domain.ConcreteOperation
{
    internal class Attack : Operation
    {
        public Attack(int id)
        {
            Id = id;
            Name = "Atak";
            IsActive = true;
            Type = 'A';
        }

        public override void Action(Hero hero, int value)
        {
            if (IsActive == true)
            {
                Random r = new Random();
                value = r.Next(value - 5, value + 1);
                hero.Life -= (value - hero.Defend);
            }            
        }
    }
}
