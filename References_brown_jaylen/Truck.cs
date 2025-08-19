using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_brown_jaylen
{       //implements IAotombile
    internal class Truck : IAotomobile
    {   //sets property for speed
        public double Speed {get; private set; }
        //sets property for Wheels
        public double Wheels {get; private set; }
        //sets property for LicensePlate
        public string LicensePlate {get; private set; }
        //sets property for Weight
        public double Weight { get; }
        //a constructer with a double parameter called speedparam and another one called weightparam and a string parameter call licensenum
        public Truck(double speedparam, double weightparam, string licensenum)
        {
            Speed = speedparam;
            Weight = weightparam;
            LicensePlate = licensenum;
            //sets the wheels base on the weight
            if (Weight < 400)
            { 
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
           
        }
        //sets what stringify does for Truck
        public void Stringify()
        {
            Console.WriteLine($"The trucks speed is {Speed} on {Wheels} wheels, with a licensen plate number of {LicensePlate}");
        }
        //makes a methed called increaseSpeed and sets what it does(it chages speed by 5)
        public void IncreaseSpeed()
        {
            Speed += 5;
        }
        //makes a methed called increaseSpeed and sets what it does(it chages speed by 5)7
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }

    }
}
