using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_brown_jaylen
{
    internal class Truck : IAotomobile
    {
        public double Speed {get; private set; }

        public double Wheels {get; private set; }

        public string LicensePlate {get; private set; }

        public double Weight { get; }
        public Truck(double speedparam, double weightparam, string licensenum)
        {
            Speed = speedparam;
            Weight = weightparam;
            LicensePlate = licensenum;

            if (Weight < 400)
            { 
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
           
        }

        public void Stringify()
        {
            Console.WriteLine($"The trucks speed is {Speed} on {Wheels} wheels, with a licensen plate number of {LicensePlate}");
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
