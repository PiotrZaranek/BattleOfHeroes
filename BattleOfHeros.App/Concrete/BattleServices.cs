using BattleOfHeroes.App.Menager;
using BattleOfHeroes.Domain.Concrete;
using BattleOfHeroes.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BattleOfHeroes.BattleApp.Concrete;
using BattleOfHeroes.App.Helpers;

namespace BattleOfHeroes.App.Concrete
{
    public class BattleServices
    {
        public int GameMode { get; set; }
        public List<BattleStory> BattleStories { get; set; }

        private string path = @"C:\temp\Battle.json";

        public BattleServices()
        {
            BattleStories = new List<BattleStory>();
            ReadBattleFromFile();
        }

        public void ChooseHeroPlayer(List<Hero> heroes, int id, PlayerServices playerServices)
        {
            playerServices.Elements[id].Heroes = heroes;
            foreach (var hero in playerServices.Elements[id].Heroes)
            {
                hero.Owner = playerServices.Elements[id];
            }
        }

        public Battle CreateBattle(PlayerServices playerServices)
        {
            return new Battle(playerServices.Elements);
        }

        public void StartBattle(Battle battle, MenagerBattleServices menagerBattleServices)
        {
            battle.Main();
            BattleStories.Add(new BattleStory(BattleStories.Count + 1, battle.Players[0].PlayerName, battle.Players[1].PlayerName, battle.BattleList));                        
        }

        public void ListMoves(BattleList bl) 
        {
            Console.Clear();
            bl.ListMoves();
        }
        
        private void ReadBattleFromFile()
        {
            using StreamReader sr = new StreamReader(path);
            string input = sr.ReadToEnd();

            if(input.Length != 0)
            {
                BattleStories = JsonConvert.DeserializeObject<List<BattleStory>>(input);
            }            
        }

        public void SaveBattleStoryToFile()
        {            
            using StreamWriter sw = new StreamWriter(path);
            using JsonWriter jw = new JsonTextWriter(sw);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(jw, BattleStories);
        }
    }
}
