namespace exercice_2._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kms, miles;
            String[] tabNombre;
            String input;
            Console.WriteLine("Programme de conversion Kilomètres/Miles");

            Console.WriteLine("Saisissez une valeur et son unité de mesure (séparé par un espace) :");
            input = Console.ReadLine();
            tabNombre = input.Split(' ');

            if (tabNombre.Length == 2)
            {
                if (tabNombre[1].ToLower() == "kms")
                {
                    if (double.TryParse(tabNombre[0], out kms))
                    {
                        miles = kms / 1.609;
                        Console.WriteLine($"{kms} kilomètres = {miles} miles.");
                    }
                }
                else if (tabNombre[1].ToLower() == "mi")
                {
                    if (double.TryParse(tabNombre[0], out miles))
                    {
                        kms = miles * 1.609;
                        Console.WriteLine($"{miles} miles = {kms} kilomètres.");
                    }
                }
            }
            else
            {
                if (double.TryParse(tabNombre[0], out kms))
                {
                    input = "kms";
                    miles = kms / 1.609;
                    Console.WriteLine($"{kms} kilomètres = {miles} miles.");
                }
                
            }
        }
    }
}

