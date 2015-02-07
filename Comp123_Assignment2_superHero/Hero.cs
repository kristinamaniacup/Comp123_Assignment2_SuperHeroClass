using System;

namespace Comp123_Assignment2_superHero
{
    class Hero
    {
        //PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int strength;
        private int speed;
        private int health;

        Random rnd = new Random(); //instance that can be used in multiple methods
        //PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string name;

        //CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(string name)
        {
            //take one parameter, name (string), and pass its value to the name property
            //call the generateAbilities method

            this.name = name;
            this.generateAbilities(); //Displays Hero's abilities

        }

        //PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //randomly generates ability numbers for the Heros properties (each ability an integer between 1-100)
        private void generateAbilities()
        {
            this.strength = this.rnd.Next(1, 101);
            this.speed = this.rnd.Next(1, 101);
            this.health = this.rnd.Next(1, 101);
        }

        //determines if the Hero hits (should be 20% of the time) other it will return false
        private bool hitAttempt()
        {
            bool hit = false;
            int attempt = this.rnd.Next(1, 101);

            if (attempt <= 20)
            {
                hit = true;
            }

            return hit;
        }

        //calculates the hitDamage the Hero causes to the target by multiply Hero's strength ability with a number between 1 and 6
        //method will return value
        private int hitDamage()
        {
            int damage;
            damage = this.strength * this.rnd.Next(1, 7);

            return damage;
        }

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //calls the hitAttempt method
        //if hitAttempt returns true, then it will call the hitDamage method
        //the damage will then be displayed in a message on the Console
        public void fight()
        {


            bool hit = hitAttempt();
            int damage = 0;
            if (hit == true)
            {
                damage = hitDamage();
                Console.WriteLine("Great hit! Damage {0}", damage);
                damage = 0;
            }
            else
            {
                Console.WriteLine("You missed. Hit was unsuccessful.");
            }
        }

        //Utility method to display hero properties
        public void show()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Strength: {0}", this.strength);
            Console.WriteLine("Speed: {0}", this.speed);
            Console.WriteLine("Health: {0}", this.health);
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
        }

    }
}
