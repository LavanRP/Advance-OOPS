using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// OrderStatus it is public Enum which has the following values{Default, Initiated, Ordered, Cancelled} <see cref="OrderDetails"/>
    /// </summary>
    public enum OrderStatus{Default, Initiated, Ordered, Cancelled}
    /// <summary>
    /// OrderDetails class holds the information about orders <see cref="OrderDetails"/>
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// _sOrderNumber it is a private static field used for auto increament in Order  ID <see cref = "OrderDetails"/>
        /// </summary>
        private static int _sOrderNumber = 1001;
        /// <summary>
        /// OrderID properties hold user OrderID of instance of <see cref="OrderDetails"/>
        /// </summary>        
        public string OrderID { get; set; } 
        /// <summary>
        /// UserID properties hold user UserID of instance of <see cref="OrderDetails"/>
        /// </summary> 
        public string UserID { get; set; } 
        /// <summary>
        /// OrderDate properties hold user OrderDate of instance of <see cref="OrderDetails"/>
        /// </summary> 
        public DateTime OrderDate { get; set; } 
        /// <summary>
        /// TotalPrice properties hold user TotalPrice of instance of <see cref="OrderDetails"/>
        /// </summary> 
        public int TotalPrice { get; set; } 
        /// <summary>
        /// OrderStatus properties hold user OrderStatus of instance of <see cref="OrderDetails"/>
        /// </summary> 
        public OrderStatus OrderStatus { get; set; } 
        /// <summary>
        /// OrderDetails is a constructor used to assigne values.<see cref="OrderDetails"/>
        /// </summary>
        /// <param name="userID">userID is used to store value in UserID</param>
        /// <param name="orderDate">orderDate is used to store value in OrderDate</param>
        /// <param name="totalPrice">totalPrice is used to store value in TotalPrice</param>
        /// <param name="orderStatus">orderStatus is used to store value in OrderStatus</param>
        public OrderDetails(string userID,DateTime orderDate,int totalPrice,OrderStatus orderStatus)
        {
            OrderID = "OID"+_sOrderNumber;
            _sOrderNumber++;
            UserID = userID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            OrderStatus = orderStatus;

        }
    }
}