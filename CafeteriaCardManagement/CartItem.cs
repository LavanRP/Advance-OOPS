using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// CartItem class holds all the details about product thet user selects<see cref = "CartItem"/>
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// _sItemNumber it is a private static field used for auto increament in ItemID <see cref = "CartItem"/>
        /// </summary>
        private static int _sItemNumber = 101;
        /// <summary>
        /// ItemID properties hold user selected item's ID of instance of <see cref="CartItem"/>
        /// </summary>
        public string ItemID { get; set; }
        /// <summary>
        /// OrderID properties hold user OrderID of instance of <see cref="CartItem"/>
        /// </summary>
        public string OrderID { get; set; }
        /// <summary>
        /// FoodID properties hold user selected FoodID of instance of <see cref="CartItem"/>
        /// </summary>
        public string FoodID { get; set; }
        /// <summary>
        /// OrderPrice properties hold user selected OrderPrice of instance of <see cref="CartItem"/>
        /// </summary>
        public int OrderPrice { get; set; }
        /// <summary>
        /// OrderQuantity properties hold user selected Order Quantity of instance of <see cref="CartItem"/>
        /// </summary>
        public int OrderQuantity { get; set; }
        /// <summary>
        /// OrderDetails is a constructor used to assigne values <see cref="CartItem"/>
        /// </summary>
        /// <param name="orderID">orderID is used to store value in orderID</param>
        /// <param name="foodID">foodID is used to store value in foodID</param>
        /// <param name="orderPrice">orderPrice is used to store value in orderPrice</param>
        /// <param name="orderQuantity">orderQuantity is used to store value in orderQuantity</param> 
        public CartItem(string orderID, string foodID, int orderPrice, int orderQuantity)
        {
            ItemID = "ITID" + _sItemNumber;
            _sItemNumber++;
            OrderID = orderID;
            FoodID = foodID;
            OrderPrice = orderPrice;
            OrderQuantity = orderQuantity;
        }
    }
}