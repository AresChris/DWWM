using ClassLibraryBouteille;

namespace bouteilleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille evian = new Bouteille("Evian", 100, 50);
            Bouteille volvic = new Bouteille("Volvic", 150, 150);
            Bouteille cristalline = new Bouteille("Cristalline", 150, 100);
            List<Bouteille> bouteilles = new List<Bouteille> { evian, volvic, cristalline };


            evian.ouvrir();
            Console.WriteLine(evian.ToString());
            bool result = evian.ouvrir();
            Console.WriteLine(result);

            evian.fermer();
            Console.WriteLine(evian.ToString());

            result = evian.ouvrir();
            Console.WriteLine(result);

            evian.remplir(20);
            Console.WriteLine(evian.ToString());
            
            evian.vider(20);
            Console.WriteLine(evian.ToString());

            evian.fermer();
            Console.WriteLine(evian.ToString());
            evian.remplir(20);
            Console.WriteLine(evian.ToString());
            evian.ouvrir();
            Console.WriteLine(evian.ToString());
            evian.remplir(20);
            Console.WriteLine(evian.ToString());
        }
    }
}
