using BattleOfHeroes.App.Menager;
using BattleOfHeroes.App.Concrete;
using BattleOfHeroes.Helpers;
using BattleOfHeroes.Domain.Concrete;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.Domain.ConcreteHero;
using BattleOfHeroes.Domain.ConcreteSkill.Paladin;

namespace BattleOfHeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 60;
            bool ExitGame = false;
            Console.Title = "Battle Of Heroes";           
            MenuServices menuServices = new MenuServices();
            HeroDescriptionServices heroDescriptionServices = new HeroDescriptionServices();
            PlayerServices playerServices;
            BattleServices battleServices = new BattleServices();
            MenagerMenuServices menagerMenuServices = new MenagerMenuServices();
            MenagerHeroDescriptionServices menagerHeroDescriptionServices = new MenagerHeroDescriptionServices();
            MenagerPlayerServices menagerPlayerServices = new MenagerPlayerServices();
            MenagerBattleServices menagerBattleServices = new MenagerBattleServices();

            
            while (ExitGame == false)
            {
                Console.Clear();
                MainMenuHelper.WriteTitle();
                menagerMenuServices.ListMenuView(menuServices, "Main");
                
                char choose = Console.ReadKey().KeyChar;

                switch (choose)
                {
                    case '1':
                        {
                            Console.Clear();
                            playerServices = new PlayerServices();
                            battleServices.GameMode = menagerBattleServices.ChooseGameMode(menuServices, menagerMenuServices) - '0';
                            battleServices.ChooseHeroPlayer(menagerBattleServices.ChooseHero(menuServices, menagerMenuServices, playerServices.Elements[0].PlayerName, battleServices.GameMode), 0, playerServices);
                            battleServices.ChooseHeroPlayer(menagerBattleServices.ChooseHero(menuServices, menagerMenuServices, playerServices.Elements[1].PlayerName, battleServices.GameMode), 1, playerServices);
                            battleServices.StartBattle(battleServices.CreateBattle(playerServices), menagerBattleServices);
                            Console.ReadKey();
                            break;
                        }
                    case '2':
                        {
                            Console.Clear();
                            menagerMenuServices.ListMenuView(menuServices, "Hero");
                            choose = Console.ReadKey().KeyChar;
                            menagerHeroDescriptionServices.DescriptionView(heroDescriptionServices, choose);                            
                            break;
                        }
                    case '3':
                        {
                            ExitGame = true;
                            MainMenuHelper.GoodBye();
                            break;
                        }
                    default:
                        {
                            MainMenuHelper.WrongOperation();
                            break;
                        }                       
                }
            }

        }
    }
}