﻿using System;
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
        /// </summary>
        
        //set number of sides for die

        /// <summary>
        /// Face up value(the number that the player rolled)
        /// </summary>
        public byte FaceValue { get; set; }

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

            //set to face value

            //return new number
            throw new NotImplementedException();
        }
        
    }
}
