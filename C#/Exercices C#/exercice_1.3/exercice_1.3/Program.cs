using System.ComponentModel.Design;

namespace exercice_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rayon = 0, angle = 0, aireSecteurCirculaire = 0;
            Boolean saisie = true;
           
            do
            {
                Console.WriteLine("Saisir le rayon");
                String input = Console.ReadLine();
                if (double.TryParse(input, out rayon))
            {
                Console.WriteLine($"Inscrivez l'angle en degrés : ");
                input = Console.ReadLine();
                saisie = true; 
                if (double.TryParse(input, out angle))
                {
                    saisie = true;
                    aireSecteurCirculaire = Math.PI * Math.Pow(rayon, 2) * angle / 360;
                }
                else
                {
                    saisie = false;
                    Console.WriteLine("Erreur, inscrivez des nombres.");
                }
            }
            else
            {
                saisie = false;
                Console.WriteLine("Erreur, inscrivez des nombres.");
            }
                Console.WriteLine($"Aire du secteur circulaire : {aireSecteurCirculaire:F2}");
                Console.WriteLine("Nouveau calcul ? Oui/Non");
                input = Console.ReadLine().ToLower();
                    if(input.ToLower() == "oui")
                    {
                        saisie = true;
                    }
                    else
                    {
                        saisie = false;
                        Console.WriteLine("Fin de programme");
                        break;
                    }
            } while(saisie);
            
            
        }
    }
}

