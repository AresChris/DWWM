namespace exercice_2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kms, miles;
            String[] tableau;

            Console.WriteLine("Programme de conversion kilomètres <-> Miles");
            Console.Write("Saisir une valeur et son unité de mesure(séparés par un éspace) : ");
            String input = Console.ReadLine();

            tableau = input.Split(' ');

            if (tableau[1].Contains("kms"))
            {
                if (double.TryParse(tableau[0], out kms))
                {
                    miles = kms * 1.609;
                    Console.WriteLine($"{input} = {miles:F2} miles");
                }
            }
            else if (tableau[1].Contains("mi"))
            {
                if (double.TryParse(tableau[0], out miles))
                {
                    kms = miles / 1.609;
                    Console.WriteLine($"{input} = {kms:F2} kms");
                }
            }
            else
            {
               Console.WriteLine("Il n'y à rien dans le tableau");
            }
        }
    }
}
