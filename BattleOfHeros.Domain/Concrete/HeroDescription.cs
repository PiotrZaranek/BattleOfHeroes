using BattleOfHeroes.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BattleOfHeroes.Domain.Concrete
{
    public class HeroDescription : IHeroDescription
    {
        public int Id { get; }
        public string Name { get; }
        public string Path { get; }

        public HeroDescription(int id, string heroName, string path)
        {
            Id = id;
            Name = heroName;
            Path = path;
        }
        public string GetTextFromFile()
        {
            StreamReader sr = new StreamReader(Path);
            return sr.ReadToEnd();
        }
    }
}
