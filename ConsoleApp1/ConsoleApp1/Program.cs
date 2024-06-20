
//1.1

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;


//namespace Laba1
//{
//    class Program
//    {
//        static void Main()
//        {
//            bool active = true;

//            Console.WriteLine("Write number of parking");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("\n");

//            Random rnd = new Random();

//            List<int> parking = new List<int>();

//            for (int i = 0; i < n; i++)
//            {
//                parking.Add(rnd.Next(0, 2));
//            }

//            parking.Reverse();

//            Console.WriteLine(string.Join("\n", parking));


//            while(active)
//            {
//                Console.WriteLine("\n\t\tChoose an action");
//                Console.WriteLine("\t1 - car go to the parking, 2 - car car leaving the parking slot, 3 - leave the project");

//                int inputValue = int.Parse(Console.ReadLine());

//                if (inputValue == 1)
//                {
//                    Console.WriteLine("\nChose the palce");
//                    int inputPlace = int.Parse(Console.ReadLine());
//                    GoCarParking(parking, n, inputPlace);
//                    Console.WriteLine(string.Join("\n", parking));

//                    active = true;
//                }
//                else if (inputValue == 2)
//                {
//                    Console.WriteLine("\nChose the car");
//                    int inputNumCar = int.Parse(Console.ReadLine());
//                    DeleteTheCar(parking, n, inputNumCar);
//                    Console.WriteLine(string.Join("\n", parking));

//                    active = true;
//                }
//                else if (inputValue == 3)
//                {
//                    active = false;
//                }
//                Console.WriteLine("\nFree place");
//                FreeSeats(parking, n);
//            }

//        } 
//        static void FreeSeats(List<int> parking, int n)
//        {
//            for (int i = 0; i < n; i++)
//            {
//                if (parking[i] == 0)
//                {                   
//                    Console.Write(i + 1 + " ");
//                }
//            }
//        }
//        static void GoCarParking(List<int> parking, int n, int inputPlace)
//        {
//            if (parking[inputPlace - 1] == 0)
//            {
//                parking[inputPlace - 1] = 1;
//            }
//            else
//            {
//                Console.WriteLine("There is no place for car");
//            }
//        }

//        static void DeleteTheCar(List<int> parking, int n, int inputNumCar)
//        {
//            if (parking[inputNumCar - 1] == 1)
//            {
//                parking[inputNumCar - 1] = 0;
//            }
//            else
//            {
//                Console.WriteLine("There is no car here");
//            }
//        }


//    }
//}



//1.2
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Newtonsoft.Json;

//namespace Laba1_4_
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string path = @"C:\Users\fnome\source\repos\ConsoleApp1\ConsoleApp1\file.json";
//            var json = File.ReadAllText(path);

//            Console.WriteLine(json);

//            Dictionary<int, string> dict = JsonConvert.DeserializeObject<Dictionary<int, string>>(json);
//            Console.WriteLine(string.Join(" ", dict));
//            FindDuplicateValues(dict);
//        }
//        static void FindDuplicateValues(Dictionary<int, string> dict1)
//        {
//            Dictionary<string, int> valueCount = new Dictionary<string, int>();

//            foreach (var kvp in dict1)
//            {


//                if (valueCount.ContainsKey(kvp.Value))
//                {
//                    valueCount[kvp.Value]++;
//                }
//                else
//                {
//                    valueCount[kvp.Value] = 1;
//                }
//            }

//            Console.WriteLine("\nRepeating values:");
//            foreach (var kvp in valueCount)
//            {
//                if (kvp.Value > 1)
//                {
//                    Console.WriteLine($"{kvp.Key}: {kvp.Value} times");
//                }
//            }
//            Console.WriteLine("\n");
//        }
//    }
//}







//1.3

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices.ComTypes;
//using System.Text;
//using System.Threading.Tasks;


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        List<string> words = new List<string> { "Ukraine", "Brazil", "Japan", "Korea", "Andora", "Vietnam", "Kongo", "Liechtenstein", "Uganda", "South Afrika" };

