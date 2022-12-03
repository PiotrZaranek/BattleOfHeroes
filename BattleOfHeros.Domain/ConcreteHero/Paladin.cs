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
            Life = 275;
            Mana = 60;
            Damage = 22;
            Defend = 5;
            ManaRegeneration = 2;
            MaxLife = 225;
            MaxMana = 60;
            Operations = new List<Operation>();
            Skills = new List<Skill>();
            Effects = new List<Effect>();
            States = new List<State>();
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
