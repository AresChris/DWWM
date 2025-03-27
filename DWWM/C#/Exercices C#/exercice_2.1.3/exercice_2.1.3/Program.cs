namespace exercice_2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            String saisie;
            int somme = 0, count = 0, kms = 0, miles = 0;
            int[] tabNombre;

            Console.WriteLine("Saisir des nombres à convertir");
            saisie = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(saisie))
            {
                Console.WriteLine("Erreur de saisie");
                return;
            }
            String[] valeurs = saisie.Split(' ');
            try
            {

            }
            catch
            {
                Console.WriteLine(FormatException)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}