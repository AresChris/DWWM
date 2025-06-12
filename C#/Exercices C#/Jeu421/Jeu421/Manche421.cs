using Aleatoire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jeu421Dices;

namespace Manche421
{
    public class Manche
    {
        Random random = new Random();
        int[] tableau = [0, 0, 0];
        int nbOfDices = 3;
        int points = 50;
        const int nbMaxLaunch = 3;
        int launches = 1;
        private int nbDesDejaLance;
        private Jeu421Dices.De[] mes3Des;

        public Manche()
        {
            nbDesDejaLance = 0;
            mes3Des = [ new De(), new De(), new De() ];
        }
        public string ToString()
        {
            string r = $"Jeté de dé n° {nbDesDejaLance}" +
                $"\nLancé #{launches}" +
                $"\nDé °1 : {mes3Des[0]}" +
                $"\nDé °2 : {mes3Des[1]}" +
                $"\nDé °3 : {mes3Des[2]}" +
                $"\nPoints : {points}" +
                $"\nGagné ? {Won()}";
            return r;
        }
        
        public void Lance()
        {
            foreach (De d in mes3Des)
            {
                d.Jeter();
            }
            nbDesDejaLance++;
            Trier();
        }
        public void Lance(int numeroUn, int numeroDeux)
        {
            mes3Des[numeroUn - 1].Jeter();
            mes3Des[numeroDeux - 1].Jeter();
            nbDesDejaLance++;
            Trier();
        }

        public void Lance(int numeroUn)
        {
            mes3Des[numeroUn - 1].Jeter();
            nbDesDejaLance++;
            Trier();
        }
        public bool Won()
        {
            //int[] valeurs = mes3Des.Select(de => de.Valeur).ToArray();
            bool isWon = tableau.Contains(4) && tableau.Contains(2) && tableau.Contains(1);
                if (isWon)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
        public bool AEncoreUnLance()
        {
            return nbDesDejaLance < nbMaxLaunch;
        }
        public void Trier()
        {
            Array.Sort(tableau);
            Array.Reverse(tableau);
        }
    }
}