using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace exercice_1._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String saisie;
            int somme = 0, count = 0, element;

            Console.Write("Entrez des nombres séparés par des éspaces : ");
            saisie = Console.ReadLine();

            String[] tableau = saisie.Split(' ');
            
             foreach(String number in tableau) // pour chaque (nombre dans tableau)
             {
                if(int.TryParse(number, out element)) //Si (les nombres du tableau sont des int, stocker dans élement)
                {
                    somme += element;  // somme + valeur de l'élement
                    count++; // compteur +1
                }
                else
                {
                    Console.WriteLine($"{number} n'est pas un nombre valide !");
                }
             }
            if (count > 0)
            {
                int moyenne = somme / count;
                Console.WriteLine($"La moyenne des nombres est {moyenne}");
            }
            else
            {
                Console.WriteLine("Aucun nombre valide n'à été entré");
            }
        }
    }
}



    
