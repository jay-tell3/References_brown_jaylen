using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_brown_jaylen
{
    internal interface IAotomobile
    {
        // makes a double property called speed
        public double Speed { get; }
        // makes a double property called wheels
        public double Wheels { get; }
        // makes a string property called LicensePlate
        public string LicensePlate { get; }
       // defines a methed called stringify that print a message to the console
        public void Stringify();
    
    }

}
