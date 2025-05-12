namespace la_bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ouverte = false;
            bool continuer = true;
            Bouteille evian = new Bouteille("evian", 100, 100);
            Bouteille volvic = new Bouteille("Volvic", 150, 150);
            Bouteille cristalline = new Bouteille("Cristalline", 150, 100);
            List<Bouteille> bouteilles = new List<Bouteille> { evian, volvic, cristalline };

            while (continuer)
            {
                Console.WriteLine("\nChoisissez une bouteille :");
                for (int i = 0; i < bouteilles.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {bouteilles[i].nom} (Contenu: {bouteilles[i].contenu}/{bouteilles[i].contenance})");
                }

                int choixBouteille;
                while (!int.TryParse(Console.ReadLine(), out choixBouteille) || choixBouteille < 1 || choixBouteille > bouteilles.Count)
                {
                    Console.WriteLine("Veuillez entrer un numéro valide.");
                }

                Bouteille bouteilleChoisie = bouteilles[choixBouteille - 1];
                Console.WriteLine("Modélisation d'un objet bouteille, vous pouvez effectuer les opérations suivantes :");
                Console.WriteLine("1.Ouvrir\n2.Fermer\n3.Remplir\n4.Vider\n5.Quitter");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Ouvrir la bouteille");
                        evian.ouvrir();
                        break;
                    case "2":
                        Console.WriteLine("Fermer la bouteille");
                        evian.fermer();
                        break;
                    case "3":
                        Console.WriteLine("Remplir la bouteille");
                        evian.remplir();
                        break;
                    case "4":
                        Console.WriteLine("Vider la bouteille");
                        evian.vider();
                        break;
                    case "5":
                        Console.WriteLine("Au revoir");
                        continuer = false;
                        break;
                    default:
                        break;
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
                Console.WriteLine("La bouteille est ouverte.");
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
                Console.WriteLine("La bouteille est fermée.");
            }
        }
        public void remplir()
        {
            if (ouverte)
            {
                if(contenu == contenance)
                {
                    Console.WriteLine("La bouteille est remplie à 100%.");
                    contenu = contenance;
                }
                else if(contenu < contenance)
                {
                    Console.WriteLine("Quelle quantité voulez-vous ajouter ?");
                    int remplissage = int.Parse(Console.ReadLine());
                    contenu = contenu + remplissage;
                    contenu = contenance;
                    Console.WriteLine($"La bouteille est remplie à {contenance}");
                }
            }
            else
            {
                Console.WriteLine("La bouteille est fermée.");
            }
        }
        public void vider()
        {
            if (ouverte)
            {
                if (contenu == contenance)
                {
                    Console.WriteLine("La bouteille est remplie à 100%.");
                }
                else if (contenu < contenance)
                {
                    Console.WriteLine("Quelle quantité voulez-vous ajouter ?");
                    int vidage = int.Parse(Console.ReadLine());
                    contenu = contenu - vidage;
                    Console.WriteLine($"La bouteille est remplie à {contenu}");
                }
            }
            else
            {
                Console.WriteLine("La bouteille est fermée, vous ne pouvez pas la vider.");
                Console.WriteLine("Ouvrir la bouteille ?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "oui")
                {
                   ouvrir();
                }
                else
                {
                   Console.WriteLine("La bouteille est fermée, vous ne pouvez pas la vider.");
                }
            }
        }
    }
}
