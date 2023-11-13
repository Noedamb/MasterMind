using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MasterMind
{
    class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder chaine = new StringBuilder("[-][-][-][-][-]");

            Regex regex = new Regex("[brnvjog]");
            Console.WriteLine("Entrez une lettre : ");
            int p = 0;

            do
            {
                char lettre = Console.ReadKey().KeyChar;
                int index = chaine.ToString().IndexOf('-');
                if (index != -1)
                {
                    chaine[index] = lettre;
                    p++;
                }
                Console.Clear();
                foreach (char c in chaine.ToString())
                {
                    if (regex.IsMatch(c.ToString()))
                    {
                        Console.ForegroundColor = GetConsoleColor(c);
                        Console.Write(c);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(c);
                    }
                }

                Console.WriteLine();
            } while (p < 5);

        }

        private static ConsoleColor GetConsoleColor(char lettre)
        {
            switch (lettre)
            {
                case 'b':return ConsoleColor.Blue;
                case 'r':return ConsoleColor.Red;
                case 'n':return ConsoleColor.White;
                case 'v':return ConsoleColor.Green;
                case 'j':return ConsoleColor.Yellow;
                case 'o':return ConsoleColor.White;
                case 'g':return ConsoleColor.Gray;
                default:return ConsoleColor.White;
            }
        }
    }
}