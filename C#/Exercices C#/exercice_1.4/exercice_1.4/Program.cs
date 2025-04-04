namespace exercice_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a= 0, b = 0, c = 0;
            String input;
            Console.WriteLine("saisir la valeur de a : ");
            input = Console.ReadLine();
            if (int.TryParse(input, out a))
            {
                Console.WriteLine("saisir la valeur de b : ");
                input = Console.ReadLine();
                if (int.TryParse(input, out b))
                {
                    c = a;
                    a = b;
                    b = c;
                }
                else
                {
                    Console.WriteLine("Erreur, saisissez un nombre.");
            }
            }
            else
            {
                Console.WriteLine("Erreur, saisissez un nombre.");
            }
            Console.WriteLine($"a : {a}\nb: {b}");    
        }
    }
}
