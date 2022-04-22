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
                return this.GetHashCode();
            }
        }
        private string name;
        internal string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private Position _pos = new(); // STORES POSITION VALUE

        internal Position Pos
        {
            get
            {
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
