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

        public List<Hero> ChooseHero(MenuServices menuServices, MenagerMenuServices menagerMenuServices, string playerName, int count)
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
                            Hero hero = new KeeperOfTheGrove(i);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;                            
                            break;
                        }
                    case '2':
                        {
                            Hero hero = new Paladin(i);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;
                            break;
                        }
                    case '3':
                        {
                            Hero hero = new Paladin(i);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;
                            break;
                        }
                    case '4':
                        {
                            Hero hero = new Paladin(i);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;
                            break;
                        }
                    case '5':
                        {
                            Hero hero = new Paladin(i);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;
                            break;
                        }
                    case '6':
                        {
                            Hero hero = new Paladin(i);
                            heros.Add(hero);
                            firstChoose = choosen;
                            i++;
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

        public void ListAllHeros(Battle battle)
        {
            Console.Clear();
            foreach (var plyer in battle.Players)
            {
                Console.WriteLine(plyer.PlayerName);
                Console.WriteLine("------------------------------------------------------------");
                foreach (var hero in plyer.Heroes)
                {
                    hero.ShowStatistic();
                    Console.Write("\n");
                }
                Console.WriteLine("------------------------------------------------------------");
            }
            Console.ReadKey();
        }

        private void ListPlayerHeroes(Player player)
        {
            Console.Clear();
            Console.WriteLine(player.PlayerName);
            Console.WriteLine("------------------------------------------------------------");
            foreach (var hero in player.Heroes)
            {
                hero.ShowStatistic();
            }
            Console.WriteLine("------------------------------------------------------------");
        }

        private Hero GetHero(Player player, string name)
        {
            int choose;
            Hero find;

            while (true)
            {
                ListPlayerHeroes(player);
                Console.WriteLine($"Teraz tura {name}");
                ServicesHelper.SelectHero();
                try
                {
                    choose = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    ServicesHelper.GiveIdHero();
                    continue;
                }
               
                find = null;

                foreach (var hero in player.Heroes)
                {
                    if (choose == hero.Id)
                    {
                        find = hero;
                    }
                }

                if (find == null)
                {
                    ServicesHelper.GiveIdHero();
                    continue;
                }
                else
                {
                    break;
                }
            }

            return find;
        }

        public void SelectHero(Player player)
        {
            player.Hero = GetHero(player, player.PlayerName);          
        }

        public void SelectTarget(Player player, Player enemy)
        {
           player.Target = GetHero(enemy, player.PlayerName);
        }
    }
}
