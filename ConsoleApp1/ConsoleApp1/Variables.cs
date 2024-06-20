
//3333333333333333333.1

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//    internal class Variables
//    {
//        public int Var1 { get; set; }
//        public int Var2 { get; set; }

//        public Variables(int var1, int var2)
//        {
//            Var1 = var1;
//            Var2 = var2;
//        }
//        public Variables()
//        {

//        }
//        public void Display()
//        {
//            Console.WriteLine("Variable1: " + Var1);
//            Console.WriteLine("Variable2: " + Var2);
//        }
//        ~Variables()
//        {

//            Console.WriteLine("Objects have been deleted");

//        }
//    }



// 3.2
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//    public class Variables
//    {
//        public int Var1;
//        public int Var2;
//        public string path { get; set; }
//        public void Deserialize(string path)
//        {
//            var json = File.ReadAllText(path);
//            var data = JsonConvert.DeserializeObject<Variables>(json);
//            Var1 = data.Var1;
//            Var2 = data.Var2;
//        }
//        public Variables(string path)
//        {
//            Deserialize(path);
//        }

//        public Variables()
//        {

//        }
//        public void Display()
//        {
//            Console.WriteLine("\n");
//            Console.WriteLine("Variable1: " + Var1);
//            Console.WriteLine("Variable2: " + Var2);
//        }
//        public void SaveToJson()
//        {
//            var filePath = @"C:\Users\fnome\source\repos\ConsoleApp1\ConsoleApp1\end.json";
//            string json = JsonConvert.SerializeObject(this);
//            File.WriteAllText(filePath, json);
//        }
//        ~Variables()
//        {

//            Console.WriteLine("Objects have been deleted");

//        }

//    }




//4.1

//using System;
//using System.Diagnostics.CodeAnalysis;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography.X509Certificates;



//public class Number
//{
//    public double Denominator1;
//    public double Numerator1;
//    public double Denominator2;
//    public double Numerator2;
//    public Random rnd = new Random();
//    public void RandomValue()
//    {
//        Denominator1 = rnd.Next(1, 11);
//        Numerator1 = rnd.Next(11, 21);
//        Denominator2 = rnd.Next(1, 11);
//        Numerator2 = rnd.Next(11, 21);
//    }

//    public override string ToString()
//    {
//        return $"Denominator is {Denominator1}, Numerator is {Numerator1}" + "\n" +
//               $"second Denominator is {Denominator2}, second Numerator is {Numerator2}";
//    }
//    public override int GetHashCode()
//    {
//        return base.GetHashCode();
//    }
//    public override bool Equals(object obj)
//    {
//        if (obj is Number number)
//            return Denominator1 == number.Denominator1 && Numerator1 == number.Numerator1 && Denominator2 == number.Denominator2 && Numerator2 == number.Numerator2;
//        return false;
//    }
//}

//public class Sign : Number
//{
//    public void RandomSign()
//    {

//        int sign = rnd.Next(1, 4);
//        if (sign == 1)
//        {
//            Denominator1 = -Denominator1;
//        }
//        else if (sign == 2)
//        {
//            Denominator2 = -Denominator2;
//        }
//        else if (sign == 3)
//        {
//            Denominator1 = -Denominator1;
//            Denominator2 = -Denominator2;
//        }
//    }
//    public override string ToString()
//    {
//        return $"Denominator is {Denominator1}, Numerator is {Numerator1}" + "\n" +
//               $"second Denominator is {Denominator2}, second Numerator is {Numerator2}";
//    }
//    public override int GetHashCode()
//    {
//        return base.GetHashCode();
//    }
//    public override bool Equals(object obj)
//    {
//        if (obj is Sign sign)
//            return Denominator1 == sign.Denominator1 && Numerator1 == sign.Numerator1 && Denominator2 == sign.Denominator2 && Numerator2 == sign.Numerator2;
//        return false;
//    }
//}

//public class SimpleFraction : Sign
//{
//    public double fraction1;
//    public double fraction2;

//    public void CreateFraction()
//    {
//        fraction1 = Denominator1 / Numerator1;
//        fraction2 = Denominator2 / Numerator2;
//    }
//    public double Sum()
//    {
//        return fraction1 + fraction2;
//    }
//    public double Subtraction()
//    {
//        return fraction1 - fraction2;
//    }
//    public double Multiplication()
//    {
//        return fraction1 * fraction2;
//    }
//    public double Division()
//    {
//        return fraction1 / fraction2;
//    }

//    public override string ToString()
//    {
//        return $"First Fraction = {fraction1}, Second Fraction {fraction2}\n" +
//              $"Amount = {Sum()}, Subtraction = {Subtraction()}, Multiplication = {Multiplication()}, Division = {Division()} ";

//    }
//    public override int GetHashCode()
//    {
//        return base.GetHashCode();
//    }
//    public override bool Equals(object obj)
//    {
//        if (obj is SimpleFraction fract)
//            return Denominator1 == fract.Denominator1 && Numerator1 == fract.Numerator1 && Denominator2 == fract.Denominator2 && Numerator2 == fract.Numerator2 &&
//                     fraction1 == fract.fraction1 && fraction2 == fract.fraction2;
//        return false;
//    }

//}


