using System.Reflection.Metadata.Ecma335;

namespace exercice_2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimum = 0, maximum = 0;
            double celsius, fahrenheit;
            String choix;
            bool quit = false, continuer = false;
            

            Console.WriteLine("Programme de conversion");

            do
            {
            Console.Write("Saisir une mesure, C ou F ?");
            String uniteMesure = Console.ReadLine();

            Console.Write("Indiquez le nombre le plus petit à convertir : ");
            minimum = int.Parse(Console.ReadLine());

            Console.Write("Indiquez le nombre le plus grand à convertir : ");
            maximum = int.Parse(Console.ReadLine());
            if (uniteMesure.ToLower().Equals("c"))
            {
                for (int i = minimum; i <= maximum; i++)
                {
                 fahrenheit = (i * 9 / 5) + 32;
                 celsius = (i - 32) * 5 / 9;
                 Console.WriteLine($"{i}°C = {fahrenheit:F1}°F ");
                }
            }
            else if (uniteMesure.ToLower().Equals("f"))
            {
                 for (int i = minimum; i <= maximum; i++)
                 {
                      celsius = (i - 32) * 5 / 9;
                      fahrenheit = (i * 9 / 5) + 32;
                      Console.WriteLine($"{i}°F = {celsius:F1}°C ");
                 }
            }
            else
            {
                 Console.WriteLine("Erreur, veuillez saisir 'c' pour Celsius ou 'f' pour fahrenheit");
            }
                 Console.WriteLine("Quitter ou continuer ? 'quit' ou 'continuer'");
                 choix = Console.ReadLine();
                if (choix.ToLower().Equals("quit"))
                {
                    quit = true;
                }
                else if (choix.Equals("continuer"))
                {
                    quit = false;
                }   
            }while (!quit);
        }
    }
}




/*
 * celsius = (maximum - 32) * 5 / 9;
 * Fahrenheit = (minimum * 9 / 5) + 32;
 */
/*
 * Formule °F vers °C : °C = (X − 32) * 5/9
 *  Formule °C vers °F : °F = (X * 9/5) + 32
 */

