﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteEffect;
using BattleOfHeroes.Domain.ConcreteSkill.KeeperOfTheGrove;

namespace BattleOfHeroes.Domain.ConcreteHero
{
    public class KeeperOfTheGrove : Hero
    {
        public KeeperOfTheGrove(int id)
        {
            Id = id;
            Name = "Strażnik Gaju";
            Life = 500;
            Mana = 200;
            Damage = 30;
            Defend = 5;
            ManaRegeneration = 8;
            MaxLife = 500;
            MaxMana = 200;
            Operations = new List<Operation>();
            Skills = new List<Skill>();
            Effects = new List<Effect>();
            AddOperations();
            AddSkills();
        }

        protected override void AddSkills()
        {
            Skills.Add(new Entangling(2));            
            Skills.Add(new SupportWoodGhost(3));
            Skills.Add(new ThornsAura(4));
        }
    }
}
