using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    /// <summary>
    /// BookingStatus is a public enum which has following value {Default, Initiated, Booked,Cancelled}<see cref="BookingDetails"/>
    /// </summary>
    public enum BookingStatus{Default, Initiated, Booked,Cancelled}
    /// <summary>
    /// BookingDetails class holds the information about Booking Details<see cref="BookingDetails"/>
    /// </summary>
    public class BookingDetails
    {
        /// <summary>
        /// s_bNumber is a private field usedd for auto increment in Booking ID<see cref="BookingDetails"/>
        /// </summary>
        private static int s_bNumber = 3000;
        /// <summary>
        /// BookingID is used to give and store the the Booking's ID <see cref="BookingDetails"/>
        /// </summary>
        public string BookingID { get; set; }
        /// <summary>
        /// CustomerID is used to give and store the the Customer's ID <see cref="BookingDetails"/>
        /// </summary>
        public string CustomerID { get; set; }
        /// <summary>
        /// TotalPrice is used to give and store the total price the booking <see cref="BookingDetails"/>
        /// </summary>
        public int TotalPrice { get; set; }
        /// <summary>
        /// DateOfBooking is used to give and store the Date Of Booking <see cref="BookingDetails"/>
        /// </summary>
        public DateTime DateOfBooking { get; set; }
        /// <summary>
        /// BookingStatus is used to give and store the  Booking status <see cref="BookingDetails"/>
        /// </summary>
        public BookingStatus BookingStatus { get; set; }
        /// <summary>
        /// this constructor is used to assigne the value to the properties <see cref="BookingDetails"/>
        /// </summary>
        /// <param name="customerID">customerID gives customer's ID</param>
        /// <param name="totalPrice">totalPrice give the total Price of the product</param>
        /// <param name="dateOfBooking">dateOfBooking give the date Of Booking</param>
        /// <param name="bookingStatus">bookingStatus give the Status of the booking</param>
        public BookingDetails(string customerID,int totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bNumber++;
            BookingID = "BID"+s_bNumber;
            
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
        }
        /// <summary>
        /// this constructor is used to read the values from the csv file<see cref="BookingDetails"/>
        /// </summary>
        /// <param name="line">line is the output from the csu file</param>
        public BookingDetails(string line)
        {
            string[] arr = line.Split(",");
            BookingID = arr[0];
            s_bNumber = int.Parse(arr[0].Remove(0,3));
            CustomerID = arr[1];
            TotalPrice = int.Parse(arr[2]);
            DateOfBooking = DateTime.ParseExact(arr[3],"dd/MM/yyyy",null);
            BookingStatus = Enum.Parse<BookingStatus>(arr[4],true);
        }
        /// <summary>
        /// ShowProductDetails is used to display bookingg details<see cref="BookingDetails"/>
        /// </summary>
        public void ShowProductDetails()
        {

            Console.WriteLine($"|{"BookingID"}|{"CustomerID"}|{"TotalPrice"}|{"DateOfBooking"}|{"BookingStatus"}|");
            for(int i= 0 ;i<Operation.bookingCustomList.Count;i++)
            {
                Console.WriteLine($"|{Operation.bookingCustomList[i].BookingID}|{Operation.bookingCustomList[i].CustomerID}|{Operation.bookingCustomList[i].TotalPrice}|{Operation.bookingCustomList[i].DateOfBooking.ToString("dd/MM/yyyy")}|{Operation.bookingCustomList[i].BookingStatus}|");
            }
        }

    }
}