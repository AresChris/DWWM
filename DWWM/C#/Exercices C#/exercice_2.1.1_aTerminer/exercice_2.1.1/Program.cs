namespace exercice_2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kms = 0, miles = 0;
            String input;
            Boolean quit = true;

            Console.WriteLine("Programme de conversion Kilomètres/Miles");
            Console.WriteLine("Saisissez une valeur en kilomètres");
            input = Console.ReadLine();

            if(double.TryParse(input, out kms) )
            {
                miles = kms / 1.609;
                Console.WriteLine($"{kms} kms = {miles:F4} miles");
            }
            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadKey();
        }
    }
}
