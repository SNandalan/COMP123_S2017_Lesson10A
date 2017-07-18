using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Sushmita Nandalan
 * Date: July 13, 2017
 * Description: This is the SuperHuman class that extends the Human abstract class
 * Version: 0.7 - Added the DisplaySkills stub method to satisfy the Human super class requirements
 */
namespace COMP123_S2017_Lesson10A
{
    // <summary>
    /// This is the SuperHuman class.
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE INSTANCE VARIABLES
        private List<Power> _powers;

        // PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers; // this returns a reference
            }
        }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperHuman class.
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }

        // PRIVATE METHODS

        /// <summary>
        /// This method initializes, instantiates and assigns values to class properties
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>(); // creates an empty list
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method adds a power to the Power List.
        /// It takes two parameters - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        /// <summary>
        /// This method displays each of the Powers stored in the Powers List
        /// </summary>
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + " Rank: " + power.Rank);
            }
        }

        /// <summary>
        /// The ToString method overrides the built-in Object.ToString method.
        /// It outputs a string that displays the superhuman's name and their power list.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "===========================================================\n";
            outputString += "Super Human Name: " + this.Name + "\n";
            outputString += "===========================================================\n";
            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " Rank: " + power.Rank + "\n";
            }
            outputString += "===========================================================\n";
            return outputString;
        }

        /// <summary>
        /// This method overrides the Human abstract superclass DisplaySkills method.
        /// This method will display a list of Skills to the Console.
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented!");
        }
    }
}
