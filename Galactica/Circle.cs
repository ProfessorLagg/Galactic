using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    class Circle
    {
        private double radius = 1;
        /// <summary>
        /// Radius in meters
        /// </summary>
        internal double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Negative radius sizes objects dont exist");
                }
            }
        }
        /// <summary>
        /// Diameter in meters
        /// </summary>
        internal double Diameter
        {
            get
            {
                return radius * 2;
            }
            set
            {
                if (value > 0)
                {
                    radius = value / 2;
                }
                else
                {
                    throw new ArgumentException("Negative diameter sizes objects dont exist");
                }
            }
        }
        internal double Circumference
        {
            get
            {
                return 2 * Math.PI * radius;
            }
        }
        
        internal (double x, double y) Travel(double x, double y, double degrees)
        {
            double
                xMod = Math.Cos(degrees),
                yMod = Math.Sin(degrees),
                newX = xMod * x,
                newY = yMod * y;
            (double x, double y) output = (newX, newY);
            return output;
        }

    }
}
