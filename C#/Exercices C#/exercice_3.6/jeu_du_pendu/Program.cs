using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;

namespace jeu_du_pendu
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            int nbEssais=0;
            bool trouve;
            char lettre;
            string result;
            bool gagne;
            Console.Write("Joueur 1, proposez un mot : ");
            string joueur = Console.ReadLine();
            char[] motTrouve = joueur.ToCharArray();
            char[] motCherche = new char[motTrouve.Length];

            for(int i = 0; i< motTrouve.Length; i++)
            {
                if(i == 0 || i == motTrouve.Length-1)
                {
                    motCherche[i] = motTrouve[i];
                }
                else
                {
                    motCherche[i] = '-';
                }
                
            }
           
            Console.WriteLine("Joueur 2, voici le mot à deviner : ");
            Console.WriteLine(AfficherMot(motTrouve));
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(Chainage(motCherche));
            gagne = false;
            do
            {
                trouve = false;
                Console.WriteLine("Veuillez choisir une lettre :");
                lettre = char.Parse(Console.ReadLine());        
                for(int i = 1; i < motTrouve.Length-1; i++)
                {
                    if (motTrouve[i].Equals(lettre))
                    {
                        motCherche[i] = lettre;
                        trouve = true;
                    }
                }
              
                result = Chainage(motCherche);
                Console.WriteLine(result);
                if(result.Equals(joueur))
                {
                    Console.WriteLine();
                    gagne = true;
                }
                if (!trouve) 
                {
                    nbEssais++;
                }
                Console.WriteLine( $"il vous reste {6-nbEssais}  pour trouver le mot choisi !");
            } while (nbEssais < 7 && gagne == false);
            if (nbEssais > 6)
            {
                Console.WriteLine($"La partie est perdue, vous êtes pendu, le mot était : {joueur}");
            }
            else
            {
                Console.WriteLine($"Bravo, vous avez trouvé le mot {joueur} en {nbEssais} érreurs.");
            }
        }
        public static string AfficherMot(char[] _input)
        {
            string maChaine = "";
            foreach (char item in _input)
            {
                maChaine += item + " ";
            }
            return maChaine;
        }
        public static string Chainage(char[] _input)
        {
            string machaine = "";
            foreach (char item in _input)
            {
                machaine += item;
            }
            return machaine;
        }
    }    
}