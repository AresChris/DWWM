using System.Reflection;

namespace kiloutou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voitures v1 = new Voitures("2098", "Peugeot", "307");
            Voitures v2 = new Voitures("1897","Renault", "Espace");
            Voitures v3 = new Voitures("1203", "Lancia", "Dedra");
            Voitures v4 = new Voitures("3049", "Bmw", "324d");
            Voitures v5 = new Voitures("1500", "Peugeot", "406");
            Voitures v6 = new Voitures("2500", "Ford", "Mondeo");
            List<Voitures> voitures = new List<Voitures> { v1, v2, v3, v4, v5, v6};

            bool ajouterVoiture = true;
            while (ajouterVoiture)
            {
                Console.WriteLine("Ajoutez une nouvelle voiture : ");
                Console.Write("Entrez le code du véhicule : ");
                string code = Console.ReadLine();
                Console.Write("Entrez la marque du véhicule : ");
                string marque = Console.ReadLine();
                Console.Write("Entrez le modèle du véhicule : ");
                string modele = Console.ReadLine();

                Voitures v = new Voitures(code, marque, modele);
                voitures.Add(v);

                Console.Write("Souhaitez-vous ajouter une autre voiture ? (oui/non) : ");
                string reponse = Console.ReadLine().ToLower();
                if(reponse == "oui")
                {
                    ajouterVoiture = true;
                }
                else
                {
                    ajouterVoiture = false;
                }
            }
            Console.WriteLine("Toutes les voitures :");
            foreach (Voitures v in voitures)
            {
                Console.WriteLine("----------------");
                v.AfficherInfos();
            }
        }
    }
    public class Voitures
    {
        public string code { get; set; }
        public string marque { get; set; }
        public string modele { get; set; }

        public Voitures(string code, string marque, string modele)
        {
            this.code = code;
            this.marque = marque;
            this.modele = modele;
        }
        public void AfficherInfos()
        {
            Console.WriteLine($"{code}, {marque}, {modele}");
        }
    }
}
