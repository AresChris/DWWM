namespace exercice_1._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annee;
            Boolean relancer = true;
           
            do
            {
                Console.WriteLine("Quelle année voulez-vous vérifier ?");
                String input = Console.ReadLine();

                if (int.TryParse(input, out annee))
                {
                    if ((annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0)
                    {
                        Console.WriteLine("L'année est bissextile");
                    }
                    else
                    {
                        Console.WriteLine("L'année n'est pas bissextile.");
                    }
                }
                else
                {
                    Console.WriteLine("Erreur de saisie");
                }
                Console.WriteLine("Voulez-vous vérifier une autre année ? (O/N)");
                String reponse = Console.ReadLine().ToLower();
                    if (reponse.Contains("o"))
                    {
                        relancer = true;
                    }
                    else
                    {
                        relancer = false;
                }
            } while (relancer);
            Console.WriteLine("Fin de programme, appuyez sur n'importe quelle touche pour quitter.");
            Console.ReadKey();
        }
    }
}
