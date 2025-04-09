namespace Anagramme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();

            Console.Write("Saisis un premier mot : ");
            string input = Console.ReadLine().ToLower().Trim();
            list.Add(input);

            Console.Write("Saisis un deuxième mot : ");
            input = Console.ReadLine().ToLower().Trim();
            list2.Add(input);

            // Normaliser les mots : Convertir en minuscules et supprimer les espaces
            string mot1 = list[0].ToLower().Replace(" ", "");
            string mot2 = list2[0].ToLower().Replace(" ", "");

            if (list.Count == list2.Count)
            {
                char[] tab1 = mot1.ToCharArray();
                char[] tab2 = mot2.ToCharArray();
                Array.Sort(tab1);
                Array.Sort(tab2);
                for (int i = 0; i < list.Count; i++)
                {
                    if(new string(tab1) == new string (tab2))
                    {
                        Console.WriteLine("Ces deux mots sont des anagrammes.");
                    }
                    else
                    {
                        Console.WriteLine("Ces deux mots ne sont pas des anagrammes");
                    }
                }
            }
        }
    }
}
