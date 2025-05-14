namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        private bool ouverte;
        private string nom;
        private decimal contenance;
        private decimal contenu;

        //constructeur par default
        public Bouteille()
        {
            this.ouverte = false;
            this.nom = "bout";
            this.contenance = 1;
            this.contenu = 1;
        }

        //classique
        public Bouteille(bool ouverte,string nom, int contenance, int contenu)
        {
            this.ouverte = ouverte; 
            this.nom = nom;
            this.contenance = contenance;
            this.contenu = contenu;
        }

        public Bouteille(Bouteille bouteilleACopier)
        {
            this.ouverte = bouteilleACopier.ouverte;
            this.nom = bouteilleACopier.nom;
            this.contenance = bouteilleACopier.contenance;
            this.contenu = bouteilleACopier.contenu;
        }

        //clonage
        public override string ToString()
        {
            //    string description = $" est ouverte : {this.estOuvert} /Sa contenance en litre : {this.contenanceEnLitre} /Son contenu en litre : {this.contenuEnLitre}";

            return base.ToString() + " : " + nameof(ouverte) + " = " + ouverte + " : " + nameof(contenance) + " = " + contenance + " : " + nameof(contenu) + " = " + contenu;
        }
        public bool Ouvrir()
        {
            if (ouverte)
            {
                return false;
            }
            else
            {
                ouverte = true;
                return true;
            }
        }

        public bool Fermer()
        {
            if (!ouverte)
            {
                return false;
            }
            else
            {
                ouverte = false;
                return true;
            }
        }
        public bool Remplir(decimal quantiteAremplir)
        {
            if (quantiteAremplir < 0)
            {
                throw new ArgumentOutOfRangeException("La quantité à remplir ne peut pas être négative.",nameof(quantiteAremplir));
            }
            if (!ouverte)
            {
                return false;
            }
            else
            {
                if ( quantiteAremplir <= (contenance - contenu))
                {
                    contenu = quantiteAremplir + contenu;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Vider(decimal quantiteAVider)
        {
            if (quantiteAVider < 0)
            {
                throw new ArgumentOutOfRangeException("La quantité à vider ne peut pas être négative.", nameof(quantiteAVider));
            }
            if (!ouverte)
            {
                return false;
            }
            else if (quantiteAVider >= 0 && quantiteAVider <= contenu)
            {
                contenu = contenu - quantiteAVider;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}