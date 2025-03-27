namespace exercice_1._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre;

            Console.WriteLine("Saisir un nombre à vérifier.");
            String input = Console.ReadLine();

            if (int.TryParse(input, out nombre))
            {
                Console.Write($"{nombre} est divisible par ");
                for (int i = 2; i <= nombre-1; i++)
                {
                    if(nombre%i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Saisissez un nombre valide");
            }
        }
    }
}
