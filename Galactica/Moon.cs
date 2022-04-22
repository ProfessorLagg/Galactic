using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    sealed internal class Moon : Planet
    {
        internal Planet Orbiting;
        internal override double DistanceToOrbiting()
        {
            return DistanceTo(Orbiting);
        }
        public Moon(string name)
        {
            Name = name;
        }
    }
}