//        Console.WriteLine(string.Join(" ", words));

//        int totalLength = words.Sum(s => s.Length);

//        Console.WriteLine("suma dovjyn vsih ryadkiv: " + totalLength);
//        Console.ReadKey();
//    }
//}


// 3.1
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int var1 = 123;
//            int var2 = 321;

//            Variables empt1 = new Variables(var1, var2);
//            empt1.Display();

//            Variables empt2 = new Variables();
//            empt2.Display();

//            Console.WriteLine();
//        }

//    }



////3.2
//using System;
//using System.IO;
//using Newtonsoft.Json;


//    internal class Program
//    {

//        static void Main(string[] args)
//        {
//            string path = @"C:\Users\fnome\source\repos\ConsoleApp1\ConsoleApp1\start.json";

//            Variables empt1 = new Variables(path);

//            empt1.Display();

//            Variables empt2 = new Variables();

//            empt2.Display();
//            empt1.SaveToJson();
//            Console.WriteLine();
//        }

//    }



//4.1

//using System;
//using static System.Runtime.InteropServices.JavaScript.JSType;



//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Number number = new Number();

//        number.RandomValue();
//        Console.WriteLine(number.ToString());

//        Console.WriteLine("\nWe place signs");

//        Sign sign = new Sign();

//        sign.RandomValue();
//        sign.RandomSign();
//        Console.WriteLine(sign.ToString());

//        Console.WriteLine("\nMake fractions with these numbers");

//        SimpleFraction fraction = new SimpleFraction();

//        fraction.RandomValue();
//        fraction.RandomSign();
//        fraction.CreateFraction();
//        Console.WriteLine(fraction.ToString());
//    }
//}





//4.2

//using ConsoleApp1._123;
//using System;
//using System.Collections.Generic;



//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool active = true;

//            Storage storage = new Storage();

//        storage.AddPhone(new Smartphone { Model = "Pixel 5", Manufacturer = "Google", DisplaySize = 5.8, Price = 600 });
//        storage.AddPhone(new Smartphone { Model = "Xperia XZ3", Manufacturer = "Sony", DisplaySize = 6.0, Price = 500 });
//        storage.AddPhone(new Smartphone { Model = "Xperia XZ3", Manufacturer = "Sony", DisplaySize = 6.0, Price = 500 });
//        storage.AddPhone(new Smartphone { Model = "Mi 11", Manufacturer = "Xiaomi", DisplaySize = 6.7, Price = 700 });
//        storage.AddPhone(new Smartphone { Model = "Mi 11", Manufacturer = "Xiaomi", DisplaySize = 6.7, Price = 700 });
//        storage.AddPhone(new Smartphone { Model = "Mi 11", Manufacturer = "Xiaomi", DisplaySize = 6.7, Price = 700 });
//        storage.AddPhone(new Smartphone { Model = "Mi 11", Manufacturer = "Xiaomi", DisplaySize = 6.7, Price = 700 });
//        storage.AddPhone(new Smartphone { Model = "Mi 11", Manufacturer = "Xiaomi", DisplaySize = 6.7, Price = 700 });
//        storage.AddPhone(new Smartphone { Model = "Mi 11", Manufacturer = "Xiaomi", DisplaySize = 6.7, Price = 700 });
//        storage.AddPhone(new Smartphone { Model = "Pixel 5", Manufacturer = "Google", DisplaySize = 5.8, Price = 600 });
//        storage.AddPhone(new Smartphone { Model = "Pixel 5", Manufacturer = "Google", DisplaySize = 5.8, Price = 600 });
//        storage.AddPhone(new Smartphone { Model = "Pixel 5", Manufacturer = "Google", DisplaySize = 5.8, Price = 600 });
//        storage.AddPhone(new Smartphone { Model = "Xperia XZ3", Manufacturer = "Sony", DisplaySize = 6.0, Price = 500 });
//        storage.AddPhone(new Smartphone { Model = "Xperia XZ3", Manufacturer = "Sony", DisplaySize = 6.0, Price = 500 });
//        storage.AddPhone(new Smartphone { Model = "Xperia XZ3", Manufacturer = "Sony", DisplaySize = 6.0, Price = 500 });
//        storage.AddPhone(new Smartphone { Model = "Xperia XZ3", Manufacturer = "Sony", DisplaySize = 6.0, Price = 500 });
//        storage.AddPhone(new Smartphone { Model = "Xperia XZ3", Manufacturer = "Sony", DisplaySize = 6.0, Price = 500 });
//        storage.AddPhone(new Smartphone { Model = "Xperia XZ3", Manufacturer = "Sony", DisplaySize = 6.0, Price = 500 });
//        storage.AddPhone(new Smartphone { Model = "Redmi Note 9", Manufacturer = "Xiaomi", DisplaySize = 6.3, Price = 200 });
//        storage.AddPhone(new Smartphone { Model = "Redmi Note 9", Manufacturer = "Xiaomi", DisplaySize = 6.3, Price = 200 });
//        storage.AddPhone(new Smartphone { Model = "Redmi Note 9", Manufacturer = "Xiaomi", DisplaySize = 6.3, Price = 200 });
//        storage.AddPhone(new Smartphone { Model = "Redmi Note 9", Manufacturer = "Xiaomi", DisplaySize = 6.3, Price = 200 });
//        storage.AddPhone(new Smartphone { Model = "Mi 11", Manufacturer = "Xiaomi", DisplaySize = 6.7, Price = 700 });


