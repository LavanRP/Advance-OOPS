using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    /// <summary>
    /// FileHandling class is used to create read and write the date in csv file<see cref="FileHandling"/>
    /// </summary>
    public class FileHandling
    {
        /// <summary>
        /// Create method is used to create requied folder and csv files<see cref="FileHandling"/>
        /// </summary> 
        public static void Create()
        {
            if(!Directory.Exists("GroceryStoreFileManagement"))
            {
                Console.WriteLine("creating folder");
                Directory.CreateDirectory("GroceryStoreFileManagement");
            }

            if(!File.Exists("GroceryStoreFileManagement/CustomerRegistration.csv"))
            {
                Console.WriteLine("creating file");
                File.Create("GroceryStoreFileManagement/CustomerRegistration.csv").Close();
            }

            if(!File.Exists("GroceryStoreFileManagement/ProductDetails.csv"))
            {
                Console.WriteLine("creating file");
                File.Create("GroceryStoreFileManagement/ProductDetails.csv").Close();
            }

            if(!File.Exists("GroceryStoreFileManagement/OrderDetails.csv"))
            {
                Console.WriteLine("creating file");
                File.Create("GroceryStoreFileManagement/OrderDetails.csv").Close();
            }

            if(!File.Exists("GroceryStoreFileManagement/BookingDetails.csv"))
            {
                Console.WriteLine("creating file");
                File.Create("GroceryStoreFileManagement/BookingDetails.csv").Close();
            }
        } 
        /// <summary>
        /// WriteToCSV method is used to write the data in csv file<see cref="FileHandling"/>
        /// </summary>
        public static void WriteToCSV()
        {
            string[] custArr = new string[Operation.customersCustomList.Count];
            for(int i = 0;i<Operation.customersCustomList.Count;i++)
            {
                custArr[i] = Operation.customersCustomList[i].CustomerID+","+Operation.customersCustomList[i].WalletBalance+","+Operation.customersCustomList[i].Name+","+Operation.customersCustomList[i].FathersName+","+Operation.customersCustomList[i].Gender+","+Operation.customersCustomList[i].Mobile+","+Operation.customersCustomList[i].DOB.ToString("dd/MM/yyyy")+","+Operation.customersCustomList[i].MailID;
            }
            File.WriteAllLines("GroceryStoreFileManagement/CustomerRegistration.csv",custArr);

            string[] proArr = new string[Operation.ProductCustomList.Count];
            for(int i = 0 ;i< Operation.ProductCustomList.Count;i++)
            {
                proArr[i] = Operation.ProductCustomList[i].ProductID+","+Operation.ProductCustomList[i].ProductName+","+Operation.ProductCustomList[i].QuantityAvailable+","+Operation.ProductCustomList[i].PricePerQuantity;
            }
            File.WriteAllLines("GroceryStoreFileManagement/ProductDetails.csv",proArr);

            string[] ordArr = new string[Operation.globelOrderCustomList.Count];
            for(int i = 0 ; i< Operation.globelOrderCustomList.Count; i++)
            {
                ordArr[i] = Operation.globelOrderCustomList[i].OrderID+","+Operation.globelOrderCustomList[i].BookingID+","+Operation.globelOrderCustomList[i].ProductID+","+Operation.globelOrderCustomList[i].PurchaseCount+","+Operation.globelOrderCustomList[i].PriceOfOrder;
            }
            File.WriteAllLines("GroceryStoreFileManagement/OrderDetails.csv",ordArr);

            string[] booArr = new string[Operation.bookingCustomList.Count];
            for(int i = 0 ; i<Operation.bookingCustomList.Count ; i++)
            {
                booArr[i] = Operation.bookingCustomList[i].BookingID+","+Operation.bookingCustomList[i].CustomerID+","+Operation.bookingCustomList[i].TotalPrice+","+Operation.bookingCustomList[i].DateOfBooking.ToString("dd/MM/yyyy")+","+Operation.bookingCustomList[i].BookingStatus;
            }
            File.WriteAllLines("GroceryStoreFileManagement/BookingDetails.csv",booArr);
            
        }
        /// <summary>
        /// ReadFromCSV method is used to read from csv file<see cref="FileHandling"/>
        /// </summary>
        public static void ReadFromCSV()
        {
            string[] custArr = File.ReadAllLines("GroceryStoreFileManagement/CustomerRegistration.csv");
            foreach(string line in custArr)
            {
                string[] arr = line.Split(",");
                string customerID = arr[0];
                int walletBalance = int.Parse(arr[1]);
                string name = arr[2];
                string fathersName = arr[3];
                Gender gender = Enum.Parse<Gender>(arr[4],true);
                string number = arr[5];
                DateTime date = DateTime.ParseExact(arr[6],"dd/MM/yyyy",null);
                string mailID = arr[7];
                CustomerRegistration customer = new CustomerRegistration(customerID,walletBalance,name,fathersName,gender,number,date,mailID);
                Operation.customersCustomList.Add(customer);
            }

            string[] proArr = File.ReadAllLines("GroceryStoreFileManagement/ProductDetails.csv");
            foreach(string line in proArr)
            {
                ProductDetails product = new ProductDetails(line);
                Operation.ProductCustomList.Add(product);
            }

            string[] ordArr = File.ReadAllLines("GroceryStoreFileManagement/OrderDetails.csv");
            foreach(string line in ordArr)
            {
                OrderDetails order = new OrderDetails(line);
                Operation.globelOrderCustomList.Add(order);
            }

            string[] booArr = File.ReadAllLines("GroceryStoreFileManagement/BookingDetails.csv");
            foreach(string line in booArr)
            {
                BookingDetails booking = new BookingDetails(line);
                Operation.bookingCustomList.Add(booking);
            }
        }
    }
}