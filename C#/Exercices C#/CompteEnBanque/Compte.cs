using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteEnBanque
{
    internal class Compte
    {
        private int decouvertAutorise;
        private int numero;
        private int solde;

        public Compte(int _decouvertAutorise, int _numero, int _solde)
        {
            this.decouvertAutorise = _decouvertAutorise;
            this.numero = _numero;
            this.solde = _solde;
        }
        public Compte(Compte compteAcopier)
        {
            this.decouvertAutorise = compteAcopier.decouvertAutorise;
            this.numero = compteAcopier.numero;
            this.solde = compteAcopier.solde;
        }
        public string ToString()
        {
            return "Numéro de compte: " + numero + "\n" +
                   "Solde: " + solde + "\n" +
                   "Découvert autorisé: " + decouvertAutorise + "\n";
        }
        public void Crediter(int montant)
        {
            if (montant < 0)
            {
               throw new ArgumentException("Le montant doit être supérieur à 0");
            }
            if(montant>0)
            {
                solde += montant;
            }
        }
        public bool Debiter(int montant)
        {
            if(montant < 0)
            {
                throw new ArgumentException("Le montant doit être supérieur à 0" + montant);
            }
            if (montant > 0)
            {
                solde -= montant;
                return true;
            }
            return false;
        }
        public void AfficherSolde()
        {
            Console.WriteLine($"Le solde du compte est de {this.solde} euros.");
        }
        public bool Superieur(Compte _autreCompte)
        {
            if(this.solde > _autreCompte.solde)
            {
                return true;
            }
            return false;
        }
        public bool Transferer(int montant, Compte compteDestinataire)
        {
            if (montant < 0)
            {
                throw new ArgumentException("Le montant à transférer doit être positif.");
            }

            if (montant > 0)
            {
                if (this.Debiter(montant))
                {
                    compteDestinataire.Crediter(montant);
                    return true;
                }
            }
            return false;
        }
    }
}
