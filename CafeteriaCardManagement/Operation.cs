using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace CafeteriaCardManagement
{
    /// <summary>
    /// Operation class is holdes all the static method that are used for application <see cref="Operation"/>
    /// </summary> 
    public static class Operation
    {
        /// <summary>
        /// userList is list which stores the object of UserDetails<see cref="Operation"/>
        /// </summary>
        static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        /// <summary>
        /// foodList is list which stores the object of FoodDetails<see cref="Operation00"/>
        /// </summary>
        static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();
        /// <summary>
        /// orderList is list which stores the object of OrderDetails<see cref="Operation"/>
        /// </summary>
        static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        /// <summary>
        /// globalCartList is list which stores the object of CartList<see cref="Operation"/>
        /// </summary>
        static CustomList<CartItem> globalCartList = new CustomList<CartItem>();
        /// <summary>
        /// CurrentLoginUser is a object for UserDetails which used to store the Current Logged in User object <see cref="Operation"/>
        /// </summary>
        static UserDetails CurrentLoginUser;
        /// <summary>
        /// MainMenu is a static method which used to show main menu to the user <see cref="Operation"/>
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine("-----Welcome To Sync Cafeteria-----");
            string mainChoice = "Yes";

            do
            {
                Console.WriteLine("1. User Registration\n2. User Login\n3. Exit");
                Console.WriteLine("select an option");
                int mainOption;
                bool tempMainOption = int.TryParse(Console.ReadLine(), out mainOption);
                while (!tempMainOption)
                {
                    Console.WriteLine("Please enter valid input");
                    tempMainOption = int.TryParse(Console.ReadLine(), out mainOption);
                }
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
                            Console.WriteLine("------User Login-----");
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            mainChoice = "no";
                            Console.WriteLine("-----Thank You-----");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please Enter valid number");
                            break;
                        }
                }
            } while (mainChoice == "Yes");
        }
        /// <summary>
        /// UserRegistration is a static method which used to get user details and create an object for user and store it in Userlist <see cref="Operation"/>
        /// </summary>
        public static void UserRegistration()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Fathers name");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number");
            string mobile = Console.ReadLine();
            Console.WriteLine("Enter your Mail Id");
            string mailID = Console.ReadLine();
            Console.WriteLine("Enter your Gender {Male, Female, Transgender}");
            Gender gender;
            bool tempGender = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
            while (!tempGender)
            {
                Console.WriteLine("Please enter valid input");
                tempGender = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
            }
            Console.WriteLine("Enter your Work Station id");
            string workStationNumber = Console.ReadLine();
            Console.WriteLine("Enter your Balance ");
            int balance;
            bool tempBalance = int.TryParse(Console.ReadLine(), out balance);
            while (!tempBalance)
            {
                Console.WriteLine("Please enter valid input");
                tempBalance = int.TryParse(Console.ReadLine(), out balance);
            }
            UserDetails user = new UserDetails(name, fatherName, mobile, mailID, gender, workStationNumber, balance);
            Console.WriteLine($"Your User ID is {user.UserID}");
            userList.Add(user);
        }
        /// <summary>
        /// UserLogin is a static method which used to verify the user id and store the user object in currentloginuser  <see cref="Operation"/>
        /// </summary>
        public static void UserLogin()
        {
            Console.WriteLine("Enter your User ID");
            string userID = Console.ReadLine().ToUpper();
            int count = 0;
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].UserID.Equals(userID))
                {
                    count++;
                    CurrentLoginUser = userList[i];
                    SubMenu();
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Enter the valid User ID");
            }
        }
        /// <summary>
        /// SubMenu is a static method which used to show Sub menu to the user <see cref="Operation"/>
        /// </summary>
        public static void SubMenu()
        {
            Console.WriteLine("-----Sub Menu-----");
            string subChoice = "yes";
            do
            {
                Console.WriteLine("1. Show My Profile\n2. Food Order\n3. Modify Order\n4. Cancel Order\n5. Order History\n6. Wallet Recharge\n7. Show WalletBalance\n8. Exit");
                Console.WriteLine("Select an option");
                int subOption;
                bool tempSubOption = int.TryParse(Console.ReadLine(), out subOption);
                while (!tempSubOption)
                {
                    Console.WriteLine("Please enter valid input");
                    tempSubOption = int.TryParse(Console.ReadLine(), out subOption);
                }
                switch (subOption)
                {
                    case 1:
                        {
                            Console.WriteLine("-----Show My Profile-----");
                            ShowMyProfile();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("-----Food Order-----");
                            FoodOrder();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("-----Modify Order-----");
                            ModifyOrder();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("-----Cancel Order-----");
                            CancelOrder();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("-----Order History-----");
                            OrderHistory();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("-----Wallet Recharge-----");
                            WalletRecharge();
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
                            Console.WriteLine("-----Exiting Sub Menu-----");
                            subChoice = "no";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter a valid input");
                            break;
                        }
                }
            } while (subChoice == "yes");
        }
        /// <summary>
        /// ShowMyProfile is a static method which used to show users Profile to the user <see cref="Operation"/>
        /// </summary>
        public static void ShowMyProfile()
        {
            Console.WriteLine($"Your Name: {CurrentLoginUser.Name}\nYour Father Name: {CurrentLoginUser.FatherName}\nYour Gender: {CurrentLoginUser.Gender}\nYour Mobile: {CurrentLoginUser.Mobile}\nYour MailID: {CurrentLoginUser.MailID}");
        }
        /// <summary>
        /// FoodOrder is a static method which used to take order from the user <see cref="Operation"/>
        /// </summary>
        public static void FoodOrder()
        {
            Console.WriteLine($"|{"FoodID",-10}|{"FoodName",-12}|{"FoodPrice",-13}|{"AvailableQuantity",-17}|");
            for (int i = 0; i < foodList.Count; i++)
            {
                Console.WriteLine($"|{foodList[i].FoodID,-10}|{foodList[i].FoodName,-12}|{foodList[i].FoodPrice,-13}|{foodList[i].AvailableQuantity,-17}|");
            }
            CustomList<CartItem> localCartList = new CustomList<CartItem>();
            OrderDetails order = new OrderDetails(CurrentLoginUser.UserID, DateTime.Now, 0, OrderStatus.Initiated);
            Console.WriteLine("Enter the Food ID you like to order");
            string orderOption = "";
            int totalamount = 0;
            do
            {
                Console.WriteLine("Enter the Food ID you like to order");
                string currentFoodID = Console.ReadLine().ToUpper();
                int temp = 0;
                for (int i = 0; i < foodList.Count; i++)
                {
                    if (foodList[i].FoodID.Equals(currentFoodID))
                    {
                        temp++;
                        Console.WriteLine("Enter the quantity");
                        int currentQuentity = int.Parse(Console.ReadLine());
                        int currentFoodAmount = 0;
                        if (foodList[i].AvailableQuantity >= currentQuentity)
                        {
                            for (int j = 0; j < foodList.Count; j++)
                            {
                                if (foodList[j].FoodID.Equals(currentFoodID))
                                {
                                    foodList[j].AvailableQuantity -= currentQuentity;
                                    currentFoodAmount = foodList[j].FoodPrice;
                                }
                            }
                            CartItem cart = new CartItem(order.OrderID, currentFoodID, currentFoodAmount * currentQuentity, currentQuentity);
                            totalamount = (currentFoodAmount * currentQuentity) + totalamount;
                            localCartList.Add(cart);
                        }
                        else
                        {
                            Console.WriteLine("Out of stock");
                        }
                    }
                }
                if (temp == 0)
                {
                    Console.WriteLine("Enter the Valid Food ID");
                }
                Console.WriteLine("do you want to continue ordering? ->yes or no");
                orderOption = Console.ReadLine().ToLower();
            } while (orderOption == "yes");
            Console.WriteLine($"your total amount of the order :{totalamount}");
            string purchaseOption = "";
            do
            {
                Console.WriteLine("Do you want to purchase ? ->yes or no");
                purchaseOption = Console.ReadLine().ToLower();
                if (purchaseOption == "yes")
                {
                    break;
                }
                else if (purchaseOption == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter valid input");
                }

            } while (true);
            if (purchaseOption == "yes")
            {
                do
                {
                    if (totalamount <= CurrentLoginUser.WalletBalance)
                    {
                        CurrentLoginUser.DeductAmount(totalamount);
                        globalCartList.AddRange(localCartList);
                        order.OrderStatus = OrderStatus.Ordered;
                        order.TotalPrice = totalamount;
                        orderList.Add(order);
                        Console.WriteLine($"order has been placed successfully your order id {order.OrderID}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("insufficent balance");
                        string reachoption = "";
                        do
                        {
                            Console.WriteLine("Are you willing to recharge? -> yes or no");
                            reachoption = Console.ReadLine().ToLower();
                            if (reachoption == "yes")
                            {
                                break;
                            }
                            else if (reachoption == "no")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("please enter valid input");
                            }

                        } while (true);
                        if (reachoption == "yes")
                        {
                            Console.WriteLine("enter the amount");
                            int reAmount = int.Parse(Console.ReadLine());
                            bool tempReAmount = int.TryParse(Console.ReadLine(), out reAmount);
                            while (!tempReAmount)
                            {
                                Console.WriteLine("Please enter valid input");
                                tempReAmount = int.TryParse(Console.ReadLine(), out reAmount);
                            }
                            CurrentLoginUser.WalletRecharge(reAmount);
                        }
                        else
                        {
                            Console.WriteLine("Exiting without Order due to insufficient balance");
                            for (int j = 0; j < localCartList.Count; j++)
                            {
                                for (int k = 0; k < foodList.Count; k++)
                                {
                                    if (localCartList[j].FoodID.Equals(foodList[k].FoodID))
                                    {
                                        foodList[k].AvailableQuantity += localCartList[j].OrderQuantity;
                                    }
                                }
                            }
                            break;
                        }
                    }
                } while (true);
            }
            else
            {
                Console.WriteLine("exiting food order");
                for (int j = 0; j < localCartList.Count; j++)
                {
                    for (int k = 0; k < foodList.Count; k++)
                    {
                        if (localCartList[j].FoodID.Equals(foodList[k].FoodID))
                        {
                            foodList[k].AvailableQuantity += localCartList[j].OrderQuantity;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// ModifyOrder is a static method which used to Modify the user Order <see cref="Operation">
        /// </summary>
        public static void ModifyOrder()
        {
            int temp = 0;

            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList[i].UserID.Equals(CurrentLoginUser.UserID))
                {
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("You have not placed any order");
            }
            else
            {
                Console.WriteLine($"|{"Order ID",-8}|{"User ID",-8}|{"Order Date",-11}|{"Total Price",-12}|{"Order Status",-13}|");
                for (int i = 0; i < orderList.Count; i++)
                {
                    if (orderList[i].UserID.Equals(CurrentLoginUser.UserID) && orderList[i].OrderStatus.Equals(OrderStatus.Ordered))
                    {
                        Console.WriteLine($"|{orderList[i].OrderID,-8}|{orderList[i].UserID,-8}|{orderList[i].OrderDate.ToString("dd/MM/yyyy"),-11}|{orderList[i].TotalPrice,-12}|{orderList[i].OrderStatus,-13}|");
                    }
                }
                Console.WriteLine("select an order by Order ID");
                string modifyOrderID = Console.ReadLine().ToUpper();
                int orderTemp = 0;
                for (int i = 0; i < orderList.Count; i++)
                {
                    if (modifyOrderID.Equals(orderList[i].OrderID))
                    {
                        orderTemp++;
                        Console.WriteLine($"|{"Item ID",-8}|{"Order ID",-9}|{"Food ID",-8}|{"Order Price",-11}|{"Order Quantity",-15}|");
                        for (int j = 0; j < globalCartList.Count; j++)
                        {
                            if (modifyOrderID.Equals(globalCartList[j].OrderID))
                            {
                                Console.WriteLine($"|{globalCartList[j].ItemID,-8}|{globalCartList[j].OrderID,-9}|{globalCartList[j].FoodID,-8}|{globalCartList[j].OrderPrice,-11}|{globalCartList[j].OrderQuantity,-15}|");
                            }
                        }
                        Console.WriteLine("Select food to modify by Item Number");
                        string modifyItemID = Console.ReadLine().ToUpper();
                        int itemTemp = 0;
                        for (int j = 0; j < globalCartList.Count; j++)
                        {
                            if (modifyItemID.Equals(globalCartList[j].ItemID) && modifyOrderID.Equals(globalCartList[j].OrderID))
                            {
                                itemTemp++;
                                Console.WriteLine("Enter new quantity of the food");
                                int newQuandity = int.Parse(Console.ReadLine());
                                //need to check quandity avilable
                                for (int k = 0; k < foodList.Count; k++)
                                {
                                    if (foodList[k].FoodID.Equals(globalCartList[j].FoodID))
                                    {
                                        if (foodList[k].AvailableQuantity >= newQuandity)
                                        {
                                            globalCartList[j].OrderPrice = foodList[k].FoodPrice * newQuandity;
                                            if (globalCartList[j].OrderQuantity > newQuandity)
                                            {
                                                int aQuantity = globalCartList[j].OrderQuantity - newQuandity;
                                                foodList[k].AvailableQuantity = foodList[k].AvailableQuantity + aQuantity;
                                            }
                                            else
                                            {
                                                foodList[k].AvailableQuantity = foodList[k].AvailableQuantity + newQuandity;
                                            }
                                            globalCartList[j].OrderQuantity = newQuandity;
                                            Console.WriteLine("Order modified succesfuly");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Out of stack");
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                        int newTotal = 0;
                        for (int j = 0; j < globalCartList.Count; j++)
                        {
                            if (globalCartList[j].OrderID.Equals(modifyOrderID))
                            {
                                newTotal = newTotal + globalCartList[j].OrderPrice;
                            }
                        }
                        CurrentLoginUser.DeductAmount(newTotal - orderList[i].TotalPrice);
                        orderList[i].TotalPrice = newTotal;
                        break;
                    }
                }

                if (orderTemp == 0)
                {
                    Console.WriteLine("invalid order ID");
                }
            }
        }
        /// <summary>
        /// CancelOrder is a static method which used to Cancel an Order that the user placed <see cref="Operation"/>
        /// </summary>
        public static void CancelOrder()
        {
            int temp = 0;
            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList[i].UserID.Equals(CurrentLoginUser.UserID) && orderList[i].OrderStatus.Equals(OrderStatus.Ordered))
                {
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("You have not placed any order or you canceled all the order");
                return;
            }
            else
            {
                Console.WriteLine($"|{"Order ID",-8}|{"User ID",-8}|{"Order Date",-11}|{"Total Price",-7}|{"Order Status",-13}|");
                for (int i = 0; i < orderList.Count; i++)
                {
                    if (orderList[i].UserID.Equals(CurrentLoginUser.UserID) && orderList[i].OrderStatus.Equals(OrderStatus.Ordered))
                    {
                        Console.WriteLine($"|{orderList[i].OrderID,-8}|{orderList[i].UserID,-8}|{orderList[i].OrderDate.ToString("dd/MM/yyyy"),-11}|{orderList[i].TotalPrice,-7}|{orderList[i].OrderStatus,-13}|");
                    }
                }
                Console.WriteLine("Enter your Order ID ");
                string tempOrderID = Console.ReadLine().ToUpper();
                int tempValid = 0;
                for (int i = 0; i < orderList.Count; i++)
                {
                    if (orderList[i].OrderStatus.Equals(OrderStatus.Ordered) && orderList[i].OrderID.Equals(tempOrderID))
                    {
                        tempValid++;
                        //need to return quandity of food in fooddetails
                        for (int j = 0; j < globalCartList.Count; j++)
                        {
                            for (int k = 0; k < foodList.Count; k++)
                            {
                                if (globalCartList[j].FoodID.Equals(foodList[k].FoodID) && orderList[i].OrderID.Equals(globalCartList[j].OrderID))
                                {
                                    foodList[k].AvailableQuantity += globalCartList[j].OrderQuantity;
                                }
                            }
                        }
                        Console.WriteLine("order has been canceled");
                        CurrentLoginUser._balance += orderList[i].TotalPrice;
                        orderList[i].OrderStatus = OrderStatus.Cancelled;
                        break;
                    }
                }
                if (tempValid == 0)
                {
                    Console.WriteLine("invalid order id");
                }
            }
        }
        /// <summary>
        /// OrderHistory is a static method which used to show Order History of the user <see cref="Operation"/>
        /// </summary>
        public static void OrderHistory()
        {
            int temp = 0;
            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList[i].UserID.Equals(CurrentLoginUser.UserID))
                {
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("You have not placed any order");
            }
            else
            {
                Console.WriteLine($"|{"Order ID",-9}|{"User ID",-8}|{"Order Date",-11}|{"Total Price",-12}|{"Order Status",-13}|");
                for (int i = 0; i < orderList.Count; i++)
                {
                    if (orderList[i].UserID.Equals(CurrentLoginUser.UserID))
                    {
                        Console.WriteLine($"|{orderList[i].OrderID,-9}|{orderList[i].UserID,-8}|{orderList[i].OrderDate.ToString("dd/MM/yyyy"),-11}|{orderList[i].TotalPrice,-12}|{orderList[i].OrderStatus,-13}|");
                    }
                }
            }

        }
        /// <summary>
        /// WalletRecharge is a static method which used to Recharge the user balance <see cref="Operation"/>
        /// </summary>
        public static void WalletRecharge()
        {
            Console.WriteLine("Do you want to recharge your wollet ? ->yes or no");
            string walletOption = Console.ReadLine().ToLower();
            if (walletOption.Equals("yes"))
            {
                Console.WriteLine("enter the amount");
                int amount;
                bool tempAmount = int.TryParse(Console.ReadLine(), out amount);
                while (!tempAmount)
                {
                    Console.WriteLine("Please enter valid input");
                    tempAmount = int.TryParse(Console.ReadLine(), out amount);
                }
                if (amount > 0)
                {
                    CurrentLoginUser.WalletRecharge(amount);
                    Console.WriteLine($"amount has been recharged your current balance {CurrentLoginUser.WalletBalance}");
                }
                else
                {
                    Console.WriteLine($"you can't able to recharge {amount} amounnt");
                }
            }
            else
            {
                Console.WriteLine("enter valid input");
            }
        }
        /// <summary>
        /// ShowWalletBalance is a static method which used to show WalletBalance of the user <see cref="Operation"/>
        /// </summary>
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"Your Wallet balance :{CurrentLoginUser.WalletBalance}");
        }
        /// <summary>
        /// AddDetails is a static method which used to add deafult Details to the lists <see cref="Operation"/>
        /// </summary>
        public static void AddDetails()
        {
            UserDetails user1 = new UserDetails("Ravichandran", "Ettapparajan", "8857777575", "ravi@gmail.com", Gender.Male, "WS101", 400);
            userList.Add(user1);
            UserDetails user2 = new UserDetails("Baskaran", "Sethurajan", "9577747744", "baskaran@gmail.com", Gender.Male, "WS105", 500);
            userList.Add(user2);

            FoodDetails food1 = new FoodDetails("Coffee", 20, 100);
            foodList.Add(food1);
            FoodDetails food2 = new FoodDetails("Tea", 15, 100);
            foodList.Add(food2);
            FoodDetails food3 = new FoodDetails("Biscuit", 10, 100);
            foodList.Add(food3);
            FoodDetails food4 = new FoodDetails("Juice", 50, 100);
            foodList.Add(food4);
            FoodDetails food5 = new FoodDetails("Puff", 40, 100);
            foodList.Add(food5);
            FoodDetails food6 = new FoodDetails("Milk", 10, 100);
            foodList.Add(food6);
            FoodDetails food7 = new FoodDetails("Popcorn", 20, 20);
            foodList.Add(food7);

            OrderDetails order1 = new OrderDetails("SF1001", DateTime.Now, 70, OrderStatus.Ordered);
            orderList.Add(order1);
            OrderDetails order2 = new OrderDetails("SF1002", DateTime.Now, 100, OrderStatus.Ordered);
            orderList.Add(order2);

            CartItem cartItem1 = new CartItem("OID1001", "FID101", 20, 1);
            CartItem cartItem2 = new CartItem("OID1001", "FID103", 10, 1);
            CartItem cartItem3 = new CartItem("OID1001", "FID105", 40, 1);
            CartItem cartItem4 = new CartItem("OID1002", "FID103", 10, 1);
            CartItem cartItem5 = new CartItem("OID1002", "FID104", 50, 1);
            CartItem cartItem6 = new CartItem("OID1002", "FID105", 40, 1);
            globalCartList.Add(cartItem1);
            globalCartList.Add(cartItem2);
            globalCartList.Add(cartItem3);
            globalCartList.Add(cartItem4);
            globalCartList.Add(cartItem5);
            globalCartList.Add(cartItem6);
        }
    }
}