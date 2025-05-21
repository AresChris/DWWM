using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voitures
{
        public class Voiture
        {
            private string marque;
            private string modele;
            private bool estDemarree;
            private int kilometrage;
            public Voiture() : this("Inconnu", "Inconnu", false, 0)
            {
            }

            public Voiture(string _marque, string _modele, bool _estDemarree, int _kilometrage)
            {
                marque = _marque;
                modele = _modele;
                estDemarree = _estDemarree;
                kilometrage = _kilometrage;
            }

            public Voiture(Voiture voitureAcopier)
            {
                marque = voitureAcopier.marque;
                modele = voitureAcopier.modele;
                estDemarree = voitureAcopier.estDemarree;
                kilometrage = voitureAcopier.kilometrage;
            }
            public override string ToString()
            {
                return $"Marque : {marque}, Modèle : {modele}, Démarrée : {estDemarree}, Kilométrage : {kilometrage} km";
            }


            public bool Demarrer()
            {
                if (!estDemarree)
                {
                    estDemarree = true;
                    return true;
                }
                return false;
            }

            public bool Arreter()
            {
                if (estDemarree)
                {
                    estDemarree = false;
                    return true;
                }
                return false;
            }
            public bool Avancer()
            {
                return Avancer(1);
            }
            public bool Avancer(int distanceAvancer)
            {
                if (distanceAvancer < 0)
                {
                    throw new ArgumentOutOfRangeException("La distance à avancer ne peut pas être négative.");
                }

                if (estDemarree)
                {
                    kilometrage += distanceAvancer;
                    return true;
                }
                return false;
            }
            public bool Reculer()
            {
                return Reculer(1);
            }
            public bool Reculer(int distanceReculer)
            {
                if (distanceReculer < 0)
                {
                    throw new ArgumentOutOfRangeException("La distance à reculer ne peut pas être négative.");
                }

                if (estDemarree)
                {
                    kilometrage -= distanceReculer;
                    return true;
                }
                return false;
            }
        }
    }
