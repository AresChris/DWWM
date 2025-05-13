using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace la_bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;
            Bouteille evian = new Bouteille("Evian", 100, 100);
            Bouteille volvic = new Bouteille("Volvic", 150, 150);
            Bouteille cristalline = new Bouteille("Cristalline", 150, 100);
            List<Bouteille> bouteilles = new List<Bouteille> { evian, volvic, cristalline };


            for (int i = 0; i < bouteilles.Count; i++)
            {
                bouteilles[i].afficherEtat(i + 1);
            }
            int choixBouteille;
            while (!int.TryParse(Console.ReadLine(), out choixBouteille) || choixBouteille < 1 || choixBouteille > bouteilles.Count)
            {
                Console.WriteLine("Veuillez entrer un numéro valide.");
            }
            while (continuer)
            {
                Bouteille bouteilleChoisie = bouteilles[choixBouteille - 1];
                Console.WriteLine("\nActions disponibles :");
                Console.WriteLine("1. Ouvrir\n2. Fermer\n3. Remplir\n4. Vider\n5. Menu\n6. Ajouter une bouteille\n7. Supprimer une bouteille\n8. Quitter");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        bouteilleChoisie.ouvrir();
                        bouteilleChoisie.afficherEtat(choixBouteille);
                        break;
                    case "2":
                        bouteilleChoisie.fermer();
                        bouteilleChoisie.afficherEtat(choixBouteille);
                        break;
                    case "3":
                        bouteilleChoisie.remplir();
                        bouteilleChoisie.afficherEtat(choixBouteille);
                        break;
                    case "4":
                        bouteilleChoisie.vider();
                        bouteilleChoisie.afficherEtat(choixBouteille);
                        break;
                    case "5":
                        Console.WriteLine("\nChoisissez une bouteille :");
                        for (int i = 0; i < bouteilles.Count; i++)
                        {
                            bouteilles[i].afficherEtat(i + 1);
                        }
                        while (!int.TryParse(Console.ReadLine(), out choixBouteille) || choixBouteille < 1 || choixBouteille > bouteilles.Count)
                        {
                            Console.WriteLine("Veuillez entrer un numéro valide.");
                        }
                        break;
                    case "6":
                        ajouterBouteille(bouteilles);
                        break;
                    case "7":
                        supprimerBouteille(bouteilles, bouteilleChoisie.nom);
                        break;
                    case "8":
                        Console.WriteLine("Au revoir !");
                        continuer = false;
                        break;
                    default:
                        Console.WriteLine("Choix invalide.");
                        break;
                }
                static void ajouterBouteille(List<Bouteille> bouteilles)
                {
                    Console.WriteLine("Quel est le nom de la bouteille que vous voulez ajouter ?");
                    string nom = Console.ReadLine();
                    Console.WriteLine("Quelle est la contenance de la bouteille ?");
                    int contenance;
                    while (!int.TryParse(Console.ReadLine(), out contenance) || contenance <= 0)
                    {
                        Console.WriteLine("Veuillez entrer une contenance valide.");
                    }
                    Console.WriteLine("Quelle est la quantité de liquide dans la bouteille ?");
                    int contenu;
                    while (!int.TryParse(Console.ReadLine(), out contenu) || contenu < 0 || contenu > contenance)
                    {
                        Console.WriteLine("Veuillez entrer une quantité valide.");
                    }
                    Bouteille nouvelleBouteille = new Bouteille(nom, contenance, contenu);
                    bouteilles.Add(nouvelleBouteille);
                }
                static void supprimerBouteille(List<Bouteille> bouteilles, string nom)
                {
                    Console.WriteLine("Voici la liste des bouteilles :");
                    for (int i = 0; i < bouteilles.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {bouteilles[i].nom}");
                    }
                    Console.WriteLine("Quel est le nom de la bouteille que vous voulez supprimer ?");
                    nom = Console.ReadLine();
                    Bouteille bouteilleASupprimer = bouteilles.Find(b => b.nom.Equals(nom, StringComparison.OrdinalIgnoreCase));
                    if (bouteilleASupprimer != null)
                    {
                        bouteilles.Remove(bouteilleASupprimer);
                        Console.WriteLine($"La bouteille {nom} a été supprimée.");
                    }
                    else
                    {
                        Console.WriteLine($"Aucune bouteille nommée {nom} n'a été trouvée.");
                    }
                }
            }
        }
    }
    class Bouteille
    {
        private bool ouverte;
        public string nom { get; set; }
        public int contenance { get; set; }
        public int contenu { get; set; }

        public Bouteille(string nom, int contenance, int contenu)
        {
            this.nom = nom;
            this.contenance = contenance;
            this.contenu = contenu;
            this.ouverte = false;
        }

        public void ouvrir()
        {
            if (ouverte)
            {
                Console.WriteLine("La bouteille est déjà ouverte.");
            }
            else
            {
                ouverte = true;
                Console.WriteLine("La bouteille est maintenant ouverte.");
            }
        }

        public void fermer()
        {
            if (!ouverte)
            {
                Console.WriteLine("La bouteille est déjà fermée.");
            }
            else
            {
                ouverte = false;
                Console.WriteLine("La bouteille est maintenant fermée.");
            }
        }

        public string remplir()
        {
            if (!ouverte)
            {
                Console.WriteLine("La bouteille est fermée. Ouvrez-la d'abord.");
            }
            if (contenu == contenance)
            {
                Console.WriteLine("La bouteille est déjà pleine.");
            }
            else
            {
                Console.WriteLine($"Combien voulez-vous ajouter ? (max: {contenance - contenu})");
                if (int.TryParse(Console.ReadLine(), out int ajout))
                {
                    if (ajout <= 0 || ajout + contenu > contenance)
                    {
                        Console.WriteLine("Quantité invalide.");
                    }
                    else
                    {
                        contenu += ajout;
                        Console.WriteLine($"La bouteille contient maintenant {contenu}.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrée invalide.");
                }
            }
            return "";
        }

        public void vider()
        {
            if (!ouverte)
            {
                Console.WriteLine("La bouteille est fermée. Vous ne pouvez pas la vider.");
                return;
            }

            if (contenu == 0)
            {
                Console.WriteLine("La bouteille est déjà vide.");
            }
            else
            {
                Console.WriteLine($"Combien voulez-vous retirer ? (max: {contenu})");
                if (int.TryParse(Console.ReadLine(), out int retrait))
                {
                    if (retrait <= 0 || retrait > contenu)
                    {
                        Console.WriteLine("Quantité invalide.");
                    }
                    else
                    {
                        contenu -= retrait;
                        Console.WriteLine($"La bouteille contient maintenant {contenu}.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrée invalide.");
                }
            }
        }
        public void menu()
        {
            Bouteille evian = new Bouteille("Evian", 100, 100);
            Bouteille volvic = new Bouteille("Volvic", 150, 150);
            Bouteille cristalline = new Bouteille("Cristalline", 150, 100);
            List<Bouteille> bouteilles = new List<Bouteille> { evian, volvic, cristalline };

            Console.WriteLine("\nChoisissez une bouteille :");
            for (int i = 0; i < bouteilles.Count; i++)
            {
                bouteilles[i].afficherEtat(i + 1);
            }
            int choixBouteille;
            while (!int.TryParse(Console.ReadLine(), out choixBouteille) || choixBouteille < 1 || choixBouteille > bouteilles.Count)
            {
                Console.WriteLine("Veuillez entrer un numéro valide.");
            }
        }
            public void afficherEtat(int numero)
            {
            string etat = ouverte ? "ouverte" : "fermée";
            Console.WriteLine($"{numero}. {nom} - {contenu}/{contenance} mL ({etat})");
            }
    }
}
