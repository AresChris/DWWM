namespace exercice_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();
            bool empty = false;
            int count = 0;
            
            do
            {
                Console.Write("Entrez un mot ou une phrase : ");
                String phrase = Console.ReadLine();
                list.Add(phrase);

                if (phrase.Equals("."))
                {
                    empty = true;
                    Console.WriteLine("La chaine est vide, seule un '.' à été trouvé");
                    Console.Write("Entrez un mot ou une phrase : ");
                    phrase = Console.ReadLine();
                }
                Console.WriteLine("Quelle lettre recherchez vous dans la phrase ?");
                String lettre = Console.ReadLine();

                foreach (char c in phrase.ToLower())  
                {
                    if (c == lettre[0])  // Comparer chaque caractère avec la lettre
                    {
                        count++;
                    }
                }
                Console.WriteLine($"La lettre {lettre} est présente {count} fois.");
            } while(empty);            
        }
    }
}
