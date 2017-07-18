using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson10A
{
    /// <summary>
    /// This is the SuperHero class
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        //  PRIVATE INSTANCE VARIABLES
        private int _karma;

        //PUBLIC PROPERTIES
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }

        //CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the superHuman class
        /// It takes 2 arguments - name(string) and karma
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS
    }
}
