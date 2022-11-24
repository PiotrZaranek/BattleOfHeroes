using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.Helpers
{
    internal static class MainMenuHelper
    {
        public static void WriteTitle()
        {
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("|           Battle Of Heroes             |");
            Console.WriteLine(" ----------------------------------------");
        }

        public static void WrongOperation()
        {
            WriteTitle();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ta operacja nie istnieje!");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void GoodBye()
        {
            WriteTitle();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Do zobaczenia następnym razem!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
