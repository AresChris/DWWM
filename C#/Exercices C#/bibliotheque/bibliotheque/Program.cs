using System;
using System.Collections.Generic;
using System.Linq;

namespace Bibliotheque
{
    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int AnneePublication { get; set; }
        public string ISBN { get; set; }

        public Livre(string titre, string auteur, int anneePublication, string isbn)
        {
            Titre = titre;
            Auteur = auteur;
            AnneePublication = anneePublication;
            ISBN = isbn;
        }
    }

    internal class Program
    {
        static List<Livre> livres = new List<Livre>();

        static void Main(string[] args)
        {
            bool continuer = true;

            while (continuer)
            {
                AfficherMenu();
                Console.Write("\nChoix : ");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        AjouterLivre();
                        break;
                    case "2":
                        AfficherLivres();
                        break;
                    case "3":
                        RechercherLivre();
                        break;
                    case "4":
                        continuer = false;
                        Console.WriteLine("Au revoir !");
                        break;
                    default:
                        Console.WriteLine("Choix invalide.");
                        break;
                }
            }
        }

        public static void AfficherMenu()
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Ajouter un livre");
            Console.WriteLine("2. Afficher tous les livres");
            Console.WriteLine("3. Rechercher un livre par mot-clé");
            Console.WriteLine("4. Quitter");
        }

        public static void AjouterLivre()
        {
            Console.WriteLine("Ajouter un livre :");
            Console.Write("Titre : ");
            string titre = Console.ReadLine();
            Console.Write("Auteur : ");
            string auteur = Console.ReadLine();
            Console.Write("Année de publication : ");
            int annee = int.Parse(Console.ReadLine());
            Console.Write("ISBN : ");
            string isbn = Console.ReadLine();

            livres.Add(new Livre(titre, auteur, annee, isbn));
            Console.WriteLine("✅ Livre ajouté !");
        }

        public static void AfficherLivres()
        {
            if (livres.Count == 0)
            {
                Console.WriteLine("📭 Aucun livre à afficher.");
                return;
            }

            Console.WriteLine("\n📚 Liste des livres :");
            foreach (var livre in livres)
            {
                Console.WriteLine($"- {livre.Titre} de {livre.Auteur} ({livre.AnneePublication}) | ISBN: {livre.ISBN}");
            }
        }

        public static void RechercherLivre()
        {
            Console.Write("Mot-clé (titre ou auteur) : ");
            string motCle = Console.ReadLine().ToLower();

            var resultats = livres.Where(l =>
                l.Titre.ToLower().Contains(motCle) ||
                l.Auteur.ToLower().Contains(motCle)).ToList();

            if (resultats.Count == 0)
            {
                Console.WriteLine("Aucun livre trouvé.");
            }
            else
            {
                Console.WriteLine("\n📘 Résultats :");
                foreach (var livre in resultats)
                {
                    Console.WriteLine($"- {livre.Titre} de {livre.Auteur} ({livre.AnneePublication}) | ISBN: {livre.ISBN}");
                }
            }
        }
    }
}
