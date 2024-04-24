using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public static class Operation
    {
        //static List<UserDetails> userList = new List<UserDetails>();
        /// <summary>
        /// userCustomList is used to store UserDetails objects<see cref="Operation"/>
        /// </summary> 
        public static CustomeList<UserDetails> userCustomList = new CustomeList<UserDetails>();
        //static List<MedicineDetails> medicineList = new List<MedicineDetails>();
        /// <summary>
        /// medicineCustomList is used to store UserDetails MedicineDetails<see cref="Operation"/>
        /// </summary> 
        public static List<MedicineDetails> medicineCustomList = new List<MedicineDetails>();
        //static List<OrderDetails> orderList = new List<OrderDetails>();
        /// <summary>
        /// orderCustomList is used to store OrderDetails objects<see cref="Operation"/>
        /// </summary> 
        public static List<OrderDetails> orderCustomList = new List<OrderDetails>();
        /// <summary>
        /// currentLoginUser is used to store the login users object<see cref="Operation"/>
        /// </summary> 
        static UserDetails currentLoginUser;
        /// <summary>
        /// MainMenu method is used to display main menu<see cref="Operation"/>
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine("-----welcome Online Medical Store-----");
            string mainChoice = "yes";
            do
            {
                Console.WriteLine("1. User Registration\n2. User Login\n3. Exit");
                int mainOption = int.Parse(Console.ReadLine());
                switch (mainOption)
                {
                    case 1:
                        {
                            Console.WriteLine("-----User Registration-----");
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("-----User Login-----");
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("-----Exit-----");
                            mainChoice = "no";
                            break;
                        }
                }
            } while (mainChoice == "yes");

        }
        /// <summary>
        /// UserRegistration method is used for registering user details <see cref="Operation"/>
        /// </summary>
        public static void UserRegistration()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your City name");
            string city = Console.ReadLine();
            Console.WriteLine("enter your phone number");
            string phone = Console.ReadLine();
            Console.WriteLine("enter your Balance");
            int balance = int.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(name, age, city, phone, balance);
            userCustomList.Add(user);
            Console.WriteLine($"registration completed your ID {user.UserID}");
        }
        /// <summary>
        /// UserLogin method is used to verify the user id and calls submenu function <see cref="Operation"/>
        /// </summary>
        public static void UserLogin()
        {
            Console.WriteLine("Enter your User ID");
            string inputID = Console.ReadLine().ToUpper();
            bool loginFlage = true;
            foreach (UserDetails user in userCustomList)
            {
                if (user.UserID.Equals(inputID))
                {
                    loginFlage = false;
                    currentLoginUser = user;
                    SUbMenu();
                    break;
                }
            }
            if (loginFlage)
            {
                Console.WriteLine("invalid user ID");
            }
        }
        /// <summary>
        /// SUbMenu method is used to display SUb menu<see cref="Operation"/>
        /// </summary>
        public static void SUbMenu()
        {
            Console.WriteLine("-----Sub Menu-----");
            string subChoice = "yes";
            do
            {
                Console.WriteLine("1. Show medicine list.\n2. Purchase medicine.\n3. Modify purchase.\n4. Cancel purchase.\n5. Show purchase history.\n6. Recharge Wallet.\n7. Show Wallet Balance\n8. Exit");
                Console.WriteLine("Select an option");
                int subOption = int.Parse(Console.ReadLine());
                switch (subOption)
                {
                    case 1:
                        {
                            Console.WriteLine("-----Show medicine list-----");
                            ShowMedicineList();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("-----Purchase medicine-----");
                            PurchaseMedicine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("-----Modify purchase-----");
                            ModifyPurchase();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("-----Cancel purchase-----");
                            CancelPurchase();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("-----Show purchase history-----");
                            ShowPurchaseHistory();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("-----Recharge Wallet-----");
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("-----Show Wallet Balance-----");
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("-----Exit sub menu-----");
                            subChoice = "no";
                            break;
                        }
                }
            } while (subChoice == "yes");
        }
        /// <summary>
        /// ShowMedicineList method is used to display medicine List <see cref="Operation"/>
        /// </summary> 
        public static void ShowMedicineList()
        {
            Console.WriteLine($"|{"MedicineID",-15}|{"MedicineName",-15}|{"AvailableCount",-15}|{"Price",-15}|{"DateOfExpiry",-15}|");
            foreach (MedicineDetails medicine in medicineCustomList)
            {
                Console.WriteLine($"|{medicine.MedicineID,-15}|{medicine.MedicineName,-15}|{medicine.AvailableCount,-15}|{medicine.Price,-15}|{medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-15}|");
            }
        }
        /// <summary>
        /// PurchaseMedicine method is used for purchase medicine <see cref="Operation"/>
        /// </summary>
        public static void PurchaseMedicine()
        {
            ShowMedicineList();
            Console.WriteLine("Enter the medicine ID");
            string inputMedicineID = Console.ReadLine().ToUpper();
            Console.WriteLine("enter count you need");
            int inputCount = int.Parse(Console.ReadLine());
            bool medicineFlage = true;
            foreach (MedicineDetails medicine in medicineCustomList)
            {
                if (medicine.MedicineID.Equals(inputMedicineID) && medicine.AvailableCount > inputCount && medicine.DateOfExpiry > DateTime.Now)
                {
                    medicineFlage = false;
                    int amount = inputCount * medicine.Price;
                    if (currentLoginUser.WalletBalance > amount)
                    {
                        medicine.AvailableCount = medicine.AvailableCount-inputCount;
                        currentLoginUser.DeductBalance(amount);
                        OrderDetails order = new OrderDetails(currentLoginUser.UserID, medicine.MedicineID, inputCount, amount, DateTime.Now, OrderStatus.Purchased);
                        orderCustomList.Add(order);
                        Console.WriteLine($"order placed successfully{order.OrderID}");
                    }
                    else
                    {
                        Console.WriteLine("insufficent balance");
                    }
                }
            }
            if (medicineFlage)
            {
                Console.WriteLine("Medicine is not available");
            }
        }
        /// <summary>
        /// CancelPurchase method is used to Cancel Purchase<see cref="Operation"/>
        /// </summary>
        public static void CancelPurchase()
        {
            int temp = 0;
            foreach (OrderDetails order in orderCustomList)
            {
                if (order.UserID.Equals(currentLoginUser.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    temp++;
                }

            }
            if (temp == 0)
            {
                Console.WriteLine("you have't purchased or you canceld all product");
            }
            else
            {
                Console.WriteLine($"|{"OrderID",-10}|{"UserID",-10}|{"MedicineID",-10}|{"MedicineCount",-15}|{"TotalPrice",-15}|{"OrderDate",-15}|{"OrderStatus",-15}|");
                foreach (OrderDetails order in orderCustomList)
                {
                    if (order.UserID.Equals(currentLoginUser.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                    {
                        Console.WriteLine($"|{order.OrderID,-10}|{order.UserID,-10}|{order.MedicineID,-10}|{order.MedicineCount,-15}|{order.TotalPrice,-15}|{order.OrderDate.ToString("dd/MM/yyyy"),-15}|{order.OrderStatus,-15}|");
                    }

                }
                Console.WriteLine("select an order by its order ID");
                string inputOrderID = Console.ReadLine().ToUpper();
                bool tempOrder = true;
                foreach (OrderDetails order in orderCustomList)
                {
                    if (order.OrderID.Equals(inputOrderID))
                    {
                        tempOrder = false;
                        currentLoginUser.WalletRecharge(order.TotalPrice);
                        order.OrderStatus = OrderStatus.Cancelled;
                        foreach (MedicineDetails medicine in medicineCustomList)
                        {
                            if (medicine.MedicineID.Equals(order.MedicineID))
                            {
                                medicine.AvailableCount += order.MedicineCount;
                            }
                        }
                        Console.WriteLine($"{order.OrderID} was cancelled successfully");
                    }
                }
                if (tempOrder)
                {
                    Console.WriteLine("invalid order ID");
                }
            }
        }
        /// <summary>
        /// ModifyPurchase method is used to Modify Purchase<see cref="Operation"/> 
        /// </summary> 
        public static void ModifyPurchase()
        {
            int temp = 0;
            foreach (OrderDetails order in orderCustomList)
            {
                if (order.UserID.Equals(currentLoginUser.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    temp++;
                }

            }
            if (temp == 0)
            {
                Console.WriteLine("you have't purchased any thing or you cancel the product");
            }
            else
            {
                Console.WriteLine($"|{"OrderID",-10}|{"UserID",-10}|{"MedicineID",-10}|{"MedicineCount",-15}|{"TotalPrice",-15}|{"OrderDate",-15}|{"OrderStatus",-15}|");
                foreach (OrderDetails order in orderCustomList)
                {
                    if (order.UserID.Equals(currentLoginUser.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                    {
                        Console.WriteLine($"|{order.OrderID,-10}|{order.UserID,-10}|{order.MedicineID,-10}|{order.MedicineCount,-15}|{order.TotalPrice,-15}|{order.OrderDate.ToString("dd/MM/yyyy"),-15}|{order.OrderStatus,-15}|");
                    }

                }
                Console.WriteLine("select an order by its order ID");
                string inputOrderID = Console.ReadLine().ToUpper();
                bool tempOrder = true;
                foreach (OrderDetails order in orderCustomList)
                {
                    if (order.OrderID.Equals(inputOrderID))
                    {
                        tempOrder = false;
                        Console.WriteLine("enter the new quantity of the medicine");
                        int newQuendity = int.Parse(Console.ReadLine());
                        int newPrice = 0;
                        foreach (MedicineDetails medicine in medicineCustomList)
                        {
                            if (order.MedicineID.Equals(medicine.MedicineID))
                            {
                                newPrice = medicine.Price * newQuendity;
                                break;
                            }
                        }
                        order.TotalPrice = newPrice;
                        order.MedicineCount = newQuendity;
                    }
                }
                if (tempOrder)
                {
                    Console.WriteLine("invalid order ID");
                }
            }
        }
        /// <summary>
        /// ShowPurchaseHistory method is used to Show Purchase Historye of the user<see cref="Operation"/> 
        /// </summary>
        public static void ShowPurchaseHistory()
        {
            int temp = 0;
            foreach (OrderDetails order in orderCustomList)
            {
                if (order.UserID.Equals(currentLoginUser.UserID))
                {
                    temp++;
                }

            }
            if (temp == 0)
            {
                Console.WriteLine("you have't purchased any product");
            }
            else
            {
                Console.WriteLine($"|{"OrderID"}|{"UserID"}|{"MedicineID"}|{"MedicineCount"}|{"TotalPrice"}|{"OrderDate"}|{"OrderStatus"}|");
                foreach (OrderDetails order in orderCustomList)
                {
                    if (order.UserID.Equals(currentLoginUser.UserID))
                    {
                        Console.WriteLine($"|{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.OrderStatus}|");
                    }

                }
            }
        }
        /// <summary>
        /// RechargeWallet method is used to Recharge Wallet amount of the user<see cref="Operation"/>
        /// </summary>
        public static void RechargeWallet()
        {
            Console.WriteLine("enter the amount");
            int amount = int.Parse(Console.ReadLine());
            if(amount>0)
            {
                currentLoginUser.WalletRecharge(amount);
                Console.WriteLine($"amount has been recharged current balance{currentLoginUser.WalletBalance}");
            }
            else
            {
                Console.WriteLine($"you cant able to recharge {amount} amount");
            }
        }
        /// <summary>
        /// ShowWalletBalance method is used to Show Wallet Balance of the user<see cref="Operation"/>
        /// </summary>
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"your balance : {currentLoginUser.WalletBalance}");
        }
        /// <summary>
        /// AddData is used to add data to list <see cref="Operation"/>
        /// </summary>
        public static void AddData()
        {
            UserDetails user1 = new UserDetails("Ravi", 33, "Theni", "9877774440", 400);
            userCustomList.Add(user1);
            UserDetails user2 = new UserDetails("Baskaran", 33, "Chennai", "8847757470", 500);
            userCustomList.Add(user2);
            //userList.AddRange(new List<UserDetails> { user1, user2 });

            MedicineDetails medicine1 = new MedicineDetails("Paracitamol", 40, 5, new DateTime(2024, 06, 30));
            medicineCustomList.Add(medicine1);
            MedicineDetails medicine2 = new MedicineDetails("Calpol", 10, 5, new DateTime(2024, 05, 30));
            medicineCustomList.Add(medicine2);
            MedicineDetails medicine3 = new MedicineDetails("Gelucil", 3, 40, new DateTime(2023, 04, 30));
            medicineCustomList.Add(medicine3);
            MedicineDetails medicine4 = new MedicineDetails("Metrogel", 5, 50, new DateTime(2024, 12, 30));
            medicineCustomList.Add(medicine4);
            MedicineDetails medicine5 = new MedicineDetails("Povidin Iodin", 10, 50, new DateTime(2024, 10, 30));
            medicineCustomList.Add(medicine5);
            //medicineList.AddRange(new List<MedicineDetails> { medicine1, medicine2, medicine3, medicine4, medicine5 });

            OrderDetails order1 = new OrderDetails("UID100", "MD101", 3, 15, new DateTime(2022, 11, 13), OrderStatus.Purchased);
            orderCustomList.Add(order1);
            OrderDetails order2 = new OrderDetails("UID1001", "MD102", 2, 10, new DateTime(2022, 11, 13), OrderStatus.Cancelled);
            orderCustomList.Add(order2);
            OrderDetails order3 = new OrderDetails("UID1001", "MD104", 2, 100, new DateTime(2022, 11, 13), OrderStatus.Purchased);
            orderCustomList.Add(order3);
            OrderDetails order4 = new OrderDetails("UID1002", "MD103", 3, 120, new DateTime(2022, 11, 15), OrderStatus.Cancelled);
            orderCustomList.Add(order4);
            OrderDetails order5 = new OrderDetails("UID1002", "MD105", 5, 250, new DateTime(2022, 11, 15), OrderStatus.Purchased);
            orderCustomList.Add(order5);
            OrderDetails order6 = new OrderDetails("UID1002", "MD102", 3, 15, new DateTime(2022, 11, 15), OrderStatus.Purchased);
            orderCustomList.Add(order6);
            //orderList.AddRange(new List<OrderDetails> { order1, order2, order3, order4, order5, order6 });
        }
    }
}