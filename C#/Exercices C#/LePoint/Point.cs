using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LePoint
{
    internal class Point
    {
        public float x;
        public float y;

        public Point(): this(0, 0) 
        { 
        }
        public Point(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
        public Point(Point pointAcopier)
        {
            x = pointAcopier.x;
            y = pointAcopier.y;
        }
        public string ToString()
        {
            return $"({x}, {y})";
        }
        public void Deplacer(float _nouveauX, float _nouveauY)
        {
            x = _nouveauX;
            y = _nouveauY;
        }
        public void Permuter(Point autrePoint)
        {
            float thirdPartyX = 0;
            float thirdPartyY = 0;

            thirdPartyX = this.x;
            thirdPartyY = this.y;

            this.x = autrePoint.x;
            this.y = autrePoint.y;

            autrePoint.x = thirdPartyX;
            autrePoint.y = thirdPartyY;
        }
        public void SymetrieAbscisse()
        {
            x = -x;
        }
        public void SymetrieOrdonnee()
        {
            y = -y;
        }
        public void SymetrieOrigine()
        {
            x = -x;
            y = -y;
        }
    }

}
