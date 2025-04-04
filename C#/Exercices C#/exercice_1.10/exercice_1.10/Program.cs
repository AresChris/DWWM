namespace nombresParfaits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de nombres parfaits souhaitez-vous ?");
            int nombreSouhaites = int.Parse(Console.ReadLine());
            int compteur = 0, valeur = 2;
            List<int> lesDiviseurs = new List<int>();
            do
            {
                lesDiviseurs = rechercherDiviseurs(valeur);
                int masomme = SommeDesDiviseurs(lesDiviseurs);
                if (masomme == valeur)
                {
                    Console.WriteLine($"{valeur} est un nombre parfait.");
                    compteur++;
                }
                valeur++;
            }
            while (compteur < nombreSouhaites);
        }
        public static List<int> rechercherDiviseurs(int _nombre)
        {
            List<int> diviseurs = new List<int>();
            for (int i = 2; i < _nombre; i++)
            {
                if (_nombre % i == 0)
                {
                    diviseurs.Add(i);

                }
            }
            return diviseurs;
        }
        public static void AfficherDiviseurs(List<int> _diviseurs)
        {
            Console.Write("\n[ ");
            foreach (int i in _diviseurs)
            {
                Console.Write(i + " ");
            }
            Console.Write("]\n");
        }
        public static int SommeDesDiviseurs(List<int> _diviseurs)
        {
            int somme = 1;
            foreach (int i in _diviseurs)
            {
                somme += i;
            }
            return somme;
        }
    }
}
