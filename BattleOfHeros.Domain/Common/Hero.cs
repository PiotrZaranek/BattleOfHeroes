using BattleOfHeroes.Domain.Abstract;
using BattleOfHeroes.Domain.Concrete;
using BattleOfHeroes.Domain.ConcreteOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Domain.Common
{
    public abstract class Hero : IHero
    {
        public int Id { get; set; }
        public int Life { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }
        public int Defend { get; set; }
        public int ManaRegeneration { get; set; }
        public string Name { get; set; }
        public int MaxLife { get; set; }
        public int MaxMana { get; set; }      
        public Player Owner { get; set; }


        public List<Operation> Operations { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Effect> Effects { get; set; }
        public List<State> States { get; set; }
                 
        public void ShowStatistic()
        {
            Console.WriteLine($"[{Id}]");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Nazwa: {Name}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Życie: {Life}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Mana: {Mana}");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Atak: {Damage - 5} - {Damage}");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Obrona: {Defend}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Stan:");
            foreach (var state in States)
            {
                Console.ForegroundColor = state.Color;
                Console.WriteLine($"\t{state.Name}: {state.Time}");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("Efekty:");
            foreach (var effect in Effects)
            {
                Console.ForegroundColor = effect.Color;
                Console.WriteLine($"\t{effect.Name}: {effect.Time}");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("Umiejętności:");
            foreach (var skill in Skills)
            {
                if(skill.IsAura)
                {
                    Console.WriteLine($"\t{skill.Name}");
                }
                else
                {
                    Console.WriteLine($"\t{skill.Name} Mana: {skill.NeedMana}");
                }                
            }

        }

        protected void AddOperations()
        {
            Operations.Add(new Attack(1));
            Operations.Add(new ManaRegeneration());
        }

        public bool IsDead()
        {
            if(Life <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public void DeleteEffect()
        {
            List<Effect> ToDelete = new List<Effect>();

            foreach (var effect in Effects)
            {
                if(effect.Time == 0)
                {
                    ToDelete.Add(effect);
                }
            }

            foreach (var effect in ToDelete)
            {
                Effects.Remove(effect);
            }
        }

        protected abstract void AddSkills();
    }
}
