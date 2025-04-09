using System.Globalization;

namespace denombrementLettre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab_frequence = new int[26];
            char[] tab_alphabet = new char[26];
            string phrase_saisie;
            char lettre;
            int minimum = 120;
            char test;

            for (int i = 0; i < tab_frequence.Length; i++)
            {
                tab_frequence[i] = 0;
            }
            lettre = 'a';
            for (int i = 0; i < tab_alphabet.Length; i++)
            {
                tab_alphabet[i] = lettre;
                lettre++;
            }
            do
            {
                Console.WriteLine("Veuillez saisir un texte d'au moins 120 caractères, éspaces vides non inclus.");
                phrase_saisie = Console.ReadLine().Trim().ToLower();
            }
            while (phrase_saisie.Length < 120);
            phrase_saisie = Program.filtre_accent(phrase_saisie);

            for(int i=0; i<tab_alphabet.Length; i++)
            {
                test = tab_alphabet[i];
                for(int j=0; j< phrase_saisie.Length; j++)
                {
                    if (test == phrase_saisie[j])
                    {
                        tab_frequence[i]++;
                    }
                }
            }
            Console.WriteLine("Voici la fréquence d'apparition de chaque lettre présentent dans le texte");
            for(int i = 0; i <tab_frequence.Length; i++)
            {
                if(tab_frequence[i] > 0)
                {
                    Console.WriteLine($"La lettre {tab_alphabet} est présente {tab_frequence[i]} fois.");
                }
            }
        }
        static public string filtre_accent( string _phrase)
        {

            return _phrase;
        }
    }
}

   