//        while (active)
//            {
//                Console.ForegroundColor = ConsoleColor.Green;

//                Console.WriteLine(" Select a search option");
//                Console.WriteLine("1 - Search phone by Model");
//                Console.WriteLine("2 - Search phone by Manufacturer");
//                Console.WriteLine("3 - Search phone by DisplaySize");
//                Console.WriteLine("4 - Search phone by Price");
//                Console.WriteLine("5 - Exit");
//                Console.WriteLine("6 - for sorted phones by manufacturer");
//                Console.WriteLine("7 - for sorted phones by display size");
//                Console.WriteLine("8 - for sorted phones by models");
//                Console.WriteLine("===========================================");
//                Console.ResetColor();
//                int inputValue = int.Parse(Console.ReadLine());

//                if (inputValue == 1)
//                {
//                    Console.WriteLine("Write a phone Model");

//                    string modelToFind = Console.ReadLine();
//                    Smartphone foundPhone = storage.FindPhoneByModel(modelToFind);

//                    if (foundPhone != null)
//                    {
//                        Console.WriteLine($"Found phone: {foundPhone.Manufacturer} {foundPhone.Model} - {foundPhone.DisplaySize} - {foundPhone.Price}$");
//                    }
//                    else
//                    {
//                        Console.WriteLine($"Phone with model '{modelToFind}' not found.");
//                    }

//                    Console.WriteLine("Press any key to go back");
//                    Console.ReadKey();

//                    Console.Clear();
//                }
//                else if (inputValue == 2)
//                {
//                    Console.WriteLine("Write a phone Manufacturer");

//                    string manufToFind = Console.ReadLine();
//                    Smartphone foundPhone = storage.FindPhoneByManufacturer(manufToFind);

//                    if (foundPhone != null)
//                    {
//                        Console.WriteLine($"Found phone: {foundPhone.Manufacturer} - {foundPhone.Model} - {foundPhone.DisplaySize} - {foundPhone.Price}$");
//                    }
//                    else
//                    {
//                        Console.WriteLine($"Phone with model '{manufToFind}' not found.");
//                    }

//                    Console.WriteLine("Press any key to go back");
//                    Console.ReadKey();

//                    Console.Clear();
//                }
//                else if (inputValue == 3)
//                {
//                    Console.WriteLine("Enter display size:");
//                    double displaySize = double.Parse(Console.ReadLine());

//                    List<Smartphone> phonesByDisplaySize = storage.FindPhonesByDisplaySize(displaySize);

