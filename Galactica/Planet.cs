using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal enum PlanetType
    {
        Terrestial, 
        Giant, 
        Dwarf, 
        Gas_Giant
    }
    internal class Planet : SpaceObject
    {
        /// <summary>
        /// A dictionary of the Moons orbiting this planet using the moons ID as Key
        /// </summary>
        internal Dictionary<int, Moon> Orbits { get; private set; }
        internal PlanetType Type;
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

        internal TimeSpan RotationTime;
        internal double RotationPeriod
        {
            get
            {
                return RotationTime.TotalHours;
            }
            set
            {
                RotationTime = TimeSpan.FromHours(value);
            }
        }
        internal TimeSpan RevolutionTime;
        internal double RevolutionPeriod
        {
            get
            {
                return RevolutionTime.TotalDays;
            }
            set
            {
                RevolutionTime = TimeSpan.FromDays(value);
            }
        }
        internal void AddOrbit(Moon moon)
        {
            this.Orbits.Add(moon.ID, moon);
        }
        internal virtual double DistanceToOrbiting()
        {
            return this.Pos.DistanceTo(0,0);
        }



    }
}
