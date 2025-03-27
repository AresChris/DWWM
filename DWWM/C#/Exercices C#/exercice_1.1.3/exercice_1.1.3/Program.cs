using System.Linq.Expressions;

namespace exercice_1._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> tabNombres = new List<int>(); // Utiliser une liste pour ajouter des nombres
            String saisie;
            int somme = 0, count = 0;

            Console.WriteLine("Saisir des nombres séparés par des éspaces.");
            saisie = Console.ReadLine();

            // Vérifier si l'entrée est vide
            // IsNullOrWhiteSpace 
            if (String.IsNullOrWhiteSpace(saisie))
            {
                Console.WriteLine("Erreur de saisie");
                return;
            }
            String[] valeurs = saisie.Split(' ');

            try
            {
                var nombres = valeurs.Select(v => int.Parse(v)).ToList();

                if(nombres.Count == 0)
                {
                    Console.WriteLine("Aucun nombre valide n'à été saisi.");
                    return;
                }

                somme = nombres.Sum();
                double moyenne = (double)somme / nombres.Count;

                Console.WriteLine($"La moyenne des valeurs saisies est : {moyenne}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Veuillez entrer uniquement des nombres entiers séparés par un éspace");
            }
        }
    }
}



    
