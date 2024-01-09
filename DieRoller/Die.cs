using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    public class Die
    {
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
        /// </summary>
        /// <returns> the new rolled number
        public byte Roll()
        {
            //Generate random number
            Random random = new Random();
            byte newValue = (byte)random.Next(1, 7);

            //set to face value
            FaceValue = newValue;

            //return new number
            return newValue;
        }
        
    }
}
