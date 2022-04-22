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
        internal Position RelativePos
        {
            get
            {
                double
                    x = Pos.X - Orbiting.Pos.X,
                    y = Pos.Y - Orbiting.Pos.Y;
                return new Position(x, y);
                    
            }
            set
            {
                double
                    x = value.X + Orbiting.Pos.X,
                    y = value.Y + Orbiting.Pos.Y;
                this.Pos = new(x, y);

            }
        }
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
