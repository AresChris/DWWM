namespace exercice_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();
            Console.WriteLine("Jeu du pendu\n------------\n");

            Console.Write("Proposez un mot : ");
            String input = Console.ReadLine();

            foreach (char c in input) // pour chaque char contenus dans input
            {
                list.Add(c); // ajouter chaque char dans la liste 'list'
            }

            if (list.Count <= 5) // Si le montant de la liste est égal à 5
            {
                list[1] = '_'; // remplacer l'indice 1 de la liste par un autre caractère
                list[2] = '_';
                list[3] = '_';
            }
            else
            {
                Console.WriteLine("Maximum 5 caractères");
            }
            foreach (char c in list) // Pour chaque char de la liste
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\n");
            for (int i = list[0]; i < list.Count-1; i++)
            {
                Console.WriteLine($"Tentez de trouver les lettres manquantes, c'est à vous, lettre numéro {i} : ");
                i++;
            }
        }   
    }
}

