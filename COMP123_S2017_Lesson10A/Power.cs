using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Name: Sushmita Nandalan
 * Date: July 11th 2017
 * Description: This is the new Power data type
 * Version: 0.3 - Overloaded the > and < operators
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

        // OVERLOADED METHODS
 
         /// <summary>
         /// This method overloads the > operator for the Power class.
         /// </summary>
         /// <param name="lhs"></param>
         /// <param name="rhs"></param>
         /// <returns>Returns true lhs > rhs</returns>
         public static bool operator >(Power lhs, Power rhs)
         {
             return (lhs.Rank > rhs.Rank);
         }
 
         /// <summary>
         /// This method overloads the < operator for the Power class.
         /// </summary>
         /// <param name="lhs"></param>
         /// <param name="rhs"></param>
         /// <returns>Returns true if lhs < rhsk</returns>
         public static bool operator <(Power lhs, Power rhs)
         {
             return (lhs.Rank<rhs.Rank);
         }

    }
}