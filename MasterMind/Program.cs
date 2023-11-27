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
        public static void CaraValide(string[] args)
        {
            StringBuilder chaine = new StringBuilder("[-][-][-][-][-]"); // créé une chaine StringBuilder pour configurer une chaîne de caractères
            Regex regex = new Regex("[brnvjog]"); // Crée un Regex pour vérifier si des lettres correspondent dans "[brnvjog]".
            Console.WriteLine("Saisir 5 couleur : "); // Affiche un message à l'utilisateur.
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
                Console.WriteLine(); // Passe à la ligne suivante.
            } while (p < 5);{
            	Console.Clear(); 
            	test(args);
            }
        }
        private static ConsoleColor GetConsoleColor(char lettre) 
        {
            switch (lettre) // Utilise une instruction switch pour déterminer la couleur en fonction de la lettre.
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
        public static void test(string[] args)
        {
            Console.WriteLine("2ème joueur :                Bien placé                     Mal placé");
            Console.WriteLine("essaie : [-][-][-][-][-]        {X}                            {X}");
            Console.ReadLine();    

        }
			public static void CalculBpMp(ref int bp, int mp, char[] combinaison, char essaie, char[] combinaisonEssaie)
			{
			
			}
			public static void Joueur2(ref int nbE, char[] combinaison, char[] essaie)
			{
			
			}
    }
    
}

