using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCourseProject.OOP.Classes_and_Objects
{
    class MobileDevice
    {
        public string model;
        // A - Android, I - iOS, W - Windows Phone
        public char OS;
        public double OSVersion;
        public bool hasFlash;
        public int price;

        public void PrintParameters()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("OS: " + OS);
            Console.WriteLine("OS Version: " + OSVersion);
            Console.WriteLine("Flash: " + hasFlash);
            Console.WriteLine("Price: $" + price);
            Console.ReadKey();
        }
    }
}
