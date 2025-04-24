namespace exercice_2._7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nbPersonnes = [20];
            int nbJeunes = 0;
            int nbPasJeunes = 0;
            List<int> jeunes = new List<int>();
            List<int> pasJeunes = new List<int>();

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
                        jeunes.Add(age);
                    }
                    else if (age >= 20)
                    {
                        nbPasJeunes++;
                        pasJeunes.Add(age);
                    }
                } while (i < 20);
            }
            if (nbJeunes == 0 && nbPasJeunes > 0)
            {
                Console.WriteLine("Pas de jeunes :");
                foreach (int age in pasJeunes)
                {
                    Console.Write($" {age} ");
                }
            }
            else if(nbJeunes > 0 && nbPasJeunes == 0)
            {
                Console.WriteLine("Pas de non jeunes : ");
                foreach (int age in jeunes)
                {
                    Console.Write($" {age} ");
                }
            }
            else if(nbJeunes > 0 && nbPasJeunes > 0)
            {
                Console.WriteLine("Des jeunes et des non jeunes : ");
                foreach (int age in jeunes)
                {
                    Console.Write($" {age} ");
                }
                foreach (int age in pasJeunes)
                {
                    Console.Write($" {age} ");
                }
            }
        }
    }
}

