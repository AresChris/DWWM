using System;

class Program
{
    static void Main(string[] args)
    {
        // Demander à l'utilisateur d'entrer une phrase
        Console.Write("Entrez une phrase : ");
        string phrase = Console.ReadLine();

        // Appeler la méthode pour compter les voyelles et les consonnes
        CompterVoyellesConsonnes(phrase);
    }
    // Méthode pour compter les voyelles et les consonnes
    static void CompterVoyellesConsonnes(string phrase)
    {
        int nombreVoyelles = 0;
        int nombreConsonnes = 0;

        // Convertir la phrase en minuscules pour faciliter la comparaison
        phrase = phrase.ToLower();

        // Parcourir chaque caractère de la phrase
        foreach (char c in phrase)
        {
            // Vérifier si le caractère est une lettre
            if (char.IsLetter(c))
            {
                // Vérifier si c'est une voyelle
                if ("aeiouy".Contains(c) || "àèéôûù".Contains(c))
                {
                    nombreVoyelles++;
                }
                else
                {
                    // Si ce n'est pas une voyelle, c'est une consonne
                    nombreConsonnes++;
                }
            }
        }

        // Afficher les résultats
        Console.WriteLine($"Nombre de voyelles : {nombreVoyelles}");
        Console.WriteLine($"Nombre de consonnes : {nombreConsonnes}");
    }
}
