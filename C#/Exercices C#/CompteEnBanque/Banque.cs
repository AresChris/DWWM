using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompteEnBanque;

namespace CompteEnBanque
{
    internal class Banque
    {
        private int nbComptes;
        private int num;
        private string nom;
        private int solde;
        private int decouvertAutorise;
        private string ville;
        private List<Compte> mesComptes = new List<Compte>();
        public Banque(string _nom, string _ville)
        {
            this.nom = _nom;
            this.ville = _ville;
        }
        public string ToString()
        {
            return "Nom: " + nom + "\n" +
                   "Ville: " + ville + "\n" +
                   "Nombre de comptes: " + nbComptes + "\n" +
                   "Comptes: \n" + AfficherComptes();
        }
        public void AjouterCompte(Compte unCompte)
        {
            mesComptes.Add(unCompte);
        }
        public void AjouterCompte(int _num, string _nom, int _solde, int _decouvertAutorise)
        {

        }
        public void supprimeCompte(Compte unCompte)
        {
            mesComptes.Remove(unCompte);
        }
        public string AfficherComptes()
        {
            string comptes = "";
            foreach (Compte compte in mesComptes)
            {
                comptes += compte + "\n";
            }
            return comptes;
        }
    }
}
