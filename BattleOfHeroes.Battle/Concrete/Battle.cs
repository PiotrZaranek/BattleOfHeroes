using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleOfHeroes.Domain.Abstract;
using BattleOfHeroes.Domain.Common;
using BattleOfHeroes.BattleApp.Helper;
using BattleOfHeroes.BattleApp.Concrete;

namespace BattleOfHeroes.Domain.Concrete
{
    public class Battle : IBattle
    {
        public List<Player> Players { get; }
        public int Turn { get; set; }
        public BattleList BattleList { get; set; }

        // Done!
        public Battle(List<Player> players)
        {
            Players = new List<Player>();
            BattleList = new BattleList();
            Players = players;
            Turn = 1;
        }

        public void Main()
        {
            bool quit;
            while (true)
            {
                if (quit = ListHerosAndTurn())
                {
                    break;
                }
                PlayerMove(Players[0], Players[1]);
                if((Players[0].Heroes.Count <= 0) || (Players[1].Heroes.Count <= 0))
                {
                    break;
                }    

                if (quit = ListHerosAndTurn())
                {
                    break;
                }
                PlayerMove(Players[1], Players[0]);
                if ((Players[0].Heroes.Count <= 0) || (Players[1].Heroes.Count <= 0))
                {
                    break;
                }

                Turn++;
            }

            if(!quit)
            {
                Finish();   
            }            
        }

