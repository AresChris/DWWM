using System.Globalization;
namespace kiloutou_switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voitures v1 = new Voitures("2098", "Peugeot", "307", new DateTime(2005, 12, 21));
            Voitures v2 = new Voitures("1897", "Renault", "Espace", new DateTime(2002, 3, 10));
            Voitures v3 = new Voitures("1203", "Lancia", "Dedra", new DateTime(2004, 7, 12));
            Voitures v4 = new Voitures("3049", "Bmw", "324d", new DateTime(2004, 05, 12));
            Voitures v5 = new Voitures("1500", "Peugeot", "406", new DateTime(2001, 7, 30));
            Voitures v6 = new Voitures("2500", "Ford", "Mondeo", new DateTime(1995, 3, 12));
            List<Voitures> voitures = new List<Voitures> { v1, v2, v3, v4, v5, v6 };

            bool continuer = true;
            while (continuer)
            {
                continuer = AfficherMenu(voitures);
            }
        }
        static bool AfficherMenu(List<Voitures> voitures)
        {
            Console.WriteLine("\nMenu \n--------\n1. Trier les voitures\n2. Ajouter une voiture\n3. Supprimer une voiture\n4. Afficher toutes les voitures\n5. Rechercher par code\n6. Quitter");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("1. Par code\n2. Par marque\n3. Par modèle");
                    string choixTri = Console.ReadLine();
                    switch (choixTri)
                    {
                        case "1":
                            voitures.Sort(new ComparerParCode());
                            break;
                        case "2":
                            voitures.Sort(new ComparerParMarque());
                            break;
                        case "3":
                            voitures.Sort(new ComparerParModele());
                            break;
                        default:
                            Console.WriteLine("Choix invalide.");
                            return true;
                    }
                    Console.WriteLine("Voitures triées :");
                    foreach (Voitures v in voitures)
                    {
                        Console.WriteLine("----------------");
                        v.AfficherInfos();
                    }
                    break;

                case "2":
                    Console.Write("Code : ");
                    string code = Console.ReadLine();
                    Console.Write("Marque : ");
                    string marque = Console.ReadLine();
                    Console.Write("Modèle : ");
                    string modele = Console.ReadLine();
                    Console.Write("Date de mise en circulation (format jj-MM-aaaa) : ");
                    DateTime dateMiseEnCirculation;
                    while (!DateTime.TryParseExact(Console.ReadLine(), "jj-MM-aaaa",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out dateMiseEnCirculation))
                    {
                        Console.Write("Format invalide. Réessayez (JJ-MM-AAAA) : ");
                    }

                    voitures.Add(new Voitures(code, marque, modele, dateMiseEnCirculation));
                    Console.WriteLine("Voiture ajoutée.");
                    break;

                case "3":
                    Console.Write("Entrez le code de la voiture à supprimer : ");
                    string codeSupp = Console.ReadLine();
                    Voitures vSupp = voitures.FirstOrDefault(v => v.code == codeSupp);
                    if (vSupp != null)
                    {
                        voitures.Remove(vSupp);
                        Console.WriteLine("Voiture supprimée.");
                    }
                    else
                    {
                        Console.WriteLine("Voiture non trouvée.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Liste des voitures :");
                    foreach (Voitures v in voitures)
                    {
                        Console.WriteLine("----------------");
                        v.AfficherInfos();
                    }
                    break;

                case "5":
                    Console.Write("Entrez le code de la voiture à rechercher : ");
                    string codeRecherche = Console.ReadLine();
                    Voitures voitureTrouvee = voitures.FirstOrDefault(v => v.code == codeRecherche);
                    if (voitureTrouvee != null)
                    {
                        Console.WriteLine("Voiture trouvée :");
                        voitureTrouvee.AfficherInfos();
                    }
                    else
                    {
                        Console.WriteLine("Aucune voiture trouvée avec ce code.");
                    }
                    break;

                case "6":
                    Console.WriteLine("Au revoir !");
                    return false;

                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }
            return true;
        }
    }
    public class Voitures
    {
        public string code { get; set; }
        public string marque { get; set; }
        public string modele { get; set; }
        public DateTime dateMiseEnCirculation { get; set; }
        public Voitures(string code, string marque, string modele, DateTime dateMiseEnCirculation)
        {
            this.code = code;
            this.marque = marque;
            this.modele = modele;
            this.dateMiseEnCirculation = dateMiseEnCirculation;
        }
        public void AfficherInfos()
        {
            Console.WriteLine($"{code}, {marque}, {modele}, {dateMiseEnCirculation.ToString("dd-MM-yyyy")}");
        }
        public int CompareTo(Voitures other)
        {
            return string.Compare(this.code, other.code);
        }
    }
    class ComparerParCode : IComparer<Voitures>
    {
        public int Compare(Voitures x, Voitures y)
        {
            return string.Compare(x.code, y.code);
        }
    }
    class ComparerParMarque : IComparer<Voitures>
    {
        public int Compare(Voitures x, Voitures y)
        {
            return string.Compare(x.marque, y.marque);
        }
    }
    class ComparerParModele : IComparer<Voitures>
    {
        public int Compare(Voitures x, Voitures y)
        {
            return string.Compare(x.modele, y.modele);
        }
    }
    class rechercherParCode : IComparer<Voitures>
    {
        public int Compare(Voitures x, Voitures y)
        {
            return string.Compare(x.code, y.code);
        }
    }
}

