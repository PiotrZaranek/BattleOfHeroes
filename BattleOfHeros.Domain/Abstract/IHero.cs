using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Abstract
{
    internal interface IHero
    {
        int Id { get; set; }
        int Life { get; set; }
        int Mana { get; set; }
        int Damage { get; set; }
        int Defend { get; set; }
        int ManaRegeneration { get; set; }
        string Name { get; set; }
        int MaxLife { get; set; }
        int MaxMana { get; set; }       
        Player Owner { get; set; }

        
        List<Operation> Operations { get; set; }
        List<Skill> Skills { get; set; }
        List<Effect> Effects { get; set; }
        
        void ShowStatistic();
        bool IsDead();
        void DeleteEffect();        
    }
}
