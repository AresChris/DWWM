using System.ComponentModel;

namespace exercice_1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> liste = new List<int>();
            bool continuer = true;
            
            do
            {
                int compteur = 0;
                Console.Write("Inscrivez la première valeur : ");
                int a = int.Parse(Console.ReadLine());
                liste.Add(a);
                Console.Write("Inscrivez la deuxième valeur : ");
                int b = int.Parse(Console.ReadLine());
                liste.Add(b);

                Console.Write("Voulez-vous les classer dans l'ordre croissant ou décroissant ? ");
                string reponse = Console.ReadLine();
                if (reponse.ToLower() == "Croissant")
                {
                        liste.Sort();
                }
                else
                {
                        liste.Sort();
                        liste.Reverse();
                }
                compteur = 0;
                foreach (var item in liste)
                {
                    compteur++;
                    Console.WriteLine($"valeur {compteur} : {item}");
                }

                Console.WriteLine("Voulez-vous continuer ? (O/N)");
                reponse = Console.ReadLine();
                if(reponse.ToLower() == "oui")
                {
                    continuer = true;
                    Console.Clear();
                    liste.Clear();
                   
                }
                else
                {
                    continuer = false;
                    break;
                }
            } while (continuer);
        }
    }
}
