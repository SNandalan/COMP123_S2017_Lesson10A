using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name: Sushmita Nandalan
 * Date: July 11th 2017
 * Description: This is the new Power data type
 * Version: 0.2 - Added a custom constructor
 */
namespace COMP123_S2017_Lesson10A
{
    public struct Power
    {
        /// <summary>
        /// The Power class contains the data and structure of the each Super Power. 
        /// </summary>

        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        //CONSTRUCTORS ------------------------------------------------------------------------------------------------
        /// <summary>
        /// This is the constructor for the power class
        /// It takes two parameters- name and rank
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }

    }
}