using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CompteEnBanque;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BanqueDuCompte
{
    internal class Banque : IComparable<Banque>
    {

        private string nom;
        private string ville;
        private List<Compte> mesComptes;
   
        public Banque(string _nom, string _ville)
        {
            this.nom = _nom;
            this.ville = _ville;
            mesComptes = new List<Compte>();
        }
        public Banque(Banque banqueAcopier) : this(banqueAcopier.nom, banqueAcopier.ville)
        {
        }
        public string ToString()
        {
            string r = $"Nom de la banque: {nom}\n" +
                       $"Ville: {ville}\n";
            foreach (Compte compte in mesComptes)
            {
                r += compte.ToString() + "\n";
            }
            return r;
            
        }

        public void AjouterCompte(Compte compte)
        {
            mesComptes.Add(compte);
        }
        public void AjouterCompte(int _numero, string _nom, int _solde, int _decouvertAutorise)
        {
            mesComptes.Add(new Compte(_decouvertAutorise, _nom, _numero, _solde));
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
                comptes += "-------------------------------\n" +
                    "Numéro de compte: " + compte.numero + "\n" +
                    "Nom: " + compte.nom + "\n" +
                   "Solde: " + compte.solde + "\n" +
                   "Découvert autorisé: " + compte.decouvertAutorise + "\n";
            }
            return comptes;
        }
        public int CompareTo(Banque autreCompte)
        {
            if (autreCompte == null)
            {
                throw new ArgumentException("L'objet à comparer ne peut pas être null");
            }
            return this.CompareTo(autreCompte);
        }

         public Compte? RendCompte(int numeroCompte)
         {
            Compte? compteRetourne=null;
            bool compteTrouve = false;
            int i = 0;
            while (i<mesComptes.Count && !compteTrouve)
            {
               if (numeroCompte == mesComptes[i].numero)
               {
                    compteTrouve = true;
                    compteRetourne = mesComptes[i];
               }
               i++;
            }
            return compteRetourne;
         }
         public bool Transferer(int numCompteOrigine , int numCompteDestinataire ,int montant)
         {
            if (montant < 0)
            {
                throw new ArgumentException("Le montant à transférer doit être positif.");
            }
            Compte? compteOrigine = RendCompte(numCompteOrigine);
            Compte? compteDestinataire = RendCompte(numCompteDestinataire);

            if (compteOrigine == null || compteDestinataire == null)
            {
                throw new ArgumentNullException("Le compte d'origine et le compte déstinataire doivent être entrés.");
            }
            compteOrigine.Transferer(montant, compteDestinataire); 

            return false;
         }
         public bool CompteSup(Compte _autreCompte)
         {
            foreach(Compte compte in mesComptes)
            {
                compte.Superieur(_autreCompte);
            }
            return false;
         } 
    }
}
