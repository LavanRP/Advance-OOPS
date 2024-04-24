using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    /// <summary>
    /// OrderDetails class has all the information about OrderDetails<see cref="OrderDetails"/>
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// s_oNumber is a private field used to for auto increament in order id<see cref="OrderDetails"/>
        /// </summary>
        private static int s_oNumber = 4000;
        /// <summary>
        /// OrderID is used to store and get Order ID<see cref="OrderDetails"/>
        /// </summary>
        public string OrderID { get; set; }
        /// <summary>
        /// BookingID is used to store and get Order BookingID<see cref="OrderDetails"/>
        /// </summary>
        public string BookingID { get; set; }
        /// <summary>
        /// ProductID is used to store and get Order ProductID<see cref="OrderDetails"/>
        /// </summary>
        public string ProductID { get; set; }
        /// <summary>
        /// PurchaseCount is used to store and get Order PurchaseCount<see cref="OrderDetails"/>
        /// </summary>
        public int PurchaseCount { get; set; }
        /// <summary>
        /// PriceOfOrder is used to store and get Order PriceOfOrder<see cref="OrderDetails"/>
        /// </summary>
        public int PriceOfOrder { get; set; }
        /// <summary>
        /// this constructor is used to assigne the value to the property<see cref="OrderDetails"/>
        /// </summary>
        /// <param name="bookingID">bookingID is bookingID order bookingID </param>
        /// <param name="productID">productID is bookingID order productID </param>
        /// <param name="purchaseCount">purchaseCount is bookingID order purchase Count </param>
        /// <param name="priceOfOrder">priceOfOrder is bookingID order price </param>
        public OrderDetails(string bookingID, string productID, int purchaseCount, int priceOfOrder)
        {
            s_oNumber++;
            OrderID = "OID" + s_oNumber;
            
            BookingID = bookingID;
            ProductID = productID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }
        /// <summary>
        /// this constructor is used to read the values from the csv<see cref="OrderDetails"/>
        /// </summary>
        /// <param name="line">line is the output from csv file</param>
        public OrderDetails(string line)
        {
            string[] arr = line.Split(",");
            OrderID = arr[0];
            s_oNumber = int.Parse(arr[0].Remove(0,3));
            BookingID = arr[1];
            ProductID = arr[2];
            PurchaseCount = int.Parse(arr[3]);
            PriceOfOrder = int.Parse(arr[4]);
        }
    }
}