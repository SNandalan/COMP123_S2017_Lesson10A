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
    /// <summary>
    /// This is the Power class which will be used as a Data type
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        // CONSTRUCTORS -----------------------------------

        /// <summary>
        /// This is the main constructor for the Power class.
        /// It takes two arguments - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }


        // PUBLIC OVERLOADED OPERATORS 

        /// <summary>
        /// This method overloads the > for use with the Power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Returns true if lhs.Rank is > rhs.Rank </returns>
        public static bool operator >(Power lhs, Power rhs)
        {
            return (lhs.Rank > rhs.Rank);
        }

        /// <summary>
        /// This method overloads the < for use with the Power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Returns true if lhs.Rank is < rhs.Rank </returns>
        public static bool operator <(Power lhs, Power rhs)
        {
            return (lhs.Rank < rhs.Rank);
        }
    }
}