//                    Console.WriteLine($"Phones with display size {displaySize}:");
//                    foreach (var phone in phonesByDisplaySize)
//                    {
//                        Console.WriteLine($"{phone.Manufacturer} {phone.Model} - {phone.DisplaySize} - {phone.Price}$");
//                    }

//                    Console.WriteLine("Press any key to go back");
//                    Console.ReadKey();

//                    Console.Clear();
//                }
//                else if (inputValue == 4)
//                {
//                    Console.WriteLine("Enter the price range (first the minimum, then the maximum)");
//                    int minPrice = int.Parse(Console.ReadLine());
//                    int maxPrice = int.Parse(Console.ReadLine());
//                    List<Smartphone> phonesInRange = storage.FindPhonesByPriceRange(minPrice, maxPrice);
//                    Console.WriteLine($"Phones within price range ${minPrice} - ${maxPrice}:");
//                    foreach (var phone in phonesInRange)
//                    {
//                        Console.WriteLine($"{phone.Manufacturer} {phone.Model} - {phone.DisplaySize} - {phone.Price}$");
//                    }

//                    Console.WriteLine("Press any key to go back");
//                    Console.ReadKey();

//                    Console.Clear();
//                }
//                else if (inputValue == 5)
//                {
//                    Console.Clear();
//                    active = false;
//                }
//                else if (inputValue == 6)
//                {
//                    storage.SortPhonesByManufacturer();
//                    Console.WriteLine("Sorted phones by manufacturer:");

//                    for (int i = 0; i < storage.CountTotalPhones(); i++)
//                    {
//                        var phone = storage[i];
//                        Console.WriteLine($"{phone.Manufacturer} {phone.Model} - {phone.DisplaySize} - {phone.Price}$");
//                    }
//                    Console.WriteLine($"Total phones in warehouse: {storage.CountTotalPhones()}");
//                    Console.WriteLine("Press any key to go back");
//                    Console.ReadKey();

//                    Console.Clear();
//                }
//                else if (inputValue == 7)
//                {
//                    storage.SortPhonesByDisplaySize();
//                    Console.WriteLine("Sorted phones by display size:");
//                    for (int i = 0; i < storage.CountTotalPhones(); i++)
//                    {
//                        var phone = storage[i];
//                        Console.WriteLine($"{phone.Manufacturer} {phone.Model} - {phone.DisplaySize} - {phone.Price}$");
//                    }
//                    Console.WriteLine($"Total phones in warehouse: {storage.CountTotalPhones()}");
//                    Console.WriteLine("Press any key to go back");
//                    Console.ReadKey();

//                    Console.Clear();
//                }
//                if (inputValue == 8)
//                {
//                    storage.SortPhonesByModel();
//                    Console.WriteLine("Sorted phones by models:");
//                    for (int i = 0; i < storage.CountTotalPhones(); i++)
//                    {
//                        var phone = storage[i];
//                        Console.WriteLine($"{phone.Manufacturer} {phone.Model} - {phone.DisplaySize} - {phone.Price}$");
//                    }

//                    Console.WriteLine($"Total phones in warehouse: {storage.CountTotalPhones()}");
//                    Console.WriteLine("Press any key to go back");
//                    Console.ReadKey();

//                    Console.Clear();
//                }

//            }

//        }
//    }




//5

//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Runtime.ConstrainedExecution;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Motorcycle motocykle = new Motorcycle(92);
//            Bicycle velosyped = new Bicycle(20);
//            Moped moped = new Moped(32);
//            Car mashina = new Car(70, 4);
//            Train potyag = new Train(120, 10);
//            TwoWheeled electro_samocat = new TwoWheeled(25);

//            motocykle.DisplayInfo();
//            Console.WriteLine();
//            velosyped.DisplayInfo();
//            Console.WriteLine();
//            moped.DisplayInfo();
//            Console.WriteLine();
//            mashina.OpenDoors();
//            mashina.DisplayInfo();
//            Console.WriteLine();
//            potyag.DisplayInfo();
//            Console.WriteLine();
//            electro_samocat.DisplayInfo();
//        }
//    }
//}


