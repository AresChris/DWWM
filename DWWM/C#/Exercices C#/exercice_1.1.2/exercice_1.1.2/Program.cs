using System.ComponentModel.Design;

namespace exercice_1._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            double moyenne;
            string choix = "";

            do
            {
                Console.WriteLine("Saisir deux nombres séparés par un éspace vide :");
                string reponse = Console.ReadLine();

                string[] tabNombre = reponse.Split(' '); // Split(' separateur')
                if (tabNombre.Length > 1)
                {
                    if (int.TryParse(tabNombre[0], out a))
                    {
                        Console.WriteLine("a : " + a);

                        if (int.TryParse(tabNombre[1], out b))
                        {
                            Console.WriteLine("b : " + b);
                            moyenne = (double)(a + b) / 2;
                            Console.WriteLine("La moyenne de a et b est de " + moyenne);

                        }
                        else
                        {
                            Console.WriteLine("La saisie est fausse.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("La saisie est fausse.");
                    }

                }
                else
                {
                    Console.WriteLine("La saisie est fausse.Il manque un espace vide");
                }
                Console.WriteLine("Voulez-vous calculer à nouveau ?");
                choix = Console.ReadLine();
            } while (choix.Contains("O") || choix.Contains("o"));
           
            Console.Read();
        }
    }
}
