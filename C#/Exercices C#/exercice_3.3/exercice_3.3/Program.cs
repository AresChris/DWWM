namespace exercice_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>("abcdefghijklmnopqrstuvwxyz");
            int count = 0;

            Console.WriteLine("Ecrire un texte d'au moins 120 caractères : \n");
            String text = Console.ReadLine();

            Dictionary<char, int> letterCounts = new Dictionary<char, int>();

            if(text.Length < 120)
            {
                Console.WriteLine("Le texte doit contenir 120 caractères minimum");
            }
            else
            {
                foreach (char letter in list)
                {
                    letterCounts[letter] = 0;
                }

                foreach (char c in text.ToLower())
                {
                    if (letterCounts.ContainsKey(c))
                    {
                        letterCounts[c]++;
                    }
                }
                foreach (var letter in list)
                {
                    Console.WriteLine($"La lettre {letter} est présente {letterCounts[letter]} fois.");
                }
            }
        }
    }
}
