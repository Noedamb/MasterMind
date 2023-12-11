using System; 
using System.Text;
using System.Text.RegularExpressions;

namespace MasterMind
{
    class Program
    {
    	public static void Main(string[] args)
    	{ 
    		Console.Write("Veuillir utiliser ces couleurs : ");
			Console.ForegroundColor = ConsoleColor.Blue;Console.Write("Bleu(B) ");Console.ForegroundColor = ConsoleColor.DarkRed;Console.Write("Rouge(R) ");
			Console.ForegroundColor = ConsoleColor.White;Console.Write("Noir(N) ");Console.ForegroundColor = ConsoleColor.Green;Console.Write("Vert(V) ");
			Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("Jaune(J) ");Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("Orange(O) ");
			Console.ForegroundColor = ConsoleColor.DarkGray;Console.WriteLine("Gris(G )");Console.ResetColor();
    		CaraValide(args);}
    	
    	// fonction caravalide
        public static void CaraValide(string[] args)
        {
            StringBuilder chaine = new StringBuilder("[-][-][-][-][-]"); // créé une chaine StringBuilder pour configurer une chaîne de caractères
            Regex regex = new Regex("[brnvjog]"); // Crée un Regex pour vérifier si des lettres correspondent dans "[brnvjog]".
            int p = 0; // creer une variable pour compter le nombre de lettres valides saisies par l'utilisateur.
            char lettre; // Déclare une variable pour stocker la lettre saisie par l'utilisateur.
            do
            {   lettre = Console.ReadKey().KeyChar; // saisir par l'utilisateur
                if (regex.IsMatch(lettre.ToString())) // Vérifie si la lettre saisie correspond à l'une des lettres dans "[brnvjog].
                {
                    int index = chaine.ToString().IndexOf('-'); // l'index recupere les '-' dans la chaine
                    if (index != -1)
                    {
                        chaine = chaine.Replace('-', lettre, index, 1); // Remplace le premier '-' 
                        p++;
                    }
                }
                Console.Clear(); 
                foreach (char c in chaine.ToString()) // Parcourt chaque caractère de la chaîne.
                {
                    if (regex.IsMatch(c.ToString())) // Vérifie si le caractère correspond à l'une des lettres dans "[brnvjog]".
                    {
                        Console.ForegroundColor = GetConsoleColor(c); // Change la couleur de premier plan de la console.
                        Console.Write(c);
                        Console.ResetColor(); // restort de la couleur
                    }
                    else
                    {
                        Console.Write(c);
                    }
                }
                Console.WriteLine();
            } while (p < 5);{
            	Console.Clear(); 
            	Joueur2(args, chaine.ToString().ToCharArray());
            }
        }
     public static void Joueur2(string[] args, char[] combinaison)
        {
     		Console.Write("Veuillir utiliser ces couleurs : ");
			Console.ForegroundColor = ConsoleColor.Blue;Console.Write("Bleu(B) ");Console.ForegroundColor = ConsoleColor.DarkRed;Console.Write("Rouge(R) ");Console.ForegroundColor = ConsoleColor.White;Console.Write("Noir(N) ");Console.ForegroundColor = ConsoleColor.Green;Console.Write("Vert(V) ");
			Console.ForegroundColor = ConsoleColor.Yellow;Console.Write("Jaune(J) ");Console.ForegroundColor = ConsoleColor.DarkYellow;Console.Write("Orange(O) ");Console.ForegroundColor = ConsoleColor.DarkGray;Console.WriteLine("Gris(G )");Console.ResetColor();
			
            StringBuilder chaine = new StringBuilder("essaie : [-][-][-][-][-]        Bien placé{X}                         Mal placé{X}");
            Regex regex = new Regex("[brnvjog]");
            int p = 0;
            char lettre;
            char[] combinaisonEssaie = new char[5];
            do
            { lettre = Console.ReadKey().KeyChar;
                if (regex.IsMatch(lettre.ToString()))
                {
                    int index = chaine.ToString().IndexOf('-');
                    if (index != -1)
                    {
                        chaine = chaine.Replace('-', lettre, index, 1);
                        combinaisonEssaie[p] = lettre;
                        p++;
                    }
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
                    { Console.Write(c); }
                }
                Console.WriteLine();
            } while (p < 5);
            Console.Clear();
            CalculBpMp(combinaison, combinaisonEssaie);
        }
        private static ConsoleColor GetConsoleColor(char lettre)
        {
            switch (lettre)
            {
                case 'b': return ConsoleColor.Blue;
                case 'r': return ConsoleColor.DarkRed;
                case 'n': return ConsoleColor.White;
                case 'v': return ConsoleColor.Green;
                case 'j': return ConsoleColor.Yellow;
                case 'o': return ConsoleColor.DarkYellow;
                case 'g': return ConsoleColor.DarkGray;
                default: return ConsoleColor.Black;
            }
        }
    }
}