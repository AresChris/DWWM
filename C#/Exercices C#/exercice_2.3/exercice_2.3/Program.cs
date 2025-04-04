namespace exercice_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 100;
            int min = 0;
            int compteur = 0;
            Random randomNummber = new Random();
            int computer = randomNummber.Next(0, 101);
            int human;

            do
            {
                Console.WriteLine($"Veuillez entrer un nombre entre {min} et {max} pour rechercher le nombre généré.");
                human = int.Parse(Console.ReadLine());
                if(human > computer)
                {
                    max = human;
                    compteur++;
                }
                else if(human < computer)
                {
                    min = human;
                    compteur++;
                }
                else if(computer == human)
                {
                    Console.WriteLine($"Bravo ! vous avez trouvé en {compteur} essais");
                }
            }while(human != computer);
        }
    }
}

