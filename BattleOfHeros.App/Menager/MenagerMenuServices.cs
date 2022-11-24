using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.App.Concrete;
using BattleOfHeroes.App.Helpers;
using BattleOfHeroes.Domain.Concrete;

namespace BattleOfHeroes.App.Menager
{
    public class MenagerMenuServices
    {
        public List<Menu> menuList { get; set; }

        public MenagerMenuServices()
        {
            menuList = new List<Menu>();
        }
        
        public void ListMenuView(MenuServices menuServices, string type)
        {
            menuList = menuServices.GetElements(type);
            foreach (Menu menu in menuList)
            {
                if(menu.MenuType == type)
                {
                    Console.WriteLine($"{menu.Id}. {menu.Name}");
                }
            }

            ServicesHelper.WriteQuestion();
        }
    }
}
