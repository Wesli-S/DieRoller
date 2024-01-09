using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    public class Die
    {
        private static Random _random;

        static Die()
        {
            _random = new Random();
        }

        /// <summary>
        /// represents a single 6 sided die (1 - 6)
        /// represents the created die and rolls it to start with a random number
        /// </summary>
        public Die() 
        {
            Roll();
        }
        //set number of sides for die

        /// <summary>
        /// Current face up value(the number that the player rolled)
        /// </summary>
        public byte FaceValue { get; private set; } //making the set private means it can't be tampered with

        /// <summary>
        /// keeps track of when the die is held
        /// </summary>
        public bool isHeld { get; set; }

        /// <summary>
        /// keep track of when the die is rolled, makes sure the number that comes 
        /// up is random, and sets the number as the new <see cref="FaceValue"/>
        /// assuming the current die roll isn't being held
        /// </summary>
        /// <returns> the new rolled number
        public byte Roll()
        {
            if (!isHeld) //if the hold is not active, random die numbers will continue to generate
            {
                //Generate random number
                byte newValue = (byte)_random.Next(1, 7);

                //set to face value
                FaceValue = newValue;
            }
            
            //return new number
            return FaceValue;
        }
        
    }
}
