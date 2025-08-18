using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_brown_jaylen
{
    internal interface IAotomobile
    {
    
        public double Speed { get; }
        public double Wheels { get; }
        public string LicensePlate { get; }
        public void Stringify();
    
    }

}
