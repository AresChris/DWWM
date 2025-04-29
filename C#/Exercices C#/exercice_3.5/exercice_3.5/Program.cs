namespace exercice_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> listReversed = new List<string>();
            bool continuer = true;
            do
            {
                Console.WriteLine("Programme de vérification de palindrome\n");
                Console.Write("Ecrivez une phrase ou un mot à vérifier : ");
                String input = Console.ReadLine().ToLower();

                input = input.Replace(" ", "");
                input = input.Replace("à", "a");
                input = input.Replace("é", "e");
                input = input.Replace("è", "e");
                input = input.Replace("â", "a");
                input = input.Replace(".", "");

                list.Add(input);

                char[] reversedInput = input.ToCharArray();
                Array.Reverse(reversedInput);
                string reversed = new string(reversedInput);

                reversed = reversed.Replace(" ", "");
                reversed = reversed.Replace("à", "a");
                reversed = reversed.Replace("é", "e");
                reversed = reversed.Replace("è", "e");
                reversed = reversed.Replace("â", "a");
                reversed = reversed.Replace(".", "");

                if (input.Equals("."))
                {
                    Console.WriteLine("La chaine est vide.");
                }
                else if (input.Equals(reversed))
                {
                    Console.WriteLine("La phrase/le mot, est un palindrome.");
                }
                else
                {
                    Console.WriteLine("La phrase/le mot, n'est pas un palindrome");
                }
                Console.WriteLine("Voulez-vous recommencer ?");
                input = Console.ReadLine().ToLower();
                    if (input.Equals("oui"))
                    {
                        continuer = true;
                    }
                    else
                    {
                        continuer = false;
                    }
            } while (continuer);
        }
    }
}