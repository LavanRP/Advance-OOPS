using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// OrderStatus is a public enum has following values {Purchased, Cancelled}<see cref="OrderDetails"/>
    /// </summary>
    public enum OrderStatus { Purchased, Cancelled }
    /// <summary>
    /// OrderDetails class holds all the order details of the user<see cref="OrderDetails"/>
    /// </summary> 
    public class OrderDetails
    {
        /// <summary>
        /// s_oNumber is private field used for auto increment <see cref="OrderDetails"/>
        /// </summary>
        private static int s_oNumber = 2001;
        /// <summary>
        /// OrderID property is used to store and get order ID <see cref="OrderDetails"/>
        /// </summary>
        public string OrderID { get; set; }
        /// <summary>
        /// UserID property is used to store and get UserID <see cref="OrderDetails"/>
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// MedicineID property is used to store and get Medicine ID <see cref="OrderDetails"/>
        /// </summary>
        public string MedicineID { get; set; }
        /// <summary>
        /// MedicineCount property is used to store and get Medicine Count <see cref="OrderDetails"/>
        /// </summary>
        public int MedicineCount { get; set; }
        /// <summary>
        /// TotalPrice property is used to store and get order TotalPrice <see cref="OrderDetails"/>
        /// </summary>
        public int TotalPrice { get; set; }
        /// <summary>
        /// OrderDate property is used to store and get order Date <see cref="OrderDetails"/>
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// OrderStatus property is used to store and get Order Status <see cref="OrderDetails"/>
        /// </summary>
        public OrderStatus OrderStatus { get; set; }
        /// <summary>
        /// this constructor is used to assigne values to the properties <see cref="OrderDetails"/>
        /// </summary>
        /// <param name="userID">userID gives user id</param>
        /// <param name="medicineID">medicineID gives medicine ID</param>
        /// <param name="medicineCount">medicineCount gives medicineCount</param>
        /// <param name="totalPrice">totalPrice gives total Price</param>
        /// <param name="orderDate">orderDate gives order Date</param>
        /// <param name="orderStatus">orderStatus gives order Status</param>
        public OrderDetails(string userID, string medicineID, int medicineCount, int totalPrice, DateTime orderDate, OrderStatus orderStatus)
        {
            OrderID = "OID" + s_oNumber;
            s_oNumber++;
            UserID = userID;
            MedicineID = medicineID;
            MedicineCount = medicineCount;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }
        /// <summary>
        /// this constructor is used read from csv file<see cref="OrderDetails"/>
        /// </summary>
        /// <param name="line">line gives csv string</param>
        public OrderDetails(string line)
        {
            string[] str = line.Split(",");
            OrderID = str[0];
            s_oNumber = int.Parse(str[0].Remove(0, 3));
            UserID = str[1];
            MedicineID = str[2];
            MedicineCount = int.Parse(str[3]);
            TotalPrice = int.Parse(str[4]);
            OrderDate = DateTime.ParseExact(str[5], "dd/MM/yyyy", null);
            OrderStatus = Enum.Parse<OrderStatus>(str[6]);
        }
    }
}