using System;
using System.Collections.Generic;
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

        public string ToString()
        {
            return $"{numerateur}/{denominateur}";
        }
        public Fraction(Fraction fractionAcopier)
        {
        }
        public Fraction(int _numerateur, int _denominateur)
        {
            numerateur = _numerateur;
            denominateur = _denominateur;
        }
        public int calculFraction(int numerateur, int denominateur)
        {
            if (denominateur == null || numerateur == null)
            {
                throw new ArgumentNullException("Les fractions ne peuvent pas être nulles.");
            }
            int resultat = numerateur / denominateur;
            return resultat;
        }
        public int Oppose(int numerateur)
        {
            if(numerateur == null)
            {
                throw new ArgumentNullException("Les fractions ne peuvent pas être nulles.");
            }
            numerateur = -numerateur;
            return numerateur;
        }
        public void inverser()
        {
            int temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }
        public bool EstSuperieurA(Fraction autreFraction)
        {
            if(autreFraction == null)
            {
                throw new ArgumentNullException("Les fractions ne peuvent pas être nulles.");
            }
            int resultat1 = this.numerateur * autreFraction.denominateur;
            int resultat2 = autreFraction.numerateur * this.denominateur;

            if (resultat1 > resultat2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int GetPGCD()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }
        public string Plus(Fraction autreFraction)
        {
            if (autreFraction == null)
            {
                throw new ArgumentNullException("Les fractions ne peuvent pas être nulles.");
            }
            int addNumerateur = this.numerateur + autreFraction.numerateur;
            int addDenominateur = this.denominateur + autreFraction.denominateur;
            string resultat = $"{addNumerateur} / {addDenominateur}";
            return resultat;
        }
        public string Moins(Fraction autreFraction)
        {
            if (autreFraction == null)
            {
                throw new ArgumentNullException("Les fractions ne peuvent pas être nulles.");
            }
            int moinsNumerateur = this.numerateur - autreFraction.numerateur;
            int moinsDenominateur = this.denominateur - autreFraction.denominateur;
            string resultat = $"{moinsNumerateur} / {moinsDenominateur}";
            return resultat;
        }
        public string Multiplie(Fraction autreFraction)
        {
            if (autreFraction == null)
            {
                throw new ArgumentNullException("Les fractions ne peuvent pas être nulles.");
            }
            int multNumerateur = this.numerateur * autreFraction.numerateur;
            int multDenominateur = this.denominateur * autreFraction.denominateur;
            string resultat = $"{multNumerateur} / {multDenominateur}";
            return resultat;
        }
        public string Divise(Fraction autreFraction)
        {
            if (autreFraction == null)
            {
                throw new ArgumentNullException("Les fractions ne peuvent pas être nulles.");
            }
            int divNumerateur = this.numerateur / autreFraction.numerateur;
            int divDenominateur = this.denominateur / autreFraction.denominateur;
            string resultat = $"{divNumerateur} / {divDenominateur}";
            return resultat;
        }
    }
}
