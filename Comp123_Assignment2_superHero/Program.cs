/* Author Name: Kristina Maniacup
 * Date Last Modified: Friday, February 6, 2015
 * Program Description: This program is to demonstrate building and implementing a superHero class.
 *                      The superHero class generates 3 different super powers for the Super Hero "Mom" and makes sure a power isn't repeated.
 *                      The main program will call the showPowers method from the SuperHero class as well as the fight method from the Hero class.
 * 
 * Revision History:
 * 
 * 02/03/15: Created the "skeleton" on the project (outlined methods and constructor)
 * 02/04/15: Created generateRandomNum method
 * 02/05/15: Created generateRandomPowers method and showPowers method
 * 02/06/15: Fixed up showPowers to make it look pretty, add comments and review code
 * 
 * 
 */using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_Assignment2_superHero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~ SUPERHERO CLASS ~~~~~~~~~~~~~");
            SuperHero mySuperHero = new SuperHero("Mom");
            mySuperHero.showPowers();
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~ HERO CLASS ~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            Hero myHero = new Hero("Dad");
            myHero.fight();
            Console.WriteLine();
            Console.WriteLine("********* Press any key to exit. ***********");
            Console.ReadKey();
        }
    }
}
