using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_AbstractPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet myGiantPlanet = new GiantPlanet("Gas", "Uranus", 50.724, 86.81E24);
            Console.WriteLine(myGiantPlanet.ToString());

            TerrestrialPlanet myTerrestrialPlanet = new TerrestrialPlanet(true, "Earth", 12.742, 5.972E24);
            Console.WriteLine(myTerrestrialPlanet.ToString());

            waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.Write("\n");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Please hit any key to exit....");
            Console.ReadKey();
        }
    }
}
