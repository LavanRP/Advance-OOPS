using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// MedicineDetails is used to hold information about medicine <see cref="MedicineDetails"/>
    /// </summary>
    public class MedicineDetails
    {
        /// <summary>
        /// s_mNumber is private field used for auto increment <see cref="MedicineDetails"/>
        /// </summary>
        private static int s_mNumber = 101;
        /// <summary>
        /// MedicineID property is used to store and give Medicine ID<see cref="MedicineDetails"/>
        /// </summary> 
        public string MedicineID { get; set; }
        /// <summary>
        /// MedicineName property is used to store and give Medicine Name<see cref="MedicineDetails"/>
        /// </summary> 
        public string MedicineName { get; set; }
        /// <summary>
        /// AvailableCount property is used to store and give Available Count  of Medicine<see cref="MedicineDetails"/>
        /// </summary> 
        public int AvailableCount { get; set; }
        /// <summary>
        /// Price property is used to store and give Price of the Medicine<see cref="MedicineDetails"/>
        /// </summary> 
        public int Price { get; set; }
        /// <summary>
        /// DateOfExpiry property is used to store and give Date Of Expiry Medicine<see cref="MedicineDetails"/>
        /// </summary> 
        public DateTime DateOfExpiry { get; set; }
        /// <summary>
        /// this constructor is used to assigne the value to the properties<see cref="MedicineDetails"/>
        /// </summary>
        /// <param name="medicineName">medicineName give the medicine Name</param>
        /// <param name="availableCount">availableCount give the available Count of medicine</param>
        /// <param name="price">price give the price of medicine</param>
        /// <param name="dateOfExpiry">dateOfExpiry give the date Of Expiry of medicine</param>
        public MedicineDetails(string medicineName, int availableCount, int price, DateTime dateOfExpiry)
        {
            MedicineID = "MD" + s_mNumber;
            s_mNumber++;
            MedicineName = medicineName;
            AvailableCount = availableCount;
            Price = price;
            DateOfExpiry = dateOfExpiry;
        }
        /// <summary>
        /// this constructer is used to read data from csv file<see cref="MedicineDetails"/>
        /// </summary>
        /// <param name="line">line is the output from csv file</param> 
        public MedicineDetails(string line)
        {
            string[] str = line.Split(",");
            MedicineID = str[0];
            s_mNumber = int.Parse(str[0].Remove(0, 2));
            MedicineName = str[1];
            AvailableCount = int.Parse(str[2]);
            Price = int.Parse(str[3]);
            DateOfExpiry = DateTime.ParseExact(str[4], "dd/MM/yyyy", null);
        }
    }
}