using System;
using Bouteilles;
using System.Collections.Generic;


namespace la_bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille cristalline = new Bouteille(false, "cristalline", 100, 50);
            List<Bouteille> bouteilles = new List<Bouteille> { cristalline };

            //remplir quand la bouteille est fermée
            Console.WriteLine("---------------------------\nRemplir quand la bouteille est fermée");
            cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());
            cristalline.Remplir(10);
            Console.WriteLine(cristalline.ToString());

            //remplir quand la bouteille est ouverte
            Console.WriteLine("---------------------------\nRemplir quand la bouteille est ouverte");
            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());
            cristalline.Remplir(10);
            Console.WriteLine(cristalline.ToString());

            //vider quand la bouteille est fermée
            Console.WriteLine("---------------------------\nVider quand la bouteille est fermée");
            bool result= cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());
            cristalline.Vider(10);
            Console.WriteLine(cristalline.ToString());

            //vider quand la bouteille est ouverte
            Console.WriteLine("---------------------------\nVider quand la bouteille est ouverte");
            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());
            cristalline.Vider(10);
            Console.WriteLine(cristalline.ToString());

            //ouvrir quand la bouteille est fermée
            Console.WriteLine("---------------------------\nOuvrir quand la bouteille est fermée");
            cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());
            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());

            //ouvrir quand la bouteille est ouverte
            Console.WriteLine("---------------------------\nOuvrir quand la bouteille est ouverte");
            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());
            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());

            //Fermer quand la bouteille est fermée
            Console.WriteLine("---------------------------\nFermer quand la bouteille est fermée");
            cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());
            cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());

            //Fermer quand la bouteille est ouverte
            Console.WriteLine("---------------------------\nFermer quand la bouteille est ouverte");
            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());
            cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());

            //fermer quand la bouteille est vide
            Console.WriteLine("---------------------------\nFermer quand la bouteille est vide");
            cristalline.Ouvrir();
            cristalline.Vider(50);
            Console.WriteLine(cristalline.ToString());
            cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());

            //fermer quand la bouteille est pleine
            Console.WriteLine("---------------------------\nFermer quand la bouteille est pleine");
            cristalline.Ouvrir();
            cristalline.Remplir(100);
            Console.WriteLine(cristalline.ToString());
            cristalline.Fermer();
            Console.WriteLine(cristalline.ToString());

            //Ouvrir quand la bouteille est pleine
            Console.WriteLine("---------------------------\nOuvrir quand la bouteille est pleine");
            cristalline.Remplir(100);
            Console.WriteLine(cristalline.ToString());
            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());

            //Ouvrir quand la bouteille est vide
            Console.WriteLine("---------------------------\nOuvrir quand la bouteille est vide");
            cristalline.Vider(100);
            Console.WriteLine(cristalline.ToString());
            cristalline.Ouvrir();
            Console.WriteLine(cristalline.ToString());
        }
    }
}