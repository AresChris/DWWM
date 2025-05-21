using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteilles
{
    public class Bouteille
    {
        private bool estOuverte;
        private string nom;
        private decimal contenanceEnLitre;
        private decimal contenuEnLitre;

        //constructeur par default
        public Bouteille() : this(false, "bouteille", 0, 0)
        {

        }

        //classique
        public Bouteille(bool ouverte, string nom, int contenanceEnLitre, int contenu)
        {
            this.estOuverte = ouverte;
            this.nom = nom;
            this.contenanceEnLitre = contenanceEnLitre;
            this.contenuEnLitre = contenu;
        }

        public Bouteille(Bouteille bouteilleACopier)
        {
            this.estOuverte = bouteilleACopier.estOuverte;
            this.nom = bouteilleACopier.nom;
            this.contenanceEnLitre = bouteilleACopier.contenanceEnLitre;
            this.contenuEnLitre = bouteilleACopier.contenuEnLitre;
        }

        //clonage
        public override string ToString()
        {
            //    string description = $" est ouverte : {this.estOuvert} /Sa contenance en litre : {this.contenanceEnLitre} /Son contenu en litre : {this.contenuEnLitre}";

            return base.ToString() + " : " + nameof(estOuverte) + " = " + estOuverte + " : " + nameof(contenanceEnLitre) + " = " + contenanceEnLitre + " : " + nameof(contenuEnLitre) + " = " + contenuEnLitre;
        }
        public bool Ouvrir()
        {
            if (estOuverte)
            {
                return false;
            }
            else
            {
                estOuverte = true;
                return true;
            }
        }

        public bool Fermer()
        {
            if (!estOuverte)
            {
                return false;
            }
            else
            {
                estOuverte = false;
                return true;
            }
        }


        public bool Remplir()
        {
            return Remplir(contenanceEnLitre - contenuEnLitre);
        }

        public bool Remplir(decimal quantiteAremplir)
        {
            if (quantiteAremplir < 0)
            {
                throw new ArgumentOutOfRangeException("La quantité à remplir ne peut pas être négative.", nameof(quantiteAremplir));
            }

            if (!estOuverte)
            {
                return false;
            }
            else
            {
                if (quantiteAremplir <= (contenanceEnLitre - contenuEnLitre))
                {
                    contenuEnLitre = quantiteAremplir + contenuEnLitre;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Vider()
        {
            return Vider(contenuEnLitre);
        }
        public bool Vider(decimal quantiteAVider)
        {
            if (quantiteAVider < 0)
            {
                throw new ArgumentOutOfRangeException("La quantité à vider ne peut pas être négative.", nameof(quantiteAVider));
            }
            if (!estOuverte)
            {
                return false;
            }
            else if (quantiteAVider >= 0 && quantiteAVider <= contenuEnLitre)
            {
                contenuEnLitre = contenuEnLitre - quantiteAVider;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
