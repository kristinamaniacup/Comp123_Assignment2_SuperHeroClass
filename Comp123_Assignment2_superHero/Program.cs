/*Author Name: Kristina Maniacup
 * Date Last Modified: Friday, February 6, 2015
 * Program Description: 
 * 
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
            Console.WriteLine("~~~~~~~~~~~~~ SuperHero Class ~~~~~~~~~~~~~~");
            Console.WriteLine();
            SuperHero mySuperHero = new SuperHero("Mom");
            mySuperHero.showPowers();
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~ Hero Class ~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            Hero myHero = new Hero("Dad");
            myHero.fight();
            Console.WriteLine("********* Press any key to exit. ***********");
            Console.ReadKey();
        }
    }
}
