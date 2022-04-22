using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{

    internal class SpaceObject
    {
        internal int ID
        {
            get
            {
                //return GetID();
                return this.Name.GetHashCode();
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.ToLower();
            }
        }
        private Position _pos = new(); // STORES POSITION VALUE

        internal Position Pos
        {
            // Der står i opgaven at "Sun" altid er 0,0
            // Altså IKKE at Star altid er 0,0
            get
            {
                if ((name.ToLower() == "sun"))
                {
                    _pos.SetPos(0, 0);
                }
                    return _pos;
            }
            set
            {
                if (!(name.ToLower() == "sun"))
                {
                    _pos = value;
                }
                else
                {
                    throw new AccessViolationException("Sun object is always at pos 0,0");
                }
            }
        }
        internal class Position
        {
            public double X;
            public double Y;
            public Position()
            {

            }
            public Position(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }
            public override string ToString()
            {
                return "(" + X.ToString() + ";" + Y.ToString() + ")";
            }
            internal void SetPos(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }

            internal double DistanceTo(Position PosB)
            {
                return Distance(this, PosB);
            }
            internal double DistanceTo(double X2, double Y2)
            {
                return Pythagoras(this.X, X2, this.Y, Y2);
            }
            internal static double Distance(Position PosA, Position PosB)
            {
                return Pythagoras(PosA.X,PosB.X,PosA.Y,PosB.Y);
            }
            private static double Pythagoras(double X1, double X2, double Y1, double Y2)
            {
                return Math.Sqrt(((X1 - X2) * (X1 - X2)) + ((Y1 - Y2) * (Y1 - Y2)));
            }
        }
        internal void SetPos(double x, double y)
        {
            this.Pos.SetPos(x, y);
        }
        internal double DistanceTo(SpaceObject ObjectB)
        {
            return this.Pos.DistanceTo(ObjectB.Pos);
        }
        internal double DistanceTo(double X2, double Y2)
        {
            return this.Pos.DistanceTo(X2, Y2);
        }
    }

}
