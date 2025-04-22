namespace moyenne_notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] tableau;
            double temp = 0;
            Console.Write("Combien de notes voulez-vous ajouter ? : ");
            int taille = int.Parse(Console.ReadLine());

            tableau = new double[taille];

            for (int i = 0; i < taille; i++)
            {
                Console.Write($"Inscrivez la note {i+1} : ");
                tableau[i] = int.Parse(Console.ReadLine());
                temp = tableau[i] + temp;
            }
            temp = temp / taille;
            Console.WriteLine($"La moyenne est de {temp:F2}");
        }
    }
}

