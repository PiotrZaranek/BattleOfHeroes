using BattleOfHeroes.Domain.Abstract;
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

        public List<Operation> Operations { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Effect> Effects { get; set; }
                 
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

            Console.WriteLine("Efekty:");
            foreach (var effect in Effects)
            {
                Console.WriteLine($"\t{effect.Name}: {effect.Time}");
            }

            Console.WriteLine("Umiejętności:");
            foreach (var skill in Skills)
            {
                if(skill.Type == 'C')
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
            Operations.Add(new Attack());
            Operations.Add(new ManaRegeneration());
        }

        protected abstract void AddSkills();
    }
}
