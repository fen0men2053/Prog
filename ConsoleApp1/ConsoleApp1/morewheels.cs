//////5


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class MoreWheels : Transport
//    {
//        public MoreWheels(int speed) : base(speed)
//        {

//        }

//        public override void DisplayInfo()
//        {
//            base.DisplayInfo();
//            Console.WriteLine($"Doors {(doorsOpen ? "open" : "closed")}");
//        }

//        public override int NumberOfWheels()
//        {
//            return numberOfWheels;
//        }
//    }
//    public class Car : MoreWheels
//    {

//        public Car(int speed, int numberOfWheels) : base(speed)
//        {
//            this.numberOfWheels = numberOfWheels;
//        }

//        public override void DisplayInfo()
//        {
//            base.DisplayInfo();
//        }

//    }


//    public class Train : MoreWheels
//    {
//        public Train(int speed, int numberOfWheels) : base(speed)
//        {
//            this.numberOfWheels = numberOfWheels;
//        }

//        public override void DisplayInfo()
//        {
//            base.DisplayInfo();
//        }

//    }
//}
