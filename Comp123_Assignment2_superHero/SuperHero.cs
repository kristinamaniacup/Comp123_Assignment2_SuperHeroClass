using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_Assignment2_superHero
{
    class SuperHero : Hero
    {
        //PRIVATE PROPERTIES +++++++
        private string[] superPowers = {"Invisibility", "Super Strength", "Flight", "Super Speed", "Telekinesis", "Telepathy" };
        private string[] finalSuperPowers = new string[3];

        Random rnd = new Random();

        private int randomPower;

        //CONSTRUCTOR +++++++++++++
        public SuperHero(string name) : base(name)
        {
            generateRandomPowers(); //displays random powers
        }

        //PRIVATE METHODS +++++++++++
        private void generateRandomPowers()
        {
 
        }

        private static int generateRandomNum(Random rnd)
        {
            int randomPower;
            randomPower = rnd.Next(6);
            //Console.WriteLine("Random super power is: {0}", randomPower);
            return randomPower;
        }

        //PUBLIC METHODS ++++++++++++
        public void showPowers()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
