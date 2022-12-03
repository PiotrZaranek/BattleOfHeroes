using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHeroes.App.Helpers
{
    internal static class ServicesHelper
    {      
        public static void SecondHero()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nie można wybrać dwóch tych samych bohaterów!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        public static void BadChoose()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podana wartość jest nie prawidłowa!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        public static void TooShortName()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Zbyt krótka nazwa!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        public static void WriteQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wybierz operację:");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PlayerName(int id)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Podaj nazwę {id}. gracza:");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
