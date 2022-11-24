//using BattleOfHeroes.Domain.Common;
//using BattleOfHeroes.Domain.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BattleOfHeroes.BattleApp.Display
//{
//    internal static class Display
//    {
//        public static void HerosStatistics(Player playerOne, Player playerTwo)
//        {
//            Console.Clear();
//            if(playerOne.Heroes.Count == 1)
//            {
//                Console.ForegroundColor = ConsoleColor.Cyan;
//                Console.WriteLine(playerOne.PlayerName);
//                Console.WriteLine("------------------------------------------------------------");
//                Console.ForegroundColor = ConsoleColor.White;
//                Console.WriteLine("[1]");
//                playerOne.Heroes[0].ShowHeroStatistic();
//                Console.ForegroundColor = ConsoleColor.Cyan;
//                Console.WriteLine("------------------------------------------------------------");

//                Console.ForegroundColor = ConsoleColor.Magenta;
//                Console.WriteLine(playerTwo.PlayerName);
//                Console.WriteLine("------------------------------------------------------------");
//                Console.ForegroundColor = ConsoleColor.White;
//                Console.WriteLine("[1]");
//                playerTwo.Heroes[0].ShowHeroStatistic();
//                Console.ForegroundColor = ConsoleColor.Magenta;
//                Console.WriteLine("------------------------------------------------------------");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Cyan;
//                Console.WriteLine(playerOne.PlayerName);
//                Console.WriteLine("------------------------------------------------------------");
//                Console.ForegroundColor = ConsoleColor.White;
//                Console.WriteLine("[1]");
//                playerOne.Heroes[0].ShowHeroStatistic();
//                Console.Write("\n");
//                Console.WriteLine("[2]");
//                playerOne.Heroes[1].ShowHeroStatistic();
//                Console.ForegroundColor = ConsoleColor.Cyan;
//                Console.WriteLine("------------------------------------------------------------");

//                Console.ForegroundColor = ConsoleColor.Magenta;
//                Console.WriteLine(playerTwo.PlayerName);
//                Console.WriteLine("------------------------------------------------------------");
//                Console.ForegroundColor = ConsoleColor.White;
//                Console.WriteLine("[1]");
//                playerTwo.Heroes[0].ShowHeroStatistic();
//                Console.Write("\n");
//                Console.WriteLine("[2]");
//                playerTwo.Heroes[1].ShowHeroStatistic();
//                Console.ForegroundColor = ConsoleColor.Magenta;
//                Console.WriteLine("------------------------------------------------------------");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//        }

//        public static void HeroStatistic(Player player, int type)
//        {
//            Console.Clear();

//            if (type == 1)
//            {
//                if (player.Heroes.Count == 1)
//                {
//                    Console.ForegroundColor = ConsoleColor.Cyan;
//                    Console.WriteLine(player.PlayerName);
//                    Console.WriteLine("------------------------------------------------------------");
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.WriteLine("[1]");
//                    player.Heroes[0].ShowHeroStatistic();
//                    Console.ForegroundColor = ConsoleColor.Cyan;
//                    Console.WriteLine("------------------------------------------------------------");
//                    Console.ForegroundColor = ConsoleColor.White;
//                }
//                else
//                {
//                    Console.ForegroundColor = ConsoleColor.Cyan;
//                    Console.WriteLine(player.PlayerName);
//                    Console.WriteLine("------------------------------------------------------------");
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.WriteLine("[1]");
//                    player.Heroes[0].ShowHeroStatistic();
//                    Console.Write("\n");
//                    Console.WriteLine("[2]");
//                    player.Heroes[1].ShowHeroStatistic();
//                    Console.ForegroundColor = ConsoleColor.Cyan;
//                    Console.WriteLine("------------------------------------------------------------");
//                    Console.ForegroundColor = ConsoleColor.White;
//                }
//            }
//            else
//            {
//                if (player.Heroes.Count == 1)
//                {
//                    Console.ForegroundColor = ConsoleColor.Magenta;
//                    Console.WriteLine(player.PlayerName);
//                    Console.WriteLine("------------------------------------------------------------");
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.WriteLine("[1]");
//                    player.Heroes[0].ShowHeroStatistic();
//                    Console.ForegroundColor = ConsoleColor.Magenta;
//                    Console.WriteLine("------------------------------------------------------------");
//                    Console.ForegroundColor = ConsoleColor.White;
//                }
//                else
//                {
//                    Console.ForegroundColor = ConsoleColor.Magenta;
//                    Console.WriteLine(player.PlayerName);
//                    Console.WriteLine("------------------------------------------------------------");
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.WriteLine("[1]");
//                    player.Heroes[0].ShowHeroStatistic();
//                    Console.Write("\n");
//                    Console.WriteLine("[2]");
//                    player.Heroes[1].ShowHeroStatistic();
//                    Console.ForegroundColor = ConsoleColor.Magenta;
//                    Console.WriteLine("------------------------------------------------------------");
//                    Console.ForegroundColor = ConsoleColor.White;
//                }
//            }
//        }

