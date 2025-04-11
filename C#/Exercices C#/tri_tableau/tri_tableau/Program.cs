using System.Globalization;

namespace tri_tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> tableau = new List<int>();
            bool continuer = true;
                do
                {
                Console.Write("Combien de nombres voulez-vous ajouter au tableau ? : ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Inscrivez le nombre {i+1} : ");
                        int nombre = int.Parse(Console.ReadLine());
                        tableau.Add(nombre);
                    }
                    Console.WriteLine("Voulez vous le tableau dans l'ordre croissant ou décroissant ?");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "croissant")
                    {
                        tableau.Sort(); // tri le tableau
                    }
                    else if (answer.ToLower() == "décroissant")
                    {
                        tableau.Sort();
                        tableau.Reverse(); // inverse le tableau
                    }
                    else
                    {
                        Console.WriteLine("Réponse invalide. Le tableau sera trié dans l'ordre croissant par défaut.");
                        tableau.Sort(); // tri le tableau
                    }
                    Console.WriteLine("Tableau trié : \n---------");

                    foreach (int nb in tableau)
                    {
                        Console.Write(nb + " | ");
                    }
                    Console.WriteLine();
                    Console.Write("Voulez-vous continuer ? oui ou non : ");
                    string reponse = Console.ReadLine();
                    if(reponse.ToLower().Trim() == "oui")
                    {
                        continuer = true;
                        tableau.Clear(); // vide le tableau
                    }
                    else
                    {
                        continuer = false;
                    }
                } while (continuer);
        }
    }
}

