using CompteEnBanque;
using BanqueDuCompte;
namespace CompteEnBanque;

    internal class Program
    {
        static void Main(string[] args)
        {
            Banque b = new Banque("Credit Mututu", "Mulhouse");

            b.AjouterCompte(1245, "Robert", 2000, -300);
            b.AjouterCompte(2568, "Denis", 1000, -300);

            Banque c = new Banque("Credit Agricole", "Strasbourg");

            bool result = b.Transferer(1245, 2568, 2300);
            Console.WriteLine(result);
        Console.WriteLine(b.ToString());
        }
    }

