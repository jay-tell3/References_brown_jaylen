namespace References_brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {   //make a new Sedan obj with 0 speed
            Sedan myFristSedan = new Sedan(0);
            //assigns IAotomobile to the Sedan obj
            IAotomobile myAotombile = myFristSedan;
            //make a new Sedan obj with 0 speed
            Sedan myOtherSedan = new Sedan(0);
            //increases speed of myFristSedan
            myFristSedan.IncreaseSpeed();
            //prints the speed of myFristSedan
            Console.WriteLine(myFristSedan.Speed);
            //prints the speed of myAotombile
            Console.WriteLine(myAotombile.Speed);
            //Checks if they are the same and then prints the answer.
            Console.WriteLine(myFristSedan.Equals(myAotombile));
            //increases speed of myOtherSedan
            myOtherSedan.IncreaseSpeed();
            //prints the speed of myFristSedan
            Console.WriteLine(myFristSedan.Speed);
            //prints the speed of myOtherSedan
            Console.WriteLine(myOtherSedan.Speed);
            //Checks if they are the same and then prints the answer.
            Console.WriteLine(myFristSedan.Equals(myOtherSedan));
            // Makes a new Truck obj and sets spped and wight and the license plate
            Truck myTruck = new Truck(50, 500, "MyTruck");
           // Calls stringify method and describes autombils
            myFristSedan.Stringify();
            myAotombile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();
        }
    }
}