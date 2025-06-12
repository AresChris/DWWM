using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassCompteBancaire
{
    internal class CompteBancaire : IComparable<CompteBancaire>
    {
        public int numero;
        public string nom;
        public decimal solde;
        public int decouvertAutorise;

        public CompteBancaire() : this(0, "Inconnu", 0, 0)
        {
        }

        public CompteBancaire(int _numero, string _nom, decimal _solde, int _decouvertAutorise)
        {

            numero = _numero;
            nom = _nom;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }
        public CompteBancaire(CompteBancaire compteAcopier) : this(compteAcopier.numero, compteAcopier.nom, compteAcopier.solde, compteAcopier.decouvertAutorise)
        {
        }

        public override string ToString()
        {
            return $"numéro : {numero} - nom : {nom} - Solde : {solde} - Découvert autorisé : {decouvertAutorise}";
        }
        public void Crediter(decimal montant)
        {
            if (montant < 0)
            {
                throw new ArgumentException("Le montant à créditer doit être positif.", nameof(montant));
            }
            solde += montant;
        }
        public bool Debiter(int montant)
        {
            if (montant < 0)
            {
                throw new ArgumentException("Le montant doit être supérieur à 0" + montant);
            }
            if (montant > 0 && (solde - montant) >= decouvertAutorise)
            {
                solde -= montant;
                return true;
            }
            else
            {
                return false;
            }
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
        public bool Superieur(CompteBancaire _autreCompte)
        {
            if (_autreCompte == null)
            {
                throw new ArgumentNullException("L'autre compte ne peut pas être nul.");
            }
            if (this.solde > _autreCompte.solde)
            {
                return true;
            }

            return false;
        }

        public int CompareTo(CompteBancaire autreCompte)
        {
            if (autreCompte == null)
            {
                throw new ArgumentNullException("L'autre compte ne peut pas être nul.");
            }

            if (this.solde > autreCompte.solde)
            {
                return 1;
            }
            else if (this.solde < autreCompte.solde)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
