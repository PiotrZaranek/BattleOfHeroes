using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteEffect;
using BattleOfHeroes.Domain.ConcreteOperation;
using BattleOfHeroes.Domain.ConcreteSkill.Paladin;

namespace BattleOfHeroes.Domain.ConcreteHero
{
    public class Paladin : Hero
    {
        public Paladin(int id)
        {
            Id= id;
            Name = "Paladyn";
            Life = 550;
            Mana = 120;
            Damage = 45;
            Defend = 10;
            ManaRegeneration = 4;
            MaxLife = 550;
            MaxMana = 120;
            Operations = new List<Operation>();
            Skills = new List<Skill>();
            Effects = new List<Effect>();
            AddOperations();
            AddSkills();
        }

        protected override void AddSkills()
        {
            Skills.Add(new HolyLight(2));
            Skills.Add(new ImmunityShield(3));
            Skills.Add(new GodlyInvocation(4));
        }
    }
}
