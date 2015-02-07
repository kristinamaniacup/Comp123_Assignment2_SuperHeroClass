using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_Assignment2_superHero
{
    class SuperHero : Hero
    {
        //PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string[] superPowers = {"Invisibility", "Super Strength", "Flight", "Super Speed", "Telekinesis", "Telepathy" };
        private string[] finalSuperPowers = new string[3];

        Random rnd = new Random();

        private int randomPower;

        //CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public SuperHero(string name) : base(name)
        {
            generateRandomPowers(); //displays random powers
        }


        //This method generates 3 different powers for the superHero
        //PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void generateRandomPowers()
        {
            int power = 0;
            while (power < finalSuperPowers.Length)
            {
                randomPower = generateRandomNum(rnd); 
                if (superPowers[randomPower] != "Opps! Unavailable. Re-roll.") //if the power generated is available then..
                {
                    finalSuperPowers[power] = superPowers[randomPower]; //apply that power to the finalSuperPower

                    superPowers[randomPower] = "Opps! Unavailable. Re-roll."; //but if the power generated IS unavailable then exit loop and "re-roll"

                    power++;
                }
            }
        }

        //Method that generates a random number in relation to the string array items and is used in the generateRandomPowers
        private static int generateRandomNum(Random rnd)
        {
            int randomPower;
            randomPower = rnd.Next(6);
            //Console.WriteLine("Random super power is: {0}", randomPower);
            return randomPower;
        }

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void showPowers()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("                Super Powers                ");
            Console.WriteLine("********************************************");
            Console.WriteLine("First Super Power is: {0}", finalSuperPowers[0]);
            Console.WriteLine();
            Console.WriteLine("Second Super Power is: {0}", finalSuperPowers[1]);
            Console.WriteLine();
            Console.WriteLine("Third Super Power is: {0}", finalSuperPowers[2]);
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
        }
    }
}
