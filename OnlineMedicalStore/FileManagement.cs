using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// FileManagement is used to create write and read from csv file <see cref="FileManagement"/>
    /// </summary>
    public class FileManagement
    {
        /// <summary>
        /// Create is used to create required folder and csv files <see cref="FileManagement"/>
        /// </summary>
        public static void Create()
        {
            if (!Directory.Exists("MedicalStoreFileManagement"))
            {
                Console.WriteLine("MedicalStoreFileManagement done");
                Directory.CreateDirectory("MedicalStoreFileManagement");
            }


            if (!File.Exists("MedicalStoreFileManagement/UserDetail.csv"))
            {
                Console.WriteLine("UserDetail done");
                File.Create("MedicalStoreFileManagement/UserDetail.csv").Close();
            }


            if (!File.Exists("MedicalStoreFileManagement/MedicineDetails.csv"))
            {
                Console.WriteLine("MedicineDetails done");
                File.Create("MedicalStoreFileManagement/MedicineDetails.csv").Close();
            }


            if (!File.Exists("MedicalStoreFileManagement/OrderDetails.csv"))
            {
                Console.WriteLine("OrderDetails done");
                File.Create("MedicalStoreFileManagement/OrderDetails.csv").Close();
            }
        }

        /// <summary>
        /// WriteToCSV method is used to write the data in csv file <see cref="FileManagement"/>
        /// </summary>
        public static void WriteToCSV()
        {
            string[] userArr = new string[Operation.userCustomList.Count];
            for (int i = 0; i < Operation.userCustomList.Count; i++)
            {
                userArr[i] = Operation.userCustomList[i].UserID + "," + Operation.userCustomList[i].Name + "," + Operation.userCustomList[i].Age + "," + Operation.userCustomList[i].City + "," + Operation.userCustomList[i].Phonenumber + "," + Operation.userCustomList[i].WalletBalance;
            }
            File.WriteAllLines("MedicalStoreFileManagement/UserDetail.csv", userArr);

            string[] medicineArr = new string[Operation.medicineCustomList.Count];
            for (int i = 0; i < Operation.medicineCustomList.Count; i++)
            {
                medicineArr[i] = Operation.medicineCustomList[i].MedicineID + "," + Operation.medicineCustomList[i].MedicineName + "," + Operation.medicineCustomList[i].AvailableCount + "," + Operation.medicineCustomList[i].Price + "," + Operation.medicineCustomList[i].DateOfExpiry.ToString("dd/MM/yyyy");
            }
            File.WriteAllLines("MedicalStoreFileManagement/MedicineDetails.csv", medicineArr);

            string[] orderArr = new string[Operation.orderCustomList.Count];
            for (int i = 0; i < Operation.orderCustomList.Count; i++)
            {
                orderArr[i] = Operation.orderCustomList[i].OrderID + "," + Operation.orderCustomList[i].UserID + "," + Operation.orderCustomList[i].MedicineID + "," + Operation.orderCustomList[i].MedicineCount + "," + Operation.orderCustomList[i].TotalPrice + "," + Operation.orderCustomList[i].OrderDate.ToString("dd/MM/yyyy") + "," + Operation.orderCustomList[i].OrderStatus;
            }
            File.WriteAllLines("MedicalStoreFileManagement/OrderDetails.csv", orderArr);
        }

        /// <summary>
        /// ReadFromCSV method is used to read data from the csv file  <see cref="FileManagement"/>
        /// </summary>
        public static void ReadFromCSV()
        {
            string[] userArr = File.ReadAllLines("MedicalStoreFileManagement/UserDetail.csv");
            foreach (string line in userArr)
            {
                string[] str = line.Split(",");
                string userID = str[0];
                string name = str[1];
                int age = int.Parse(str[2]);
                string city = str[3];
                string phonenumber = str[4];
                int balance = int.Parse(str[5]);
                UserDetails user = new UserDetails(userID, age, city, phonenumber, balance);
                Operation.userCustomList.Add(user);
            }

            string[] medicineArr = File.ReadAllLines("MedicalStoreFileManagement/MedicineDetails.csv");
            foreach (string line in medicineArr)
            {
                MedicineDetails medicine = new MedicineDetails(line);
                Operation.medicineCustomList.Add(medicine);
            }

            string[] orderArr = File.ReadAllLines("MedicalStoreFileManagement/OrderDetails.csv");
            foreach (string line in orderArr)
            {
                OrderDetails medicine = new OrderDetails(line);
                Operation.orderCustomList.Add(medicine);
            }
        }
    }
}