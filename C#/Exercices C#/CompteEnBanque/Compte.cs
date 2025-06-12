using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BanqueDuCompte;

namespace CompteEnBanque
{
    internal class Compte
    {
        public int numero { get; set; }
        public string nom { get; set; }
        public int solde { get; set; }
        public int decouvertAutorise { get; set; }

        public Compte(int _decouvertAutorise,string _nom, int _numero, int _solde)
        {
            this.decouvertAutorise = _decouvertAutorise;
            this.nom = _nom;
            this.numero = _numero;
            this.solde = _solde;
        }
        public Compte(Compte compteAcopier): this(compteAcopier.decouvertAutorise, compteAcopier.nom, compteAcopier.numero, compteAcopier.solde)
        {
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
               solde += montant;
        }
        public bool Debiter(int montant)
        {
            if(montant < 0)
            {
                throw new ArgumentException("Le montant doit être supérieur à 0" + montant);
            }
            if (montant > 0 && (solde-montant) >= decouvertAutorise)
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
            else
            {
                return false;
            }
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
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
