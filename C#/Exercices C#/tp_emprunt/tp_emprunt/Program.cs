namespace tp_emprunt
{
    internal class Program
    {
        static void Tableau_amortissement()
        {
            double tauxInteretAnnuel;
            int nbrAnneeRmbt;
            double capitalEmprunt;
            double tauxInteretMensuel;
            double mensualite;
            int mois;
            double interetMensuel;
            double amortissementMois;

            Console.Write("Quelle est la somme empruntée ? : ");
            capitalEmprunt = double.Parse(Console.ReadLine());

            Console.Write("Taux d'interêts annuel : ");
            tauxInteretAnnuel = double.Parse(Console.ReadLine());

            Console.Write("Sur combien de temps ? : ");
            nbrAnneeRmbt = int.Parse(Console.ReadLine());

            Console.WriteLine($"{capitalEmprunt} \u20AC empruntés à {tauxInteretAnnuel}% d'interêts, et sur {nbrAnneeRmbt} an(s)");
            tauxInteretMensuel = tauxInteretAnnuel / 100 / 12;
            int nbrMois = nbrAnneeRmbt * 12;

            mensualite = capitalEmprunt * (tauxInteretMensuel * Math.Pow(1 + tauxInteretMensuel, nbrMois)) / (Math.Pow(1 + tauxInteretMensuel, nbrMois) - 1);
            Console.WriteLine($"Mensualités : {mensualite:F2} par mois");

            double capitalRestantDu = capitalEmprunt;

            Console.WriteLine("\nTableau d'amortissement :\n");

            mois = 0;
            Console.WriteLine("\tMois\t\tInterêts mensuels\tAmortissements\tCapital restant dû");
            Console.WriteLine("------------------------------------------------------------------------------------");
            for (mois = 1; mois < nbrMois; mois++ )
            {
                interetMensuel = capitalRestantDu * tauxInteretMensuel;

                amortissementMois = mensualite - interetMensuel;

                capitalRestantDu -= amortissementMois;
                
                Console.WriteLine($"\t{mois}\t|\t{interetMensuel:F2}\t\t|\t{amortissementMois:F2}\t\t|{capitalRestantDu:F2}");
            }
        }
        static void Main(string[] args)
        {
            
            Tableau_amortissement();
        }
    }
}
/*
 * using System;

class Program
{
    static void tableau_amortissement()
    {
        // Demander à l'utilisateur le capital emprunté et le taux d'intérêt
        Console.WriteLine("Quelle est la somme empruntée ?");
        double capitalEmprunt = double.Parse(Console.ReadLine());

        Console.WriteLine("Quel est le taux d'intérêt annuel (%) ?");
        double tauxInteretAnnuel = double.Parse(Console.ReadLine());

        Console.WriteLine("Sur combien d'années ? ");
        int nbrAnneeRmbt = int.Parse(Console.ReadLine());

        // Calculer le taux d'intérêt mensuel et le nombre total de mois
        double tauxInteretMensuel = tauxInteretAnnuel / 100 / 12;
        int nbrMois = nbrAnneeRmbt * 12;

        // Calculer la mensualité
        double mensualite = capitalEmprunt * (tauxInteretMensuel * Math.Pow(1 + tauxInteretMensuel, nbrMois)) / (Math.Pow(1 + tauxInteretMensuel, nbrMois) - 1);

        Console.WriteLine($"La mensualité est de : {mensualite:F2} par mois");

        // Initialiser le capital restant dû
        double capitalRestantDu = capitalEmprunt;

        // Affichage du tableau d'amortissement
        Console.WriteLine("\nTableau d'amortissement :");
        Console.WriteLine("Mois\t\tIntérêts\tAmortissement\tCapital restant dû");

        // Boucle sur chaque mois
        for (int mois = 1; mois <= nbrMois; mois++)
        {
            // Calcul des intérêts pour ce mois
            double interetMensuel = capitalRestantDu * tauxInteretMensuel;

            // Calcul de l'amortissement du capital pour ce mois
            double amortissementMois = mensualite - interetMensuel;

            // Mise à jour du capital restant dû
            capitalRestantDu -= amortissementMois;

            // Affichage des informations pour ce mois
            Console.WriteLine($"{mois}\t\t{interetMensuel:F2}\t\t{amortissementMois:F2}\t\t{capitalRestantDu:F2}");
        }
    }

    static void Main(string[] args)
    {
        tableau_amortissement();
    }
}

 */
