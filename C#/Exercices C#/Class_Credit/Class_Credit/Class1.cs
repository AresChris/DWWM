namespace Financier
{
    public class Credit
    {
        public double tauxMensuel;
        public double montantEmprunt;
        public int nbMois;

        public Credit(double _montant, double _tauxA, int _annees)
        {
            this.nbMois = _annees * 12;
            this.tauxMensuel = _tauxA/1200;
            this.montantEmprunt = _montant;
        }
        public double calculMensualite()
        {
            double mensualite;
            double quotient = (1- Math.Pow((1+this.tauxMensuel), -this.nbMois));
            mensualite = (montantEmprunt * tauxMensuel) / quotient;
            return Math.Round(mensualite, 2);
        }
    }
}
