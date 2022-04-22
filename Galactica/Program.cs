using System;

namespace Galactica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ WELCOME TO MY GALAXY! ------");
            SimSolarSystem();
            Console.ReadKey();
        }
        internal static void SimSolarSystem()
        {

            Star TheSun = InitSolarSystem();
        

        }
        internal static Star InitSolarSystem()
        {
            Star TheSun = new("Sun", Startype.YellowDwarf, 1.57 * Math.Pow(10, 7));
            Planet
                Mercury = new("Mercury"),
                Venus = new("Venus"),
                Earth = new("Earth"),
                Mars = new("Mars"),
                Jupiter = new("Jupiter"),
                Saturn = new("Saturn"),
                Uranus = new("Uranus"),
                Neptune = new("Neptune");
            // Mecury
            Mercury.Diameter = 4879000;
            Mercury.RotationPeriod = 1407.6;
            Mercury.RevolutionPeriod = 87.9;
            Mercury.SetPos(74047168176, -74047168176);
            TheSun.AddOrbit(Mercury);
            // Venus
            Venus.Diameter = 12104;
            Venus.RotationPeriod = 1407.6;
            Venus.RevolutionPeriod = 87.9;
            Venus.SetPos(-42312667529, 42312667529);
            TheSun.AddOrbit(Venus);
            // Earth
            Earth.Diameter = 12756000;
            Earth.RotationPeriod = 23.9;
            Earth.RevolutionPeriod = 365.2;
            Earth.SetPos(74047168176, -74047168176);
            TheSun.AddOrbit(Earth);
            // Mars
            Mars.Diameter = 6792000;
            Mars.RotationPeriod = 24.6;
            Mars.RevolutionPeriod = 687;
            Mars.SetPos(-1.49598E+11, -1.49598E+11);
            TheSun.AddOrbit(Mars);
            // Jupiter
            Jupiter.Diameter = 142984000;
            Jupiter.RotationPeriod = 9.9;
            Jupiter.RevolutionPeriod = 4332;
            Jupiter.SetPos(5.50065E+11, 5.50065E+11);
            TheSun.AddOrbit(Jupiter);
            // Saturn
            Saturn.Diameter = 120536000;
            Saturn.RotationPeriod = 10.7;
            Saturn.RevolutionPeriod = 10.759;
            Saturn.SetPos(1.00493E+12, -1.00493E+12);
            TheSun.AddOrbit(Saturn);
            // Uranus
            Uranus.Diameter = 51118000;
            Uranus.RotationPeriod = -17.232;
            Uranus.RevolutionPeriod = 30708.15721;
            Uranus.SetPos(2094477042696.16, 2094477042696.16);
            TheSun.AddOrbit(Uranus);
            // Neptune
            Neptune.Diameter = 49528000;
            Neptune.RotationPeriod = 16.1;
            Neptune.RevolutionPeriod = 60.182;
            Neptune.SetPos(3.18403E+12, 3.18403E+12);
            TheSun.AddOrbit(Neptune);

            return TheSun;
        }
    }
}
