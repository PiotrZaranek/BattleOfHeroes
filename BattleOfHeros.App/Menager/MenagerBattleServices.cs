using BattleOfHeroes.App.Concrete;
using BattleOfHeroes.App.Helpers;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.Concrete;
using BattleOfHeroes.Domain.ConcreteHero;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace BattleOfHeroes.App.Menager
{
    public class MenagerBattleServices
    {
        public char ChooseGameMode(MenuServices menuServices, MenagerMenuServices menagerMenuServices)
        {
            char mode = '0';
            while (true)
            {
                Console.Clear();
                menagerMenuServices.ListMenuView(menuServices, "GameMode");
                mode = Console.ReadKey().KeyChar;
                if(mode == '1' || mode == '2')
                {
                    return mode;
                }
                else
                {
                    ServicesHelper.BadChoose();
                    continue;
                }
            }
        }

        public List<Hero> ChooseHero(MenuServices menuServices, MenagerMenuServices menagerMenuServices, string playerName, int count, int IdNumber)
        {
            List<Hero> heros = new List<Hero>();
            int i = 1;
            char firstChoose = '0';
            while (i <= count)
            {
                Console.Clear();
                Console.WriteLine($"{playerName} {i}.");
                menagerMenuServices.ListMenuView(menuServices, "Hero");
                char choosen = Console.ReadKey().KeyChar;                
                
                if(choosen == firstChoose)
                {
                    ServicesHelper.SecondHero();
                    continue;
                }

                switch (choosen)
                {
                    case '1':
                        {
                            Hero hero = new KeeperOfTheGrove(IdNumber);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;
                            IdNumber++;
                            break;
                        }
                    case '2':
                        {
                            Hero hero = new Paladin(IdNumber);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;
                            IdNumber++;
                            break;
                        }
                    case '3':
                        {
                            Hero hero = new Paladin(IdNumber);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;
                            IdNumber++;
                            break;
                        }
                    case '4':
                        {
                            Hero hero = new Paladin(IdNumber);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;
                            IdNumber++;
                            break;
                        }
                    case '5':
                        {
                            Hero hero = new Paladin(IdNumber);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;
                            IdNumber++;
                            break;
                        }
                    case '6':
                        {
                            Hero hero = new Paladin(IdNumber);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;
                            IdNumber++;
                            break;
                        }
                    default:
                        {
                            ServicesHelper.BadChoose();
                            break;
                        }                        
                }
            }

            return heros;
        }
    }
}
