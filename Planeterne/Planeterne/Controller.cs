using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    public class Controller
    {
        List<Planets> allPlanets = new List<Planets>();
        List<Planets> planetsSpecificMT = new List<Planets>();
        List<Planets> planetsSpecificDiameter = new List<Planets>();

        public void CreateAllPlanets()
        {
            allPlanets.Add(new Planets("Mercury", (float)0.330, 4879, 5427, (float)3.7, (float)1407.6, (float)4222.6, (float)57.9, (float)88.0, (float)47.4, 167, 0, false));
            allPlanets.Add(new Planets("Earth", (float)5.97, (float)12.756, 5514, (float)9.8, (float)23.9, (float)24.0, (float)149.6, (float)365.2, (float)29.8, 15, 1, false));
            allPlanets.Add(new Planets("Mars", (float)0.642, 6792, 3933, (float)3.7, (float)24.6, (float)24.7, (float)227.9, (float)687.0, (float)24.1, -65, 2, false));
            allPlanets.Add(new Planets("Jupiter", 1898, (float)142.984, 1326, (float)23.1, (float)9.9, (float)9.9, (float)778.6, 4331, (float)13.1, -110, 67, true));
            allPlanets.Add(new Planets("Saturn", 568, (float)120.536, 687, (float)9.0, (float)10.7, (float)10.7, (float)1433.5, (float)10.747, (float)9.7, -140, 62, true));
            allPlanets.Add(new Planets("Uranus", (float)86.8, (float)51.118, 1271, (float)8.7, (float)-17.2, (float)17.2, (float)2872.5, (float)30.589, (float)6.8, -195, 27, true));
            allPlanets.Add(new Planets("Neptune", 102, (float)49.528, 1638, (float)11.0, (float)16.1, (float)16.1, (float)4495.1, (float)59.8, (float)5.4, -200, 14, true));
            allPlanets.Add(new Planets("Pluto", (float)0.0146, 2370, 2095, (float)0.7, (float)-153.3, (float)153.3, (float)5906.4, (float)90.56, (float)4.7, -225, 5, false));

            allPlanets.Insert(1, new Planets("Venus", (float)4.87, (float)12.104, 5243, (float)8.9, (float)-5832.5, (float)2802.0, (float)108.2, (float)224.7, (float)35.0, 464, 0, false));
            allPlanets.RemoveAt(8);
            allPlanets.Insert(8, new Planets("Pluto", (float)0.0146, 2370, 2095, (float)0.7, (float)-153.3, (float)153.3, (float)5906.4, (float)90.56, (float)4.7, -225, 5, false));

        }
        public void CreatePlanetsSpecificMT()
        {
            planetsSpecificMT.Add(new Planets("Mars", (float)0.642, 6792, 3933, (float)3.7, (float)24.6, (float)24.7, (float)227.9, (float)687.0, (float)24.1, -65, 2, false));
            planetsSpecificMT.Add(new Planets("Jupiter", 1898, (float)142.984, 1326, (float)23.1, (float)9.9, (float)9.9, (float)778.6, 4331, (float)13.1, -110, 67, true));
            planetsSpecificMT.Add(new Planets("Saturn", 568, (float)120.536, 687, (float)9.0, (float)10.7, (float)10.7, (float)1433.5, (float)10.747, (float)9.7, -140, 62, true));
            planetsSpecificMT.Add(new Planets("Uranus", (float)86.8, (float)51.118, 1271, (float)8.7, (float)-17.2, (float)17.2, (float)2872.5, (float)30.589, (float)6.8, -195, 27, true));
            planetsSpecificMT.Add(new Planets("Neptune", 102, (float)49.528, 1638, (float)11.0, (float)16.1, (float)16.1, (float)4495.1, (float)59.8, (float)5.4, -200, 14, true));
            planetsSpecificMT.Add(new Planets("Pluto", (float)0.0146, 2370, 2095, (float)0.7, (float)-153.3, (float)153.3, (float)5906.4, (float)90.56, (float)4.7, -225, 5, false));
        }
        public void CreatePlanetsSpecificDiameter()
        {
            planetsSpecificDiameter.Add(new Planets("Earth", (float)5.97, (float)12.756, 5514, (float)9.8, (float)23.9, (float)24.0, (float)149.6, (float)365.2, (float)29.8, 15, 1, false));
            planetsSpecificDiameter.Add(new Planets("Neptune", 102, (float)49.528, 1638, (float)11.0, (float)16.1, (float)16.1, (float)4495.1, (float)59.8, (float)5.4, -200, 14, true));
        }
        public void PrintAllPlanets()
        {
            foreach (Planets planets in allPlanets)
            {
                Console.WriteLine($"Name: {planets.Name}\r\nDiameter: {planets.Diameter}\r\nDensity: {planets.Density}\r\nGravity: {planets.Gravity}\r\nRotation Period: {planets.RotationPeriod}\r\nLength Of Day: {planets.LengthOfDay}\r\nDistance From Sun: {planets.DistanceFromSun}\r\nOrbital Period: {planets.OrbitalPeriod}\r\nOrbital Velocity: {planets.OrbitalVelocity}\r\nMean Temperature: {planets.MeanTemperature}\r\nNumber Of Moons: {planets.NumberOfMoons}\r\nRing System: {planets.RingSystem}\r\n");
            }
        }
        public void PrintPlanetsSpecificMT()
        {
            foreach (Planets planets in allPlanets)
            {
                Console.WriteLine($"Name: {planets.Name}\r\nDiameter: {planets.Diameter}\r\nDensity: {planets.Density}\r\nGravity: {planets.Gravity}\r\nRotation Period: {planets.RotationPeriod}\r\nLength Of Day: {planets.LengthOfDay}\r\nDistance From Sun: {planets.DistanceFromSun}\r\nOrbital Period: {planets.OrbitalPeriod}\r\nOrbital Velocity: {planets.OrbitalVelocity}\r\nMean Temperature: {planets.MeanTemperature}\r\nNumber Of Moons: {planets.NumberOfMoons}\r\nRing System: {planets.RingSystem}\r\n");
            }
        }
        public void PrintPlanetsSpecificDiameter()
        {
            foreach (Planets planets in allPlanets)
            {
                Console.WriteLine($"Name: {planets.Name}\r\nDiameter: {planets.Diameter}\r\nDensity: {planets.Density}\r\nGravity: {planets.Gravity}\r\nRotation Period: {planets.RotationPeriod}\r\nLength Of Day: {planets.LengthOfDay}\r\nDistance From Sun: {planets.DistanceFromSun}\r\nOrbital Period: {planets.OrbitalPeriod}\r\nOrbital Velocity: {planets.OrbitalVelocity}\r\nMean Temperature: {planets.MeanTemperature}\r\nNumber Of Moons: {planets.NumberOfMoons}\r\nRing System: {planets.RingSystem}\r\n");
            }
        }
        public void CountLines()
        {
            Console.WriteLine($"Lines in list: {allPlanets.Count()}");
        }
    }
}

