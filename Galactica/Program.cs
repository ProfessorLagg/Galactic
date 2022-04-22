using System;

namespace Galactica
{
    class Program
    {
        static void Main(string[] args)
        {
            JupiterOrbit();
            Console.WriteLine("\n press enter to continue....");
            Console.ReadKey();
            Console.Clear();
            SimSolarSystem();
            Console.ReadKey();
        }
        internal static void SimSolarSystem()
        {

            Star TheSun = InitSolarSystem();
            // Printing sun Information

            foreach(Planet p in TheSun.Orbits.Values)
            {
                string
                    name = p.Name,
                    type = p.Type.ToString(),
                    dist = p.DistanceToOrbiting().ToString("n") + "m",
                    radi = p.Radius.ToString("n") + "m";
                Console.WriteLine("Planet: " + name);
                Console.WriteLine("  Type: " + type);
                Console.WriteLine("  Dist: " + dist);
                Console.WriteLine("  Radi: " + radi);
                Console.WriteLine("\n");
                foreach(Moon moon in p.Orbits.Values)
                {

                    name = moon.Name;
                    type = "Moon";
                    dist = moon.DistanceToOrbiting().ToString("n") + "m";
                    radi = moon.Radius.ToString("n") + "m";
                    Console.WriteLine("\tMoon: " + name);
                    Console.WriteLine("\t  Dist: " + dist);
                    Console.WriteLine("\t  Radi: " + radi);
                }
                Console.WriteLine("\n");
            }


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
            Mercury.Type = PlanetType.Terrestial;
            Mercury.Diameter = 4879000;
            Mercury.RotationPeriod = 1407.6;
            Mercury.RevolutionPeriod = 87.9;
            Mercury.SetPos(74047168176, -74047168176);
            TheSun.AddOrbit(Mercury);

            // Venus
            Venus.Type = PlanetType.Terrestial;
            Venus.Diameter = 12104;
            Venus.RotationPeriod = 1407.6;
            Venus.RevolutionPeriod = 87.9;
            Venus.SetPos(-42312667529, 42312667529);
            TheSun.AddOrbit(Venus);

            // Earth
            Earth.Type = PlanetType.Terrestial;
            Earth.Diameter = 12756000;
            Earth.RotationPeriod = 23.9;
            Earth.RevolutionPeriod = 365.2;
            Earth.SetPos(74047168176, -74047168176);
            //Luna
            Moon Luna = new("Luna");
            Luna.Orbiting = Earth;
            Luna.RelativePos = new(271811846.7, 271811846.7);
            Luna.Radius = 1737.5 * 1000;
            Luna.RevolutionPeriod = 28;
            Luna.RotationPeriod = Earth.RotationPeriod;
            Earth.AddOrbit(Luna);
            TheSun.AddOrbit(Earth);

            // Mars
            Mars.Type = PlanetType.Terrestial;
            Mars.Diameter = 6792000;
            Mars.RotationPeriod = 24.6;
            Mars.RevolutionPeriod = 687;
            Mars.SetPos(-1.49598E+11, -1.49598E+11);
            // Phobos
            Moon Phobos = new("Phobos");
            Phobos.Orbiting = Mars;
            Phobos.RelativePos = new(6629833.18, 6629833.18);
            Phobos.Radius = 11.1 * 1000;
            Phobos.RevolutionPeriod = 0.31891023;
            Phobos.RotationPeriod = Mars.RotationPeriod;
            Mars.AddOrbit(Phobos);
            // Deimos
            Moon Deimos = new("Deimos");
            Deimos.Orbiting = Mars;
            Deimos.RelativePos = new(16585543, 16585543);
            Deimos.Radius = 6.2 * 1000;
            Deimos.RevolutionPeriod = 1.263;
            Deimos.RotationPeriod = 30.4;
            Mars.AddOrbit(Deimos);
            TheSun.AddOrbit(Mars);

            // Jupiter
            Mercury.Type = PlanetType.Gas_Giant;
            Jupiter.Diameter = 142984000;
            Jupiter.RotationPeriod = 9.9;
            Jupiter.RevolutionPeriod = 4332;
            Jupiter.SetPos(5.50065E+11, 5.50065E+11);
            //Io
            Moon Io = new("Io");
            Io.Orbiting = Jupiter;
            Io.RelativePos = new(298257640.3, 298257640.3);
            Io.Radius = 1821.6 * 1000;
            Io.RevolutionPeriod = 1.769137786;
            Io.RotationPeriod = Jupiter.RotationPeriod;
            Jupiter.AddOrbit(Io);
            //Ganymedes
            Moon Ganymedes = new("Ganymedes");
            Ganymedes.Orbiting = Jupiter;
            Ganymedes.RelativePos = new(756887098, 756887098);
            Ganymedes.Radius = 2631.2 * 1000;            
            Ganymedes.RevolutionPeriod = 7.15455296;
            Ganymedes.RotationPeriod = Jupiter.RotationPeriod;
            Jupiter.AddOrbit(Ganymedes);
            // Europa
            Moon Europa = new("Europa");
            Europa.Orbiting = Jupiter;
            Europa.RelativePos = new(470032262, 470032262);
            Europa.Radius = 1560800;
            Europa.RevolutionPeriod = 3.551181;
            Europa.RotationPeriod = Jupiter.RotationPeriod;
            Jupiter.AddOrbit(Europa);

            TheSun.AddOrbit(Jupiter);

            // Saturn
            Saturn.Type = PlanetType.Gas_Giant;
            Saturn.Diameter = 120536000;
            Saturn.RotationPeriod = 10.7;
            Saturn.RevolutionPeriod = 10.759;
            Saturn.SetPos(1.00493E+12, -1.00493E+12);
            // Titan
            Moon Titan = new("Titan");
            Titan.Orbiting = Saturn;
            Titan.RevolutionPeriod = 15.945;
            Titan.Radius = 2574.7 * 1000;
            Titan.RelativePos = new(863989.0272, 863989.0272);
            Titan.RotationPeriod = Saturn.RotationPeriod;
            Saturn.AddOrbit(Titan);
            //Mimas
            Moon Mimas = new("Mimas");
            Mimas.Orbiting = Saturn;
            Mimas.RelativePos = new(131195885.1, 131195885.1);
            Mimas.Radius = 198.2 * 1000;
            Mimas.RevolutionPeriod = 0.942421959;
            Mimas.RotationPeriod = Saturn.RotationPeriod;
            Saturn.AddOrbit(Mimas);
            
            TheSun.AddOrbit(Saturn);

            // Uranus
            Uranus.Type = PlanetType.Giant;
            Uranus.Diameter = 51118000;
            Uranus.RotationPeriod = -17.232;
            Uranus.RevolutionPeriod = 30708.15721;
            Uranus.SetPos(2094477042696.16, 2094477042696.16);
            TheSun.AddOrbit(Uranus);

            // Neptune
            Neptune.Type = PlanetType.Giant;
            Neptune.Diameter = 49528000;
            Neptune.RotationPeriod = 16.1;
            Neptune.RevolutionPeriod = 60.182;
            Neptune.SetPos(3.18403E+12, 3.18403E+12);
            TheSun.AddOrbit(Neptune);

            return TheSun;
        }
        internal static void JupiterOrbit()
        {
            // Vi starter lige ud med at antage at Jupiters bane er en cirkel.
            // Dette gøres da vi i opgaven IKKE har modtaget nok information til at definere en Elliptisk bane for jupiter (Selv hvis man googler og finder rigtige tal for eccentriciteten)
            Planet Jupiter = new("Jupiter");
            Jupiter.Pos = new(35, 52);
            double degrees = 360 /12 * 2;
            Console.WriteLine("Jupiter initial position: " + Jupiter.Pos.ToString());
            Jupiter.Travel(degrees);
            Console.WriteLine("Jupiter new position: " + Jupiter.Pos.ToString());
            

        }
    }
}
