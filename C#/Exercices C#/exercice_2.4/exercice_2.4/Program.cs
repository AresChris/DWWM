namespace exercice_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Barnabé fait ses courses");
            
            int count = 0;
            bool autreCalcul = true;

            do
            {
                Console.Write("Combien d'argent Barnabé à-t-il en poche ? : ");
                int somme = int.Parse(Console.ReadLine());
                for (int i = 0; i < somme; i++)
                {
                    if (somme > 1)
                    {
                        somme = somme / 2 + 1;
                        count++;
                        Console.WriteLine($"Magasin {count} : {somme} Euros");
                    }
                }
                Console.WriteLine($"Barnabé à dépensé dans {count + 1} magasins.");
                Console.WriteLine("Voulez-vous recommencer ? oui ou non");
                String recommencer = Console.ReadLine();
                    if(recommencer.Equals("oui"))
                {
                    autreCalcul = true;
                }
                else
                {
                    autreCalcul = false;
                }
            } while(autreCalcul);
        }
    }
}
