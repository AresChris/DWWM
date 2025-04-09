namespace exercice_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> listReversed = new List<string>();

            Console.WriteLine("Programme de vérification de palindrome\n");
            Console.Write("Ecrivez une phrase ou un mot à vérifier : ");
            String input = Console.ReadLine();

            list.Add(input);
            string reversedInput = new string(input.Reverse().ToArray());

            if(input.Equals("."))
            {
                Console.WriteLine("La chaine est vide.");
            }
            else if (input.Equals(reversedInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("La phrase/le mot, est un palindrome.");
            }
            else
            {
                Console.WriteLine("La phrase/le mot, n'est pas un palindrome");
            }
        }
    }
}
