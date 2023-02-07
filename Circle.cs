/*
Assignment-2 SQAT
PROG-8170 SEC-1

Done by: Group-6
Syed Sirajul Hasan - 8836760
Piyush Mansukhbhai Monpara - 8784742

File: Circle.cs
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PROG8170_Section1_Assignment2_Group6
{
        public class Circle
        {
            private int radius;

            public Circle()
            {
                radius = 1;
            }

            public Circle(int radius)
            {
                this.radius = radius;
            }

            public int GetRadius()
            {
               return radius;

            }

            public int SetRadius(int radius)
            {
                if (radius >= 1)
                {
                   return this.radius = radius;
                }
            return 1;
            }

            public double GetCircumference()
            {
                double circumference = 2 * Math.PI * this.radius;
                return Math.Round(circumference, 2);
            }

            public double GetArea()
            {
                double area = Math.PI * this.radius * this.radius;
                return Math.Round(area, 2);
            }
        }

}
