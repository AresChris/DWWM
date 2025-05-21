using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassCompteBancaire
{
    internal class CompteBancaire
    {
        public int numeroDeCompte;
        public string nom;
        public int solde;
        public int decouvertAutorise;

        public CompteBancaire(): this (0, "Inconnu", 0, 0)
        {
        }
        public CompteBancaire(CompteBancaire compteAcopier)
        {
            numeroDeCompte = compteAcopier.numeroDeCompte;
            nom = compteAcopier.nom;
            solde = compteAcopier.solde;
            decouvertAutorise = compteAcopier.decouvertAutorise;
        }
        public CompteBancaire(int _numeroDeCompte, string _nom, int _solde, int _decouvertAutorise)
        {
            numeroDeCompte = _numeroDeCompte;
            nom = _nom;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }
        public override string ToString()
        {
            return $"numéro : {numeroDeCompte} - nom : {nom} - Solde : {solde} - Découvert autorisé : {decouvertAutorise}";
        }
        public string AfficherInformations()
        {
            return ToString();
        }
        public void Crediter(int montant)
        {
            if(montant < 0)
            {
                throw new ArgumentException("Le montant à créditer doit être positif.");
            }

            if (montant > 0)
            {
                solde += montant;
            }
        }
        public bool Debiter(int montant)
        {
            if (montant < 0)
            {
                throw new ArgumentException("Le montant à débiter doit être positif.");
            }

            if (montant > 0)
            {
                if (solde - montant <decouvertAutorise)
                {
                    return false;
                }
                else
                {
                    solde -= montant;
                    return true;
                }
            }
            return false;
        }
        public bool Transferer(int montant, CompteBancaire compteDestinataire)
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
        public bool ComparerSolde(CompteBancaire autreCompte)
        {
            if (autreCompte == null)
            {
                throw new ArgumentNullException("L'autre compte ne peut pas être nul.");
            }

            if(this.solde > autreCompte.solde)
            {
                this.solde -= autreCompte.solde;
                return true;
            }
            else if(this.solde < autreCompte.solde)
            {
                autreCompte.solde -= this.solde;
                return true;
            }
            else if(this.solde == autreCompte.solde)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Superieur(CompteBancaire autreCompte)
        {
            if (autreCompte == null)
            {
                throw new ArgumentNullException("L'autre compte ne peut pas être nul.");
            }
            if(this.solde > autreCompte.solde)
            {
                return true;
            }

            return false;
        }
    }
}
