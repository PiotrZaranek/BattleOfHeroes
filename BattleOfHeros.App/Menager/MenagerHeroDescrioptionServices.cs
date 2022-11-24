using BattleOfHeroes.App.Concrete;
using BattleOfHeroes.App.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.App.Menager
{
    public class MenagerHeroDescriptionServices
    {
        public void DescriptionView(HeroDescriptionServices heroDescriptionServices ,char id)
        {
            Console.Clear();
            foreach (var item in heroDescriptionServices.Elements)
            {
                if((char)item.Id == id)
                {
                    Console.WriteLine(item.GetTextFromFile());           
                }
            }
            Console.ReadKey();
        }        
    }
}
