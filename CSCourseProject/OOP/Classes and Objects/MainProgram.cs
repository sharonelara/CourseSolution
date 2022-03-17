using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCourseProject.OOP.Classes_and_Objects
{
    class MainProgram
    {
    
        static void Main(string[] args)
        {
            MobileDevice iPhone = new MobileDevice();
            iPhone.model = "iPhone 12 mini";
            iPhone.OS = 'I';
            iPhone.OSVersion = 15;
            iPhone.hasFlash = true;
            iPhone.price = 600;
            iPhone.screenHeight = 5.78;
            iPhone.screenWidth = 2.82;

            iPhone.PrintParameters();
            Console.WriteLine("Area of screen is " + iPhone.CalculateArea());
            iPhone.PictureQuality();

            Console.ReadKey();

        }
    }
}
