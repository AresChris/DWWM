namespace garageDeVoitures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choix;
            List<Voitures> voitures = new List<Voitures>();
            bool quitter = false;
            while (!quitter)
            {
                Console.WriteLine("1. Ajouter une voiture");
                Console.WriteLine("2. Afficher toutes les voitures");
                Console.WriteLine("3. Rechercher une voiture par marque");
                Console.WriteLine("4. Supprimer une voiture par code");
                Console.WriteLine("5. Quitter");

                Console.WriteLine("Choix : ");
                choix = Console.ReadLine();

                bool ajouterVoiture = true;

                switch (choix)
                {
                    case "1":
                        bool ajouterEncore = true;
                        while (ajouterEncore)
                        {
                            Console.WriteLine("Ajoutez une nouvelle voiture : \n--------------------");
                            Console.Write("Entrez le code du véhicule : ");
                            string code = Console.ReadLine();

                            if (voitures.Exists(v => v.code == code))
                            {
                                Console.WriteLine("⚠️ Ce code existe déjà !");
                                continue;
                            }
                            Console.Write("Entrez la marque du véhicule : ");
                            string marque = Console.ReadLine();
                            Console.Write("Entrez le modèle du véhicule : ");
                            string modele = Console.ReadLine();
                            Console.Write("Entrez l'année du véhicule : ");
                            int annee = int.Parse(Console.ReadLine());
                            Console.Write("Entrez le kilométrage du véhicule : ");
                            int kilometrages = int.Parse(Console.ReadLine());

                            voitures.Add(new Voitures(code, marque, modele, annee, kilometrages));

                            Console.Write("Ajouter une autre voiture ? (oui/non) : ");
                            string reponse = Console.ReadLine().ToLower();
                            ajouterEncore = (reponse == "oui");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n--- Liste des voitures ---");
                        if (voitures.Count == 0)
                        {
                            Console.WriteLine("Aucune voiture enregistrée.");
                        }
                        else
                        {
                            foreach (Voitures v in voitures)
                            {
                                Console.WriteLine("----------------");
                                v.Afficher();
                            }
                        }
                        break;
                    case "3":
                        Console.Write("Entrez le code du véhicule à rechercher : ");
                        string codeRecherche = Console.ReadLine();
                        Voitures trouvee = voitures.Find(v => v.code == codeRecherche);

                        if (trouvee != null)
                        {
                            Console.WriteLine("\n--- Véhicule trouvé ---");
                            trouvee.Afficher();
                        }
                        else
                        {
                            Console.WriteLine("❌ Aucune voiture trouvée avec ce code.");
                        }
                        break;
                    case "4":
                        Console.Write("Entrez le code du véhicule à supprimer : ");
                        string codeSupp = Console.ReadLine();
                        Voitures aSupprimer = voitures.Find(v => v.code == codeSupp);

                        if (aSupprimer != null)
                        {
                            voitures.Remove(aSupprimer);
                            Console.WriteLine("✅ Véhicule supprimé.");
                        }
                        else
                        {
                            Console.WriteLine("❌ Code introuvable.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("👋 Au revoir !");
                        quitter = true;
                        break;

                    default:
                        Console.WriteLine("Choix invalide, veuillez réessayer.");
                        break;
                }
            }
        }
    }
    public class Voitures
    {
        public string code { get; set; }
        public string marque { get; set; }
        public string modele { get; set; }
        public int annee { get; set; }
        public int kilometrages { get; set; }
        public Voitures(string code, string marque, string modele, int annee, int kilometrages)
        {
            this.marque = marque;
            this.modele = modele;
            this.code = code;
            this.annee = annee;
            this.kilometrages = kilometrages;
        }
        public void Afficher()
        {
            Console.WriteLine("Code : " + code);
            Console.WriteLine("Marque: " + marque);
            Console.WriteLine("Modele: " + modele);
            Console.WriteLine("Annee : " + annee);
            Console.WriteLine("Kilometrage : " + kilometrages);
        }
        public void AfficherInfos()
        {
            Console.WriteLine($"{code}, {marque}, {modele}, {annee}, {kilometrages}");
        }
    }
}

