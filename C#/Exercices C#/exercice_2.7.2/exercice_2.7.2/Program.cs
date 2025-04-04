namespace exercice_2._7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nbPersonnes = [20];
            int nbJeunes = 0;


            for (int i = 0; i < nbPersonnes.Length; i++)
            {
                do
                {
                    Console.Write($"Age de la personne {i + 1} :");
                    int age = int.Parse(Console.ReadLine());
                    i++;
                    if (age < 20)
                    {
                        nbJeunes++;
                    }
                } while (i < 20);
            }
            if (nbJeunes == 0)
            {
                Console.WriteLine("Toutes les personnes ont moins de 20 ans.");
            }
            else if (nbJeunes == 20)
            {
                Console.WriteLine("Toutes les personnes ont moins de 20 ans.");
            }
            else
            {
                {
                    Console.WriteLine($"Il y à {nbJeunes} jeunes de moins de 20 ans.");
                }
            }
            
        }
    }
}

