using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_brown_jaylen
{
    internal class Sedan : IAotomobile
    {
        public double Speed { get; private set; }

        public double Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public Sedan(double speed) 
        { 
        
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC - 07";


        }


        public void Stringify()
        {
            Console.WriteLine($"The Sedan's speed is {Speed} on {Wheels} wheels with a license plate num of {LicensePlate}");
        }
        public void IncreaseSpeed() 
        {
            Speed += 5;
        }
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
