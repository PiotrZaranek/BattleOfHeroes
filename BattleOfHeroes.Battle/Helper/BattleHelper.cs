using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.BattleApp.Helper
{
    internal static class BattleHelper
    {
        public static void Legend()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|Tura-Nazwa gracza-Nazwa bohatera-Operacja|");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Winner(string name)
        {
            Console.Clear();
            Console.Write($"Wygrywa ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void EndBattle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kliknij Q żeby zakończyć grę!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SkipTurn()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tura pominęta");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        public static void Attack(string heroName, string playerName)
        {
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine($"Wykonuje ruch: {heroName}({playerName})");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Target(string heroName, string playerName)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Cel: {heroName}({playerName})");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void NowTurn(string name)
        {
            Console.WriteLine($"Teraz tura {name}");
        }

        public static void SelectHero()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wybierz bohatera:");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SelectTarget()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wybierz cel:");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SelectOperations()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wybierz operację:");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void GiveAction()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wybierz akcje!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        public static void GiveIdHero()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wybierz bohatera za pomocą jego Id!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        public static void GiveIdSkill()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wybierz id umiejętnoąci!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        public static void GiveSkillNoConstant()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nie Wybieraj umiejętności która jest aurą!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        public static void GiveIdOperation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj Id opercij!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
