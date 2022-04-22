using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal enum Startype
    {
        YellowDwarf,
        White,
        BlueNeutron,
        RedGiant
    }
    internal class Star : SpaceObject
    {
        internal Startype Type;
        internal double Temperature;
        internal Dictionary<int, Planet> Orbits;
        internal Star(string name, Startype type, double temperature)
        {
            this.Name = name;
            this.Type = type;
            this.Temperature = temperature;
            this.Orbits = new();
        }
        internal Star(Startype type, double temperature, IEnumerable<Planet> orbits)
        {
            this.Type = type;
            this.Temperature = temperature;
            this.Orbits = new();
            foreach(Planet P in orbits)
            {
                this.Orbits.Add(P.ID, P);
            }
        }
    }
}
