namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        private bool ouverte;
        private string nom { get; set; }
        private decimal contenance { get; set; }
        private decimal contenu { get; set; }

        public Bouteille(string nom, int contenance, int contenu)
        {
            this.nom = nom;
            this.contenance = contenance;
            this.contenu = contenu;
            this.ouverte = false;
        }
        public override string ToString()
        {
        //    string description = $" est ouverte : {this.estOuvert} /Sa contenance en litre : {this.contenanceEnLitre} /Son contenu en litre : {this.contenuEnLitre}";

            return base.ToString() + " : " + nameof(ouverte) + " = " + ouverte + " : " + nameof(contenance) + " = " + contenance + " : " + nameof(contenu) + " = " + contenu;
        }
        public bool ouvrir()
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

        public bool fermer()
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

        public bool remplir()
        {
            if (!ouverte)
            {
                return false;
            }
            else
            {
                contenu = contenance;
                return true;
            }
        }
        public bool remplir(decimal quantiteAremplir)
        {
            if (!ouverte)
            {
                return false;
            }
            else
            {
                if (quantiteAremplir >= 0 && quantiteAremplir <= (contenance - contenu))
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
        public bool vider()
        {
           if (!ouverte)
           {
               return false;
           }
           else if (contenu == 0)
           {
               return false;
           }
           else
           {
               contenu = 0;
               return true;
           }     
        }
        public bool vider(decimal quantiteAVider)
        {
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
