using CompteEnBanque;
namespace CompteEnBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //public Compte(int _decouvertAutorise, int _numero, int _solde)
            Compte compte = new Compte(-500, 123456, 1250);
            Compte compte2 = new Compte(0, 456789 , 8500);
            Banque banque = new Banque("Banque de France", "Paris");

            Console.WriteLine($"Compte 1: {compte.ToString()}");
            Console.WriteLine($"Compte 2: {compte2.ToString()}");
            compte.Transferer(500, compte2);
            Console.WriteLine($"Compte 1: {compte.ToString()}");
            Console.WriteLine($"Compte 2: {compte2.ToString()}");

            compte.Debiter(200);
            Console.WriteLine($"Compte 1: {compte.ToString()}");

            compte.Crediter(300);
            Console.WriteLine($"Compte 1: {compte.ToString()}");

            // AjouterCompte(int _num, string _nom, int _solde, int _decouvertAutorise)
            banque.AjouterCompte(compte2);
            Console.WriteLine(banque.ToString());
            banque.AjouterCompte(compte);
            Console.WriteLine(banque.ToString());
        }
    }
}
