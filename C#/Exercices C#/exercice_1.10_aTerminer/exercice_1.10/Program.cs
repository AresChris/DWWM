namespace exercice_1._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre = 0;
            int sommeDiviseur = 0;
            int somme = 0;

            Console.WriteLine("Combien de nombres parfaits voulez-vous afficher ?");
            String input = Console.ReadLine();

            if (int.TryParse(input, out nombre))
            {
                for (int i = 1; i <= nombre; i++)
                {
                    sommeDiviseur = 0;
                    for (int j = 1; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            sommeDiviseur += j;
                        }
                    }
                    if (sommeDiviseur == i)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Entrée invalide");
            }
        }
    }
}
