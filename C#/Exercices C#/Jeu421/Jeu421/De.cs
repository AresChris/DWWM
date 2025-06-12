using Aleatoire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manche421;

namespace Jeu421Dices
{
    public class De : IComparable<De>
    {
        //attributs
        private int numeroFace;
        private const int NbFacesMax = 6;

        public int NumeroFace { get => numeroFace; private set => numeroFace = value; }

        //constructeurs
        public De()
        {
            Jeter();
        }

        public void Jeter()
        {
            numeroFace = Alea.Instance().Nouveau(1, 6);
        }

        public override string ToString()
        {
            return base.ToString() + nameof(numeroFace) + "=" + numeroFace + " " + nameof(NbFacesMax) + "=" + NbFacesMax;
        }

        public int CompareTo(De? other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.numeroFace.CompareTo(other.numeroFace);
        }
    }
}
