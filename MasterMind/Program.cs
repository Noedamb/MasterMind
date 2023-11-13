
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
            Console.WriteLine("Saisir 5 couleur : ");
            int p = 0;
            char lettre;

            do
            { lettre = Console.ReadKey().KeyChar;

                if (regex.IsMatch(lettre.ToString()))
                {
                    int index = chaine.ToString().IndexOf('-');
                    if (index != -1)
                    {
                        chaine = chaine.Replace('-', lettre, index, 1);
                        p++;
                    }
                }

                Console.Clear(); // clear l'affichage
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
                case 'b': return ConsoleColor.Blue;
                case 'r': return ConsoleColor.Red;
                case 'n': return ConsoleColor.White;
                case 'v': return ConsoleColor.Green;
                case 'j': return ConsoleColor.Yellow;
                case 'o': return ConsoleColor.White;
                case 'g': return ConsoleColor.Gray;
                default: return ConsoleColor.Black;
            }
        }
    }
}
