namespace exercice_2._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 0, celsius, Fahrenheit;
            String input;
            Console.WriteLine("Programme de conversion Celsius <-> Fahrenheit.\n\nSaisir une température avec son unité de mesure (C ou F) :");
            input = Console.ReadLine();

            String[] tableau = input.Split(' ');
            try
            {
                if (tableau.Length < 2 || string.IsNullOrEmpty(tableau[1]))
                {
                    Console.WriteLine("Erreur, unité manquante");
                }
                Console.WriteLine("Saisie incorrecte");
                if (double.TryParse(tableau[0], out value))
                {
                    if (tableau[1].Equals("f"))
                    {
                        if (value >= -459.67 && value <= 5000000)
                        {
                            celsius = (value - 32) * 5 / 9;
                            Console.WriteLine($"{value}°F = {celsius}°C");
                        }
                        else
                        {
                            Console.WriteLine("Saisie incorrecte, la valeur est trop basse, le zero absolu est à -459.67 °F et le maximum est 5 000 000.");
                        }
                    }
                    else if (tableau[1].Equals("c"))
                    {
                        if (tableau[1].Equals(""))
                        {
                            Console.WriteLine("Saisie incorrecte.");
                        }
                        if (value >= -273.15)
                        {
                            Fahrenheit = (value * 9 / 5) + 32;
                            Console.WriteLine($"{value}°C = {Fahrenheit}°F");
                        }
                        else if (value <= -273.15)
                        {
                            Console.WriteLine("Saisie incorrecte, la valeur est trop basse, le zero absolu est à -273.15 °C et le maximum est 5 000 000");
                        }
                    }
                }
            } catch (FormatException)
            {
                Console.WriteLine("Saisie incorrecte");
            }
        }
    }
}

