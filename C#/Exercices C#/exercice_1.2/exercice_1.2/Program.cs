namespace exercice_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rayon = 0, aire = 0, volume = 0;
            bool continuer = false;
            
            do
            {
                Console.WriteLine("Indiquez le rayon de la sphère");
                string input = Console.ReadLine();
                if (double.TryParse(input, out rayon)) // Si contient un double(saisie "input" va dans rayon)
                {
                    aire = 4 * Math.PI * Math.Pow(rayon, 2);
                    volume = (4.0 / 3.0) * Math.PI * Math.Pow(rayon, 3);

                    Console.WriteLine($"L'aire de la sphère est : {aire:F2}"); //F2 = 2 décimale (aucun d'espace)
                    Console.WriteLine($"Le volume de la sphère est : {volume:F2}");
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un rayon valide");
                }
                Console.WriteLine("Voulez-vous continuer ? oui ou non");
                string reponse = Console.ReadLine();
                if(reponse.ToLower() == "oui")
                {
                    continuer = true;
                }
                else
                {
                    continuer = false;
                    Console.WriteLine("Fin du programme.");
                    break;
                }
            } while (continuer);
            

        }
    }
}
