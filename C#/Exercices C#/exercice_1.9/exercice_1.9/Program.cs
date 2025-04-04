using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace exercice_1._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listDiviseurs = new List<int>();
            int nombre;
            bool test;
            bool continuer = false;
            string reponse;
            do
            {
                do
                {


                    Console.WriteLine("Saisir un nombre à vérifier.");
                    String input = Console.ReadLine();
                    if (int.TryParse(input, out nombre))
                    {
                        test = recherchePremier(nombre);
                        if (test)

                        {
                            Console.WriteLine($"Le nombre {nombre} est premier.");
                        }
                        else
                        {
                            Console.WriteLine($"Le nombre {nombre} n'est pas premier.");
                            listDiviseurs = rechercherDiviseurs(nombre);
                            AfficherDiviseurs(listDiviseurs);

                            Console.WriteLine($"Somme des diviseurs : {SommeDesDiviseurs(listDiviseurs)}");
                        }

                        continuer = false; }
                    else
                    {
                        Console.WriteLine("Erreur de saisie, veuillez recommencer");
                        continuer = true;
                    }
                } while (continuer);
                Console.WriteLine("Voulez recommencer et saisir un autre nombre: o/n ");

                reponse = Console.ReadLine().ToLower();


            }
            while (reponse.Equals("o") == true);
            Console.WriteLine("programme terminé");
            Console.ReadKey();
        }
        public static bool recherchePremier(int _nombre)
        {
            bool premier = true;
            double limit = Math.Round(Math.Sqrt(_nombre), 0);
            for (int i = 2; i < limit; i++)
            {
                if (_nombre % i == 0)
                {
                    premier = false;
                    break;
                }

            }

            return premier;

        }
        public static List<int> rechercherDiviseurs (int _nombre)
            {
                List<int> diviseurs = new List<int>();
            for (int i = 2; i < _nombre; i++)
            {
                if (_nombre % i == 0)
                {
                    diviseurs.Add(i);
                    
                }
            }
            return diviseurs;
            }
        public static void AfficherDiviseurs(List<int> _diviseurs)
        {
            Console.Write("\n[ ");
            foreach(int i in _diviseurs)
            {
                Console.Write(i + " ");
            }
            Console.Write("]\n");
        }
        public static int SommeDesDiviseurs(List<int> _diviseurs)
        {
            int somme = 1;
            foreach (int i in _diviseurs)
            {
                somme += i;
            }
            return somme;
        }
    }
}
