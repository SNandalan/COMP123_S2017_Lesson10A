using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: Sushmita Nandalan
 * Date: July 13th 2017
 * Description: This Interface lists the signature for any Super Hero subclass
 * Version: 0.1 - Declared the Karma property 
 */
namespace COMP123_S2017_Lesson10A
{
    public interface IHasKarma 
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES
        int Karma { get; set; }
    }

}
