using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// FoodDetails is used to hold all the food details<see cref="FoodDetails"/>
    /// </summary> 
    public class FoodDetails 
    {
        /// <summary>
        /// _sFoodNumber it is Private static field used for auto Inctement value in Food ID<see cref="FoodDetails"/>
        /// </summary>
        private static int _sFoodNumber = 101;
        /// <summary>
        /// FoodID properties hold food's id  of instance of <see cref="FoodDetails"/>
        /// </summary> 
        public string FoodID { get; set; }
        /// <summary>
        /// FoodName properties hold food's name  of instance of <see cref="FoodDetails"/>
        /// </summary> 
        public string FoodName { get; set; }
        /// <summary>
        /// FoodPrice properties hold food's price  of instance of <see cref="FoodDetails"/>
        /// </summary> 
        public int FoodPrice { get; set; }
        /// <summary>
        /// AvailableQuantity properties hold food's Available Quantity of instance of <see cref="FoodDetails"/>
        /// </summary> 
        public int AvailableQuantity { get; set; }
        /// <summary>
        /// FoodDetails is a constructor used to asigne values. <see cref="FoodDetails"/>
        /// </summary>
        /// <param name="foodName">foodName is used to store value in FoodName</param>
        /// <param name="foodPrice">foodPrice is used to store value in FoodPrice</param>
        /// <param name="availableQuantity">availableQuantity is used to store value in AvailableQuantity</param>
        public FoodDetails(string foodName,int foodPrice,int availableQuantity)
        {
            FoodID = "FID"+_sFoodNumber;
            _sFoodNumber++;
            FoodName = foodName;
            FoodPrice = foodPrice;
            AvailableQuantity = availableQuantity;
        }
    }
}