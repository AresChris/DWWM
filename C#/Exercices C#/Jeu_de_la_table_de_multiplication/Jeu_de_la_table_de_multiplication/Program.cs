namespace Jeu_de_la_table_de_multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool continuer = true;
           Random random1 = new Random();
           Random random2 = new Random();

            do
            {
                int nombre1 = random1.Next(1, 10);
                int nombre2 = random2.Next(1, 10);

                int resultat = nombre1 * nombre2;

                Console.WriteLine($"Combien font {nombre1} x {nombre2} ?");
                int answerPlayer = int.Parse(Console.ReadLine());

                if (answerPlayer == resultat)
                {
                    Console.WriteLine("Bonne réponse !");
                }
                else
                {
                    Console.WriteLine($"Erreur :( la réponse était {resultat}");
                }
                Console.WriteLine("Voulez-vous refaire un autre calcul ? oui ou non ?");
                string input = Console.ReadLine().ToLower();
                if(input.Equals("oui"))
                {
                    continuer = true;
                }
                else
                {
                    continuer = false;
                }
            } while (continuer);
        }
    }
}