//        public static void PlayerSelectHero(Player player)
//        {
//            char hero;
//            char approved;

//            while(true)
//            {
//                HeroStatistic(player, 1);
//                Console.WriteLine($"Teraz tura {player.PlayerName}!");
//                Console.WriteLine("Wybierz bohatera:");
//                hero = Console.ReadKey().KeyChar;

//                if((hero - '0') < player.Heroes.Count - 1 || (hero - '0') > player.Heroes.Count)
//                {
//                    Console.Clear();
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine("Nie ma bohatera o takim id!");
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.ReadKey();
//                    continue;
//                }

//                Console.WriteLine($"Wybrałeś {player.Heroes[(hero - '0') - 1].Name}");
//                Console.WriteLine("Kontynuować?");
//                Console.WriteLine("T(Tak) N(Nie)");
//                approved = Console.ReadKey().KeyChar;

//                if (approved == 'n')
//                {
//                    Console.Clear();
//                    continue;
//                }
//                else if(approved == 't')
//                {
//                    player.SelectHero = (hero - '0') - 1;
//                    break;
//                }
//                else
//                {
//                    Console.Clear();
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine("Podano złą operacje!");
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.ReadKey();
//                    Console.Clear();
//                    continue;
//                }
//            }                        
//        }

//        public static void PLayerSelectOperationsAndEnemyHero(Player player, Player enemy)
//        {
//            char enemyHero;
//            char approved;

//            while(true)
//            {
//                HeroStatistic(enemy, 2);
//                Console.WriteLine("Wybierz wrogiego bohatera!");
//                enemyHero = Console.ReadKey().KeyChar;

//                if ((enemyHero - '0') < player.Heroes.Count - 1 || (enemyHero - '0') > player.Heroes.Count)
//                {
//                    Console.Clear();
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine("Nie ma bohatera o takim id!");
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.ReadKey();
//                    continue;
//                }

//                Console.WriteLine($"Wybrałeś {enemy.Heroes[(enemyHero - '0') - 1].Name}");
//                Console.WriteLine("Kontynuować?");
//                Console.WriteLine("T(Tak) N(Nie)");
//                approved = Console.ReadKey().KeyChar;

//                if (approved == 'n')
//                {
//                    Console.Clear();
//                    continue;
//                }
//                else if (approved == 't')
//                {
//                    player.SelectHero = (enemyHero - '0') - 1;
//                    break;
//                }
//                else
//                {
//                    Console.Clear();
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine("Podano złą operacje!");
//                    Console.ForegroundColor = ConsoleColor.White;
//                    Console.ReadKey();
//                    Console.Clear();
//                    continue;
//                }
//            }  
            
//            while (true)
//            {
//                Console.WriteLine("Wybierz operacje");
//            }
//        }
//    }
//}
