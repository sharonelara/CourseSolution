using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Properties items should have:
//      Name
//      Description
//      Price
//      Image(*)
//      Cart button - 


namespace CSCourseProject.OOP.SauceDemo
{
    class Item
    {
        // Item name
        public string itemName;
        // Item decsription
        public string itemDesc;
        // Item price
        public double itemPrice;
        // Item image URL
        public string itemImage;
        // Cart button - boolean, if true "Add to cart" should be clicked. if false, "Remove" button is there and should not be clicked.
        public bool hasAddToCart;

        public void clickAddToCart()
        {
            if (hasAddToCart)
            {
                //click button
            }
            else
                //no click
        }
    }
}
