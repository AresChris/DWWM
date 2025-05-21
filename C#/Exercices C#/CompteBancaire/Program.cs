using ClassCompteBancaire;
namespace ProgrammeCompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CompteBancaire b = new CompteBancaire(545454, "Laurent", 2000, -500);
            //CompteBancaire bob = new CompteBancaire(654321, "Bob", 500, 100);

            CompteBancaire c1 = new CompteBancaire(12345, "toto", 1000, -500);
            CompteBancaire c2 = new CompteBancaire(45657, "titi", 2000, -1000);
            c1.Transferer(1300, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());

            if(c1.Superieur(c2))
            {
                Console.WriteLine("Superieur");
            }
            else
            {
                Console.WriteLine("Inférieur");
            }

        }
    }
}
