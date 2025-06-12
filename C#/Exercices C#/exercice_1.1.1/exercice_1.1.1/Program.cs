namespace exercice_1._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            double moyenne;
            String choix = "";
            do
            {
                Console.WriteLine("Saisir deux nombres séparés par un espace.");
                String reponse = Console.ReadLine();
                String[] nombres = reponse.Split(' ');
                if (nombres.Length > 1)
                {
                    if (int.TryParse(nombres[0], out a))
                    {
                        Console.WriteLine("a : " + a);
                        if (int.TryParse(nombres[1], out b))
                        {
                            Console.WriteLine("b : " + b);
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
                    Console.WriteLine("La saisie est fausse, il manque un éspace vide !");
                }
                moyenne = (double)(a + b) / 2;
                Console.WriteLine("La moyenne de a et b est de " + moyenne);
                Console.WriteLine("Voulez-vous calculer à nouveau ?");
                choix = Console.ReadLine();
            }
            while (choix.Contains("O") || choix.Contains("o"));
            
        }
    }
}
