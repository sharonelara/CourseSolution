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

            iPhone.PrintParameters();
            
        }
    }
}
