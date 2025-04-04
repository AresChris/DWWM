namespace exercice_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableau;
            int nbCases;
            Console.Write("Indiquez le nombre de cases du tableau : ");
            nbCases = int.Parse(Console.ReadLine());
            tableau = new int[nbCases];

            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine($"Veuillez saisir le nombre numéro {i + 1}/{nbCases} du tableau : ");
                tableau[i] = int.Parse(Console.ReadLine());
            }
            Program.AfficherTableau(tableau);
            TrierTableau(tableau);
            Console.WriteLine("tableau trié par ordre croissant :");
            AfficherTableau(tableau);
            rechercheValeur(tableau);
        }
        public static void AfficherTableau(int[] _monTab)
        {
            Console.Write("tableau : [ ");
            foreach (int element in _monTab)
            {
                Console.Write($"{element}  ");
            }
            Console.Write("]\n");
        }
        public static void TrierTableau(int[] _monTab)
        {
            int temp;
            bool swapped = false;

            for(int i = 0;i < _monTab.Length;i++)
            {
                for(int j = 0; j < _monTab.Length -1 -i; j++)
                {
                    if(_monTab[j] > _monTab[j+1])
                    {
                        temp = _monTab[j];
                        _monTab[j] = _monTab[j+1];
                        _monTab[j+1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }    
        }
        public static void rechercheValeur(int[] _monTab)
        {
            Console.Write("Quelle valeur recherchez-vous ? ");
            int valeur = int.Parse(Console.ReadLine());

            int index = Array.IndexOf(_monTab, valeur);

            if (index >= 0)
            {
                Console.WriteLine($"La valeur {valeur} à été trouvée à l'index {index+1}");
            }
            else
            {
                Console.WriteLine($"La valeur {valeur} n'à pas été trouvée dans le tableau.");
            }
        }
    }
}
