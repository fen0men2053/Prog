////5


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public abstract class Transport
//    {
//        public int speed;
//        public int numberOfWheels;
//        public bool doorsOpen;

//        public Transport(int speed)
//        {
//            this.speed = speed;
//            this.doorsOpen = false;
//        }

//        public virtual void OpenDoors()
//        {
//            doorsOpen = true;
//        }

//        public virtual void CloseDoors()
//        {
//            doorsOpen = false;
//        }

//        public virtual void DisplayInfo()
//        {
//            Console.WriteLine($"Type: {this.GetType().Name}");
//            Console.WriteLine($"Speed: {speed} km/h");
//            Console.WriteLine($"Number of wheels: {NumberOfWheels()}");
//        }

//        public virtual int NumberOfWheels()
//        {
//            return 0;
//        }
//    }
//}
