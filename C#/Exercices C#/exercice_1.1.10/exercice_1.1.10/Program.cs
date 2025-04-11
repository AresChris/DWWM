namespace exercice_1._1._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuer = false;
            do
            {
                Console.Write("Combien de nombres parfaits voulez-vous afficher ?");
                int nombre = int.Parse(Console.ReadLine());

                if (nombre > 4)
                {
                    Console.WriteLine("Au delà de 4, le temps de calcul serait trop long");
                }
                else
                {
                    int count = 0;
                    int i = 1;
                    while (count < nombre)
                    {
                        if (EstParfait(i))
                        {
                            Console.WriteLine(i + " est un nombre parfait.");
                            count++;
                        }
                        i++;
                    }
                }
                Console.Write("Voulez-vous recommencer ? oui ou non : ");
                string reponse = Console.ReadLine();
                if(reponse.ToLower() == "non")
                {
                    Console.WriteLine("Fin du programme.");
                    break;
                }
                else if(reponse.ToLower() == "oui")
                {
                    continuer = true;
                }
            } while(continuer);

        }
        static bool EstParfait(int nombre)
        {
            int sommeDiviseurs = 0;
            for (int i = 1; i <= nombre /2; i++)
            {
                if (nombre % i == 0)
                {
                    sommeDiviseurs += i;
                }
            }
            return sommeDiviseurs == nombre;
        }
    }
}
