using System;
using ClassLibraryBouteille;
using System.Collections.Generic;
using ClassLibraryBouteille;

namespace la_bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille cristalline = new Bouteille(false, "cristalline", 100, 50);
            List<Bouteille> bouteilles = new List<Bouteille> { cristalline };

            //--------------------------------------
            cristalline.Ouvrir();
            // Bouteille ouverte
            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());

            cristalline.Vider(10);
            Console.WriteLine(cristalline.ToString());

            cristalline.Remplir(10);
            Console.WriteLine(cristalline.ToString());

            cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());

            //--------------------------------------
            // Bouteille fermée
            cristalline.Vider(10);
            Console.WriteLine(cristalline.ToString());

            cristalline.Remplir(10);
            Console.WriteLine(cristalline.ToString());

            cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());

            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());

            //--------------------------------------
            cristalline.Remplir(50);
            // Bouteille pleine
            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());

            cristalline.Remplir(10);
            Console.WriteLine(cristalline.ToString());

            cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());

            cristalline.Vider(10);
            Console.WriteLine(cristalline.ToString());

            //--------------------------------------
            cristalline.Vider(50);
            //Bouteille vide
            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());

            cristalline.Vider(10);
            Console.WriteLine(cristalline.ToString());

            cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());

            cristalline.Remplir(10);
            Console.WriteLine(cristalline.ToString());
        }
    }
}