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

            Console.WriteLine($"{capitalEmprunt} euros empruntés à {tauxInteretAnnuel}% d'interêts, et sur {nbrAnneeRmbt} an(s)");
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