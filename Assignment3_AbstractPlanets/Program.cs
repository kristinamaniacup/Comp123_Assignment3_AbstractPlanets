/*Author's Name: Kristina Maniacup
 *Date Last Modified: February 26, 2015
 *Program Description: This program contains an abstract class named Planet, two classes named GiantPlanet and TerrestrialPlanet that are subclasses
 *                     of the Planet abstract class, and three interfaces named IHabitable, IHasMoons and IHasRings that the classes implement. 
 *
 * Revision History: 
 * 
 * Feb 13, 2015: Created Planet abstract class, GiantPlanet class, TerrestrialPlanet class and made the shells for interfaces IHasMoons and IHasRings
 * Feb 17, 2015: Created shell for IHabitable interface
 * Feb 24, 2015: Filled in interfaces and implemented them. Implemented classes in main program and edited bools.
 * Feb 26, 2015: Fixed up main program, made program header and added comments 
 * 
 */

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
            Console.Write("\n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("******************************* Giant Planet ******************************");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            GiantPlanet myGiantPlanet = new GiantPlanet("Gas", "Uranus", 50.724, 86.81E24);
            Console.WriteLine(myGiantPlanet.ToString());
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("*************************** Terrestrial Planet ****************************");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            TerrestrialPlanet myTerrestrialPlanet = new TerrestrialPlanet(true, "Earth", 12.742, 5.972E24);
            Console.WriteLine(myTerrestrialPlanet.ToString());

            waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.Write("\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Please hit any key to exit....");
            Console.ReadKey();
        }
    }
}
