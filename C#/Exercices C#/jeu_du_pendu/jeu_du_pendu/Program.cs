using System.Collections.Generic;

namespace jeu_du_pendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            string[] tableau;
            int compteur = 0;

            Console.Write("Proposez un mot : ");
            String input = Console.ReadLine();

            tableau = input.Split(' ');
            //list.Add(input);
            for(int i = 0; i < tableau.Length; i++) 
            {
                tableau[i] = new string('_', tableau[i].Length); // Remplacer chaque mot par des underscores
                Console.WriteLine(tableau[i]);
                Console.Write("Proposez une lettre : ");
                string proposition = Console.ReadLine();
                if (proposition.Contains(tableau[i]))
                {
                    tableau[i] = new string(, tableau[i].Length);
                }
            }
            do
            {
                //Console.Write("Proposez une lettre : ");
                //string proposition = Console.ReadLine();
                //if (proposition.Contains(tableau[i]))
                //{

                //}
                //compteur++;
            } while (compteur < 10);
            Console.WriteLine(input);
        }
    }    
}

/*
 * static void Main(string[] args)
{
    string[] tableau;
    int compteur = 0;
    string input;

    Console.Write("Proposez un mot : ");
    input = Console.ReadLine();

    tableau = input.Split(' '); // Divise le mot en mots s'il y en a plusieurs

    // Initialiser le tableau avec des underscores
    string[] motsCachés = tableau.Select(mot => new string('_', mot.Length)).ToArray();

    // Affichage de l'état initial
    AfficherEtatJeu(motsCachés);

    // Début du jeu
    while (compteur < 10 && motsCachés.Any(mot => mot.Contains('_'))) // Tant qu'il reste des underscores
    {
        Console.Write("Proposez une lettre : ");
        string proposition = Console.ReadLine();

        if (proposition.Length == 1) // Vérifie que l'utilisateur propose une seule lettre
        {
            bool lettreTrouvee = false;

            // Parcours chaque mot dans le tableau
            for (int i = 0; i < tableau.Length; i++)
            {
                // Vérifier si la lettre est présente dans ce mot
                for (int j = 0; j < tableau[i].Length; j++)
                {
                    if (tableau[i][j].ToString() == proposition) // Si la lettre correspond
                    {
                        // Remplacer l'underscore par la lettre dans le mot caché
                        motsCachés[i] = motsCachés[i].Remove(j, 1).Insert(j, proposition);
                        lettreTrouvee = true;
                    }
                }
            }

            // Afficher si la lettre a été trouvée ou non
            if (lettreTrouvee)
            {
                Console.WriteLine("Lettre trouvée !");
            }
            else
            {
                Console.WriteLine("Lettre non trouvée !");
            }

            // Affichage de l'état actuel du jeu
            AfficherEtatJeu(motsCachés);

            // Incrémenter le compteur (tu peux ajouter des conditions pour limiter le nombre d'échecs)
            if (!lettreTrouvee)
            {
                compteur++;
            }
        }
        else
        {
            Console.WriteLine("Veuillez entrer une seule lettre.");
        }
    }

    // Si le joueur a gagné
    if (!motsCachés.Any(mot => mot.Contains('_')))
    {
        Console.WriteLine("Félicitations, vous avez trouvé tous les mots !");
    }
    else
    {
        Console.WriteLine($"Dommage, vous avez perdu ! Le mot était : {input}");
    }
}

static void AfficherEtatJeu(string[] motsCachés)
{
    Console.WriteLine("État actuel du jeu : ");
    foreach (var mot in motsCachés)
    {
        Console.Write(mot + " ");
    }
    Console.WriteLine();
}

 * 
 * 
*/
