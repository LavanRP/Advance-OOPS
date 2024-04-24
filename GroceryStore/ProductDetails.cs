using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace GroceryStore
{
    /// <summary>
    /// ProductDetails class holds the information about Products<see cref="ProductDetails"/>
    /// </summary>
    public class ProductDetails
    {
        /// <summary>
        /// s_pNumber is private field used for auto increament in Product id <see cref="ProductDetails"/>
        /// </summary>
        private static int s_pNumber = 2000;
        /// <summary>
        /// ProductID is used to store and give prodect's ID<see cref="ProductDetails"/>
        /// </summary>
        public string ProductID  { get; set; }
        /// <summary>
        /// ProductName is used to store and give prodect's Name<see cref="ProductDetails"/>
        /// </summary>
        public string ProductName  { get; set; }
        /// <summary>
        /// QuantityAvailable is used to store and give prodect's Quantity Available<see cref="ProductDetails"/>
        /// </summary>
        public int QuantityAvailable  { get; set; }
         /// <summary>
        /// PricePerQuantity is used to store and give prodect's Price Pe rQuantity<see cref="ProductDetails"/>
        /// </summary>
        public int PricePerQuantity  { get; set; }

        /// <summary>
        /// This constructor is used for assigne values to the properties present in the class<see cref="ProductDetails"/>
        /// </summary>
        /// <param name="productName">productName gives the product Name</param>
        /// <param name="quantityAvailable">quantityAvailable gives the product quantity Available</param>
        /// <param name="pricePerQuantity">pricePerQuantity gives the product price Per Quantity</param> 
        public ProductDetails(string productName,int quantityAvailable,int pricePerQuantity)
        {
            s_pNumber++;
            ProductID = "PID"+s_pNumber;
            
            ProductName = productName;
            QuantityAvailable = quantityAvailable;
            PricePerQuantity = pricePerQuantity;
        }
        /// <summary>
        /// this constructor is used to read the values from csv file <see cref="ProductDetails"/>
        /// </summary>
        /// <param name="line"></param>
        public ProductDetails(string line)
        {
            string[] arr = line.Split(",");
            ProductID = arr[0];
            s_pNumber = int.Parse(arr[0].Remove(0,3));
            ProductName = arr[1];
            QuantityAvailable = int.Parse(arr[2]);
            PricePerQuantity = int.Parse(arr[3]);
        }
        /// <summary>
        /// ShowProductDetails method is used to display all the details about the products <see cref="ProductDetails"/>
        /// </summary>
        public static void ShowProductDetails()
        {
            Console.WriteLine($"|{"ProductID",-10}|{"ProductName",-18}|{"QuantityAvailable",-18}|{"PricePerQuantity",-17}|");
            for(int i = 0;i<Operation.ProductCustomList.Count;i++)
            {
                Console.WriteLine($"|{Operation.ProductCustomList[i].ProductID,-10}|{Operation.ProductCustomList[i].ProductName,-18}|{Operation.ProductCustomList[i].QuantityAvailable,-18}|{Operation.ProductCustomList[i].PricePerQuantity,-17}|");
            }
        }

    }
}