        private void PlayerMove(Player player, Player enemy)
        {
            SelectHero(player, enemy);
            ExecuteEffect(player);
            ExecuteAuraAndManaRegeneration(player, enemy);
            CheckIsHeroDead(player, enemy);
        }
        // Done!
        private bool ListHerosAndTurn()
        {
            Console.Clear();
            Console.WriteLine($"\t\t\tTura: {Turn}");
            Console.WriteLine("------------------------------------------------------------");
            foreach (var player in Players)
            {
                Console.WriteLine(player.PlayerName);
                Console.WriteLine("------------------------------------------------------------");
                foreach (var hero in player.Heroes)
                {
                    hero.ShowStatistic();
                }
                Console.WriteLine("------------------------------------------------------------");
            }
            BattleHelper.EndBattle();
            char exit = Console.ReadKey().KeyChar;

            if(exit == 'q')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Done!
        private void ListHeros(Player player)
        {            
            Console.WriteLine("------------------------------------------------------------");
            foreach (var hero in player.Heroes)
            {
                hero.ShowStatistic();
                Console.WriteLine("------------------------------------------------------------");
            }
        }
        // Done!
        private Hero GetHero(Player player)
        {
            int choose;
            Hero find = null;

            while (true)
            {
                ListHeros(player);
                BattleHelper.NowTurn(player.PlayerName);
                BattleHelper.SelectHero();
                try
                {
                    choose = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    BattleHelper.GiveIdHero();
                    continue;
                }

                foreach (var hero in player.Heroes)
                {
                    if (choose == hero.Id)
                    {
                        find = hero;
                    }
                }

                if (find == null)
                {
                    BattleHelper.GiveIdHero();
                    continue;
                }
                else
                {
                    break;
                }
            }

            return find;
        }
        // Done!
        private void SelectHero(Player player, Player enemy)
        {
            int choose;
            bool skip = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Kontynuuj");
                Console.WriteLine("2. Pomiń turę");
                BattleHelper.NowTurn(player.PlayerName);
                BattleHelper.SelectOperations();

                try
                {
                    choose = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    BattleHelper.GiveAction();
                    continue;
                }

                if (choose == 1)
                {
                    skip = true;
                    CheckIsHeroDead(player, enemy);
                    break;
                }
                else if(choose == 2)
                {                    
                    break;
                }
                else
                {
                    BattleHelper.GiveAction();
                    continue;
                }
            } 
            
            if(skip)
            {
                Console.Clear();
                player.Move.Hero = GetHero(player);
                SelectTarget(player, enemy);
            }
            else
            {
                BattleHelper.SkipTurn();
                BattleList.AddMove(Turn, player, "Tura pominięta");
            }
            
        }
        // Done!
        private void SelectTarget(Player player, Player enemy)
        {
            int choose;
            bool find = false;
            bool back = false;

            while (true)
            {
                Console.Clear();
                BattleHelper.Attack(player.Move.Hero.Name, player.PlayerName);
                Console.WriteLine(player.PlayerName);
                ListHeros(player);
                Console.WriteLine(enemy.PlayerName);
                ListHeros(enemy);
                Console.WriteLine("0. Wróć");
                BattleHelper.NowTurn(player.PlayerName);
                BattleHelper.SelectTarget();

                try
                {
                    choose = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    BattleHelper.GiveIdHero();
                    continue;
                }

                if (choose == 0)
                {
                    back = true;
                    break;
                }

                foreach (var hero in enemy.Heroes)
                {
                    if (choose == hero.Id)
                    {
                        player.Move.Target = hero;
                        find = true;
                    }
                }

                foreach (var hero in player.Heroes)
                {
                    if (choose == hero.Id)
                    {
                        player.Move.Target = hero;
                        find = true;
                    }
                }

                if (find)
                {
                    break;
                }
                else
                {
                    BattleHelper.GiveIdHero();
                    continue;
                }

            }

            if (back)
            {
                SelectHero(player, enemy);
            }
            else
            {
                SelectOperations(player, enemy);
            }
            
        }
        // Done!
        private void SelectOperations(Player player, Player enemy)
        {
            if (player.Move.Target.Owner == player)
            {
                ListOperations(player.Move, 'P', enemy);
            }
            else
            {
                ListOperations(player.Move, 'A', enemy);
            }
        }
        // Done!
        private void ListOperations(Move move, char type, Player enemy)
        {
            int choose;
            bool find = false;
            bool back = false;

            while (true)
            {
                Console.Clear();
                BattleHelper.Attack(move.Hero.Name, move.Hero.Owner.PlayerName);
                BattleHelper.Target(move.Target.Name, move.Target.Owner.PlayerName);
                Console.Write("\n");

                Console.WriteLine("0. Wróć");
                foreach (var operaion in move.Hero.Operations)
                {
                    if (operaion.Type == type && operaion.IsActive)
                    {
                        Console.WriteLine($"{operaion.Id}. {operaion.Name}");
                    }
                }

                foreach (var skill in move.Hero.Skills)
                {
                    if ((skill.Type == type) && !skill.IsAura &&(move.Hero.Mana > skill.NeedMana))
                    {
                        Console.WriteLine($"{skill.Id}. {skill.Name}");
                    }
                }
                Console.Write("\n");

                BattleHelper.NowTurn(move.Hero.Owner.PlayerName);
                BattleHelper.SelectOperations();

                try
                {
                    choose = Int32.Parse(Console.ReadLine()); 
                }
                catch
                {
                    BattleHelper.GiveIdOperation();
                    continue;
                }

                if(choose == 0)
                {
                    back = true;
                    break;                    
                }

                foreach (var operation in move.Hero.Operations)
                {
                    if(operation.Type == type && operation.IsActive)
                    {
                        if (choose == operation.Id)
                        {
                            ExecuteOperation(move.Target, operation, move.Hero);
                            find = true;
                        }
                    }                    
                }

                foreach (var skill in move.Hero.Skills)
                {
                    if (skill.Type == type && !skill.IsAura)
                    {
                        if (choose == skill.Id)
                        {
                            ExecuteOperation(move.Target, skill, move.Hero);
                            find = true;
                        }
                    }
                }

                if(find)
                {
                    break;
                }
                else
                {
                    BattleHelper.GiveIdOperation();
                    continue;
                }
            }

            if(back)
            {
                SelectTarget(move.Hero.Owner, enemy);
            }            
        }
        // Done!
        private void ExecuteOperation(Hero target, Operation operation, Hero hero)
        {
            operation.Action(target, hero.Damage);
            BattleList.AddMove(Turn, hero.Owner, operation);
        }
        // Done!
        private void ExecuteOperation(Hero target, Skill skill, Hero hero)
        {
            skill.Action(hero, target);
            BattleList.AddMove(Turn, hero.Owner, skill);
        }
        // Done!
        private void ExecuteEffect(Player player)
        {
            foreach (var hero in player.Heroes)
            {
                foreach (var effect in hero.Effects)
                {
                    effect.Execute(hero);
                }

                hero.DeleteEffect();
            }
        }
        // Done!
        private void ExecuteAuraAndManaRegeneration(Player player, Player enemy)
        {
            foreach (var hero in player.Heroes)
            {
                foreach (var skill in hero.Skills)
                {
                    if(skill.IsAura)
                    {
                        if(skill.Type == 'A')
                        {
                            foreach (var enemyHero in enemy.Heroes)
                            {
                                skill.Action(hero, enemyHero);
                            }
                        }
                        else
                        {
                            foreach (var playerHero in player.Heroes)
                            {
                                skill.Action(hero, playerHero);
                            }
                        }
                    }
                }

                hero.Regeneration();
            }
        }
        // Done!
        private void CheckIsHeroDead(Player player, Player enemy)
        {
            List<Hero> dead = new List<Hero>();

            foreach (var hero in player.Heroes)
            {
                if(hero.IsDead())
                {
                    dead.Add(hero);
                    BattleList.AddMove(Turn, player, hero);
                }
            }

            foreach (var hero in dead)
            {
                player.Heroes.Remove(hero);
            }

            dead.Clear();

            foreach (var hero in enemy.Heroes)
            {
                if (hero.IsDead())
                {
                    dead.Add(hero);
                    BattleList.AddMove(Turn, enemy, hero);
                }
            }

            foreach (var hero in dead)
            {
                enemy.Heroes.Remove(hero);
            }
        }
        private void Finish()
        {
            char choose;
            if (Players[0].Heroes.Count == 0)
            {
                BattleHelper.Winner(Players[1].PlayerName);                                
            }
            else
            {
                BattleHelper.Winner(Players[0].PlayerName);
            }

            Console.WriteLine("1. Pokaż historię walki.");
            Console.WriteLine("Kliknij dowolny przycisk aby wrócić do głownego menu...");
            BattleHelper.SelectOperations();
            choose = Console.ReadKey().KeyChar;

            if(choose == '1')
            {                
                BattleList.ListMoves();
            }
        }  
        
        private void Test()
        {
            Console.Clear();
            BattleList.ListMoves();
            Console.ReadKey();
        }
    }
}
