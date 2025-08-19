using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_brown_jaylen
{   //implements IAotombile
    internal class Sedan : IAotomobile
    {   
        //sets property for speed
        public double Speed { get; private set; }
        //sets property for Wheels
        public double Wheels { get; private set; }
        //sets property for LicensePlate
        public string LicensePlate { get; private set; }
        //a constructer with a double parameter called speed
        public Sedan(double speed) 
        { 
            //sets wheels
            Wheels = 4;
            //sets Speed to speed
            Speed = speed;
            //sets LicensePlate
            LicensePlate = "GCTC - 07";


        }

        //sets what stringify does for sadan
        public void Stringify()
        {
            Console.WriteLine($"The Sedan's speed is {Speed} on {Wheels} wheels with a license plate num of {LicensePlate}");
        }
       //makes a methed called increaseSpeed and sets what it does(it chages speed by 5)
        public void IncreaseSpeed() 
        {
            Speed += 5;
        }
        //makes a methed called DecreaseSpeed and sets what it does(it chages speed by 5)
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
