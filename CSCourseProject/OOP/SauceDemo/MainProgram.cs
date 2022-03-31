using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSCourseProject.OOP.SauceDemo
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Sauce Labs Backpack
            Item SLBackpack = new Item();
            SLBackpack.itemName = "Sauce Labs Backpack";
            SLBackpack.itemDesc = "carry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.";
            SLBackpack.itemPrice = 29.99;
            SLBackpack.itemImage = "https://www.saucedemo.com/static/media/sauce-backpack-1200x1500.34e7aa42.jpg";
            SLBackpack.hasAddToCart = true;


            // Sauce Labs Bolt T-Shirt
            Item SLBoltTShirt = new Item();
            SLBoltTShirt.itemName = "Sauce Labs Bolt T-Shirt";
            SLBoltTShirt.itemDesc = "Get your testing superhero on with the Sauce Labs bolt T-shirt. From American Apparel, 100% ringspun combed cotton, heather gray with red bolt.";
            SLBoltTShirt.itemPrice = 15.99;
            SLBoltTShirt.itemImage = "https://www.saucedemo.com/static/media/bolt-shirt-1200x1500.c0dae290.jpg";
            SLBoltTShirt.hasAddToCart = true;


            // Sauce Labs Onesie
            Item SLOnesie = new Item();
            SLOnesie.itemName = "Sauce Labs Onesie";
            SLOnesie.itemDesc = "Rib snap infant onesie for the junior automation engineer in development. Reinforced 3-snap bottom closure, two-needle hemmed sleeved and bottom won't unravel.";
            SLOnesie.itemPrice = 7.99;
            SLOnesie.itemImage = "https://www.saucedemo.com/static/media/red-onesie-1200x1500.1b15e1fa.jpg";
            SLOnesie.hasAddToCart = true;


            // Sauce Labs Bike Light
            Item SLBikeLight = new Item();
            SLBikeLight.itemName = "Sauce Labs Bike Light";
            SLBikeLight.itemDesc = "A red light isn't the desired state in testing but it sure helps when riding your bike at night. Water-resistant with 3 lighting modes, 1 AAA battery included.";
            SLBikeLight.itemPrice = 9.99;
            SLBikeLight.itemImage = "https://www.saucedemo.com/static/media/bike-light-1200x1500.a0c9caae.jpg";
            SLBikeLight.hasAddToCart = true;


            // Sauce Labs Fleece Jacket
            Item SLFleeceJacket = new Item();
            SLFleeceJacket.itemName = "Sauce Labs Fleece Jacket";
            SLFleeceJacket.itemDesc = "It's not every day that you come across a midweight quarter-zip fleece jacket capable of handling everything from a relaxing day outdoors to a busy day at the office.";
            SLFleeceJacket.itemPrice = 49.99;
            SLFleeceJacket.itemImage = "https://www.saucedemo.com/static/media/sauce-pullover-1200x1500.439fc934.jpg";
            SLFleeceJacket.hasAddToCart = true;


            // Test.allTheThings() T-Shirt (Red)
            Item TestAllTShirt = new Item();
            TestAllTShirt.itemName = "Test.allTheThings() T-Shirt (Red)";
            TestAllTShirt.itemDesc = "This classic Sauce Labs t-shirt is perfect to wear when cozying up to your keyboard to automate a few tests. Super-soft and comfy ringspun combed cotton.";
            TestAllTShirt.itemPrice = 15.99;
            TestAllTShirt.itemImage = "https://www.saucedemo.com/static/media/red-tatt-1200x1500.e32b4ef9.jpg";
            TestAllTShirt.hasAddToCart = true;


        }
    }
}
