using Voitures;

namespace Voitures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture clio = new Voiture("Renault", "Clio", true, 150000);
            Voiture sunny = new Voiture("Nissan", "Sunny", true, 185000);
            Voiture golf = new Voiture("Volkswagen", "Golf", false, 200000);
            List<Voiture> voitures = new List<Voiture> { clio, sunny, golf };

            // Demarrer quand la voiture est démarrée
            clio.Demarrer();
            Console.WriteLine(clio.ToString());
            // Avancer de 10 km
            clio.Avancer(10);
            Console.WriteLine(clio.ToString());
            // Avancer de 100 km
            clio.Avancer(100);
            Console.WriteLine(clio.ToString());
            // Arreter
            clio.Arreter();
            Console.WriteLine(clio.ToString());
            // Avancer quand la voiture est à l'arrêt
            clio.Avancer(10);
            Console.WriteLine(clio.ToString());
        }
    }
}
