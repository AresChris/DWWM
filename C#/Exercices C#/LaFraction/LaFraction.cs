using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LaFraction
{
    internal class Fraction
    {
        public int numerateur;
        public int denominateur;


        public Fraction(Fraction fractionAcopier): this(fractionAcopier.numerateur, fractionAcopier.denominateur)//
        {
        }

        public Fraction(int _numerateur, int _denominateur)
        {
            if(_denominateur == 0)
            {
                throw new ArgumentException("Le dénominateur ne peut pas être nul");
            }
            numerateur = _numerateur;
            denominateur = _denominateur;

        }
        public Fraction():this(1,1)
        {
        }
        public Fraction(int numerateur)
        {
        }
        public override string ToString()
        {
            if (numerateur == 0)
            {
                return $"{0}";
            }
            if(denominateur == 1)
            {
                return $"{numerateur}";
            }
            return $"{numerateur}/{denominateur}";
        }
        public void Oppose()
        {
            numerateur = -numerateur;
        }
        public void Inverser()
        {
            if (numerateur == 0)
            {
                throw new ArgumentException("Le dénominateur ne peut pas être égal à zéro.");
            }
            int temp = 0;
            temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }
        public bool EstSuperieurA(Fraction autreFraction)
        {
            return (this.Evalue() > autreFraction.Evalue());
        }
        private double Evalue()
        {
            return ((double)this.numerateur) / this.denominateur;
        }
        private int Pgcd()
        {
            int a=this.numerateur;  
            int b=this.denominateur;
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }
        public Fraction Plus(Fraction autreFraction)
        {
            Fraction resultat;
            int newNumerateur = (this.numerateur * autreFraction.denominateur) + (this.denominateur * autreFraction.numerateur);
            int newDenominateur= this.denominateur * autreFraction.denominateur;
            resultat = new Fraction(newNumerateur, newDenominateur);
            resultat.Reduire();
            return resultat;
        }
       public Fraction Moins(Fraction autreFraction)
       {
            Fraction resultat;
            int newNumerateur = this.numerateur - autreFraction.numerateur;
            resultat = new Fraction(newNumerateur, denominateur);
            resultat.Reduire();
            return resultat;
       }
        public Fraction Multiplie(Fraction autreFraction)
        {
            int multNumerateur = this.numerateur * autreFraction.numerateur;
            int multDenominateur = this.denominateur * autreFraction.denominateur;
            Fraction resultat = new Fraction(multNumerateur, multDenominateur);
            resultat.Reduire();
            return new Fraction(multNumerateur, multDenominateur);
        }
        public Fraction Divise(Fraction autreFraction)
        {
            int multNumerateur = this.numerateur * autreFraction.denominateur;
            int multDenominateur = this.denominateur * autreFraction.numerateur;
            Fraction resultat = new Fraction(multNumerateur, multDenominateur);
            resultat.Reduire();
            return new Fraction(multNumerateur, multDenominateur); 
        }
        public bool EgalA(Fraction autreFraction)
        {
            return this.Evalue() == autreFraction.Evalue();
        } 
        private void Reduire()
        {
            int pgcd = Pgcd();
            numerateur /= pgcd;
            denominateur /= pgcd;
        } 
    }
}
