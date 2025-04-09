namespace exercice_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tableau = {"agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie"};

            bool trouve = false;
            bool continuer = false;

            do
            {
                Console.WriteLine("Quel prénom recherchez-vous ?");
                string reponse = Console.ReadLine();
                for (int i = 0; i <= tableau.Length; i++)
                {
                    if (reponse == tableau[i])
                    {
                        Console.WriteLine($"Le prénom {reponse} est à la position {i + 1}");
                        trouve = true;
                        break;
                    }
                }
                if (!trouve)
                {
                    trouve = false;
                    Console.WriteLine("Le prénom n'est pas dans la liste");
                    break;
                }

                Console.WriteLine("Voulez-vous continuer ? oui ou non");
                string input = Console.ReadLine();
                if(input.Equals("oui"))
                {
                    continuer = true;
                }
                else if(input.Equals("non"))
                {
                    continuer = false;
                }
            } while (continuer);
            Console.WriteLine("Fin du programme");
            Console.ReadKey();
        }
    }
}
