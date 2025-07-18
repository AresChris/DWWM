﻿using System;
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
        public Point(Point pointAcopier):this(pointAcopier.x,pointAcopier.y)
        {
        
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
        public void Permuter()
        {
            (this.x, y) = (y, this.x);
        }
        public Point SymetrieAbscisse(Point autrePoint)
        {
            if(this.y > 0)
            {
                autrePoint.y = -this.y;
                autrePoint.x = this.x;
            }
            else if(this.y < 0)
            {
                autrePoint.y = this.y;
                autrePoint.x = this.x;
            }
            return autrePoint;
        }
        public Point SymetrieOrdonnee(Point autrePoint)
        {
            if (this.y > 0)
            {
                autrePoint.y = this.y;
                autrePoint.x = -this.x;
            }
            else if (this.y < 0)
            {
                autrePoint.y = this.y;
                autrePoint.x = this.x;
            }
            return autrePoint;
        }
        public Point SymetrieOrigine(Point nouveauPoint)
        {
            nouveauPoint.SymetrieAbscisse(nouveauPoint);
            nouveauPoint.SymetrieOrdonnee(nouveauPoint);
            return nouveauPoint;
        }
    }
}
