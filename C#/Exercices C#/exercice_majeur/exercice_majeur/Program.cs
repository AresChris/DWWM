namespace exercice_majeur
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DateTime dateNaissance;
            String reponse;

            Console.Write("Date de naissance dd/mm/yyyy : ");
            reponse = Console.ReadLine();

            String[] tableau = reponse.Split('/');

            dateNaissance = new DateTime(int.Parse(tableau[2]), int.Parse(tableau[1]), int.Parse(tableau[0]));

            ControleSaisie monControle = new ControleSaisie();

            bool estMajeur = monControle.Majorite(dateNaissance);

            if(estMajeur)
            {
                Console.WriteLine("Vous êtes majeur.");
            }
            else
            {
                    Console.WriteLine("Vous êtes mineur.");
            }
        }
        public class ControleSaisie
        {
            public bool Majorite(DateTime _maDate)
            {
                bool estMajeur = false;
                DateTime datedujour = DateTime.Today;
                TimeSpan ecart = datedujour.Subtract(_maDate);
                double nbAnnee = (ecart.Days) / 365.2425;

                if(nbAnnee >= 18)
                {
                    estMajeur = true;
                }
                return estMajeur;
            }
        }
    }
}
