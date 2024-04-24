using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace GroceryStore
{
    /// <summary>
    /// Operation class is used to performe operation bus using all other class <see cref="Operation"/>
    /// </summary>
    public static class Operation
    {
        //public static List<CustomerRegistration> customersList = new List<CustomerRegistration>();
        /// <summary>
        /// customersCustomList is a list usedd to store CustomerRegistration object <see cref="Operation"/> 
        /// </summary>
        public static CustomeList<CustomerRegistration> customersCustomList = new CustomeList<CustomerRegistration>();
        /// <summary>
        /// ProductCustomList is a list usedd to store ProductDetails object <see cref="Operation"/> 
        /// </summary>
        //public static List<ProductDetails> ProductList = new List<ProductDetails>();
        public static CustomeList<ProductDetails> ProductCustomList = new CustomeList<ProductDetails>();
        //public static List<BookingDetails> BookingList = new List<BookingDetails>();
        /// <summary>
        /// bookingCustomList is a list usedd to store BookingDetails object <see cref="Operation"/> 
        /// </summary>
        public static CustomeList<BookingDetails> bookingCustomList = new CustomeList<BookingDetails>();
        //public static List<OrderDetails> globelOrderList = new List<OrderDetails>();
        /// <summary>
        /// globelOrderCustomList is a list usedd to store OrderDetails object <see cref="Operation"/> 
        /// </summary>
        public static CustomeList<OrderDetails> globelOrderCustomList = new CustomeList<OrderDetails>();
        /// <summary>
        /// currentLoggedInuser is an CustomerRegistration object used to store current Logged In user object<see cref="Operation"/> 
        /// </summary>
        static CustomerRegistration currentLoggedInuser;
        /// <summary>
        /// MainMenu method is used to show main menu to the user<see cref="Operation"/> 
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine("-----Welcome to SyncFusion  Grocery Store-----");
            string mainFlage = "yes";
            do
            {
                Console.WriteLine("1. Customer Registration\n2. Customer Login\n3. Exit");
                Console.WriteLine("Select an option");
                int mainOption;
                bool mainTemp = int.TryParse(Console.ReadLine(), out mainOption);
                while (!mainTemp)
                {
                    Console.WriteLine("enter valid input");
                    mainTemp = int.TryParse(Console.ReadLine(), out mainOption);
                }
                switch (mainOption)
                {
                    case 1:
                        {
                            Console.WriteLine("-----Customer Registration-----");
                            CustomerRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("-----Customer Login-----");
                            CustomerLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("----Exiting-----");
                            mainFlage = "no";
                            break;
                        }
                }

            } while (mainFlage == "yes");
        }
        /// <summary>
        /// CustomerRegistration method is used to register new user and store the object in the list<see cref="Operation"/>
        /// </summary>
        public static void CustomerRegistration()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Fathers Name");
            string fatherName = Console.ReadLine();

            Console.WriteLine("Enter your Gender(male,female,others)");
            Gender gender;
            bool genderTemp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            while(!genderTemp)
            {
                Console.WriteLine("Enter a valid input");
                genderTemp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            }

            Console.WriteLine("Enter your Mobile number");
            string mobile = Console.ReadLine();

            Console.WriteLine("enter your DOB (dd/MM/yyyy)");
            DateTime dob;
            bool dobTemp = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out dob);
            while(!dobTemp)
            {
                Console.WriteLine("Enter a valid input");
                dobTemp = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out dob);
            }

            Console.WriteLine("Enter your MailID");
            string mailID = Console.ReadLine();

            Console.WriteLine("Enter your WalletBalance");
            int walletBalance;
            bool balanceTemp = int.TryParse(Console.ReadLine(),out walletBalance);
            while(!balanceTemp)
            {
                Console.WriteLine("enter a valid input");
                balanceTemp = int.TryParse(Console.ReadLine(),out walletBalance);
            }

            CustomerRegistration customer = new CustomerRegistration(walletBalance, name, fatherName, gender, mobile, dob, mailID);
            Console.WriteLine($"Your Customer ID : {customer.CustomerID}");
            customersCustomList.Add(customer);

        }
        /// <summary>
        /// CustomerLogin is used to verify the user's id and store it the current login user object<see cref="Operation"/>
        /// </summary>
        public static void CustomerLogin()
        {
            Console.WriteLine("Enter your Customer ID");
            string userIDinput = Console.ReadLine().ToUpper();
            int temp = 0;
            foreach (CustomerRegistration customer in customersCustomList)
            {
                if (customer.CustomerID.Equals(userIDinput))
                {
                    temp++;
                    currentLoggedInuser = customer;
                    SubMenu();
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Invalid ID");
            }
        }
        /// <summary>
        /// SubMenu method is used to show Sub Menu to the user <see cref="Operation"/>
        /// </summary>
        public static void SubMenu()
        {
            Console.WriteLine("-----Sub Menu-----");
            string subFlag = "yes";
            do
            {
                Console.WriteLine("1) Show Customer Details\n2) Show Product Details\n3) Wallet Recharge\n4) Take Order\n5) Modify Order Quantity\n6) Cancel Order\n7) Show Balance\n8) Exit");
                Console.WriteLine("Select an option");
                int subOption;
                bool subTemp = int.TryParse(Console.ReadLine(),out subOption);
                while(!subTemp)
                {
                    Console.WriteLine("enter valid input");
                    subTemp = int.TryParse(Console.ReadLine(),out subOption);
                }
                switch (subOption)
                {
                    case 1:
                        {
                            Console.WriteLine("-----Show Customer Details-----");
                            ShowCustomerDetails();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("-----Show Product Details-----");
                            ShowProductDetails();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("-----Wallet Recharge-----");
                            WalletRecharge();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("-----Take Order-----");
                            TakeOrder();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("-----Modify Order Quantity-----");
                            ModifyOrderQuantity();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("-----Cancel Order-----");
                            CancelOrder();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("-----Show Balance-----");
                            ShowBalance();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("-----Exit Sub menu-----");
                            subFlag = "no";
                            break;
                        }
                }
            } while (subFlag == "yes");
        }
        /// <summary>
        /// ShowCustomerDetails method is used to show the customers details <see cref="Operation"/>
        /// </summary>
        public static void ShowCustomerDetails()
        {
            Console.WriteLine("Your name : " + currentLoggedInuser.Name);
            Console.WriteLine("Your Fathername : " + currentLoggedInuser.FathersName);
            Console.WriteLine("Your DOB : " + currentLoggedInuser.DOB.ToString("dd/MM/yyyy"));
            Console.WriteLine("Your Gender : " + currentLoggedInuser.Gender);
            Console.WriteLine("Your MailID : " + currentLoggedInuser.MailID);
            Console.WriteLine("Your mobile number : " + currentLoggedInuser.Mobile);
            Console.WriteLine("Your Wallet Balance : " + currentLoggedInuser.WalletBalance);
        }
        /// <summary>
        /// ShowProductDetails method is used to show the product list to the user <see cref="Operation"/>
        /// </summary>
        public static void ShowProductDetails()
        {
            ProductDetails.ShowProductDetails();
        }
        /// <summary>
        /// WalletRecharge is used to recharcge users Wallet balance <see cref="Operation"/>
        /// </summary>
        public static void WalletRecharge()
        {
            Console.WriteLine("Enter the amount");
            int amount;
            bool amountTemp = int.TryParse(Console.ReadLine(),out amount);
            while(!amountTemp)
            {
                Console.WriteLine("enter valid input");
                amountTemp = int.TryParse(Console.ReadLine(),out amount);
            }
            if (amount > 0)
            {
                currentLoggedInuser.WalletRecharge(amount);
                Console.WriteLine("amount has been reacharged");
            }
            else
            {
                Console.WriteLine($"You cant able to recharge {amount} amount");
            }
        }
        /// <summary>
        /// TakeOrder methods allows the user to select a product and place an order <see cref="Operation"/>
        /// </summary>
        public static void TakeOrder()
        {
            Console.WriteLine("Do you want to place an order? yes or no");
            string useWish = Console.ReadLine().ToLower();
            CustomeList<OrderDetails> tempOrderList = new CustomeList<OrderDetails>();
            BookingDetails booking = new BookingDetails(currentLoggedInuser.CustomerID, 0, DateTime.Now, BookingStatus.Initiated);
            int Totalamount = 0;
            while (useWish == "yes")
            {

                ShowProductDetails();
                Console.WriteLine("Select the product by its product ID");
                string userProductID = Console.ReadLine().ToUpper();
                bool productFlage = true;
                foreach (ProductDetails product in ProductCustomList)
                {
                    if (product.ProductID.Equals(userProductID))
                    {
                        Console.WriteLine("enter the quantity you needed");
                        int userQuantity;
                        bool quandityTemp = int.TryParse(Console.ReadLine(),out userQuantity);
                        while(!quandityTemp)
                        {
                            Console.WriteLine("Enter a valid input");
                            quandityTemp = int.TryParse(Console.ReadLine(),out userQuantity);
                        }
                        if (product.QuantityAvailable > userQuantity)
                        {
                            product.QuantityAvailable -= userQuantity;
                            int price = userQuantity * product.PricePerQuantity;
                            Totalamount = Totalamount + price;
                            OrderDetails order = new OrderDetails(booking.BookingID, userProductID, userQuantity, price);
                            tempOrderList.Add(order);
                            Console.WriteLine("Product successfully added to cart");
                        }
                        else
                        {
                            Console.WriteLine("out of stack");
                        }
                        productFlage = false;
                        break;
                    }
                }
                if (productFlage)
                {
                    Console.WriteLine("enter valid id");
                }
                Console.WriteLine($"total amount {Totalamount}");
                Console.WriteLine("do you want to continue shopping? yes or no");
                useWish = Console.ReadLine().ToLower();
            }
            Console.WriteLine("do you want to book the order? yes or no");
            string bookWish = Console.ReadLine().ToLower();
            if (bookWish == "yes")
            {
                do
                {
                    if (Totalamount < currentLoggedInuser.WalletBalance)
                    {
                        currentLoggedInuser.WalletBalance -= Totalamount;
                        booking.BookingStatus = BookingStatus.Booked;
                        booking.TotalPrice = Totalamount;
                        globelOrderCustomList.AddRange(tempOrderList);
                        bookingCustomList.Add(booking);
                        Console.WriteLine("booking successful");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("insufficent balance do you want to recharge ? yes or no");
                        string rechargeWish = Console.ReadLine().ToLower();
                        if (rechargeWish == "yes")
                        {
                            Console.WriteLine("enter the amount");
                            int reAmount = int.Parse(Console.ReadLine());
                            currentLoggedInuser.WalletRecharge(reAmount);
                        }
                        else
                        {
                            Console.WriteLine("exiting due to insufficent balance");
                            break;
                        }
                    }
                } while (true);
            }
            else
            {
                foreach (OrderDetails order in tempOrderList)
                {
                    foreach (ProductDetails product in ProductCustomList)
                    {
                        if (order.ProductID.Equals(product.ProductID))
                        {
                            product.QuantityAvailable += order.PurchaseCount;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// ModifyOrderQuantity method allows the user to modify the placed order <see cref="Operation"/>
        /// </summary>
        public static void ModifyOrderQuantity()
        {
            int temp = 0;
            foreach (BookingDetails booking in bookingCustomList)
            {
                if (booking.CustomerID.Equals(currentLoggedInuser.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked))
                {
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("you have not booked any thing");
            }
            else
            {
                Console.WriteLine($"|{"BookingID",-10}|{"CustomerID",-10}|{"TotalPrice",-11}|{"DateOfBooking",-15}|{"BookingStatus",-15}|");
                foreach (BookingDetails booking in bookingCustomList)
                {
                    if (booking.CustomerID.Equals(currentLoggedInuser.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked))
                    {
                        Console.WriteLine($"|{booking.BookingID,-10}|{booking.CustomerID,-10}|{booking.TotalPrice,-11}|{booking.DateOfBooking.ToString("dd/MM/yyyy"),-15}|{booking.BookingStatus,-15}|");
                    }
                }
                Console.WriteLine("select the booking by its id");
                string userbooking = Console.ReadLine().ToUpper();
                bool tempbool = true;
                foreach (BookingDetails booking in bookingCustomList)
                {
                    if (booking.BookingID.Equals(userbooking))
                    {
                        tempbool = false;
                        //showing order id
                        Console.WriteLine($"|{"OrderID",-10}|{"BookingID",-10}|{"ProductID",-10}|{"PurchaseCount",-15}|{"PriceOfOrder",-15}|");
                        foreach (OrderDetails order in globelOrderCustomList)
                        {
                            if (order.BookingID.Equals(booking.BookingID))
                            {
                                Console.WriteLine($"|{order.OrderID,-10}|{order.BookingID,-10}|{order.ProductID,-10}|{order.PurchaseCount,-15}|{order.PriceOfOrder,-15}|");
                            }
                        }
                        bool temporder = true;
                        Console.WriteLine("select the order ID");
                        string userorderID = Console.ReadLine().ToUpper();
                        foreach (OrderDetails order in globelOrderCustomList)
                        {
                            if (order.OrderID.Equals(userorderID))
                            {
                                temporder = false;
                                Console.WriteLine("enter new Quandity");
                                int newQuendity = int.Parse(Console.ReadLine());
                                bool newQueTemp = int.TryParse(Console.ReadLine(),out newQuendity);
                                while(!newQueTemp)
                                {
                                    Console.WriteLine("Enter valid input");
                                    newQueTemp = int.TryParse(Console.ReadLine(),out newQuendity);
                                }
                                int newAmount = 0;
                                foreach (ProductDetails product in ProductCustomList)
                                {
                                    if (order.ProductID.Equals(product.ProductID))
                                    {
                                        if (product.QuantityAvailable + order.PurchaseCount > newQuendity)
                                        {
                                            newAmount = newQuendity * product.PricePerQuantity;
                                            if (currentLoggedInuser.WalletBalance + order.PriceOfOrder > newAmount)
                                            {
                                                currentLoggedInuser.WalletBalance = currentLoggedInuser.WalletBalance + order.PriceOfOrder - newAmount;
                                                product.QuantityAvailable = product.QuantityAvailable + order.PurchaseCount - newQuendity;
                                                booking.TotalPrice = booking.TotalPrice - order.PriceOfOrder + newAmount;
                                                order.PurchaseCount = newQuendity;
                                                order.PriceOfOrder = newAmount;
                                                Console.WriteLine("order Modified Sucessfully");
                                            }
                                            else
                                            {
                                                Console.WriteLine("insufficent Balance");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("out of stock");
                                        }
                                        break;
                                    }
                                }

                            }
                        }
                        if (temporder)
                        {
                            Console.WriteLine("invalid order id");
                        }
                    }
                }
                if (tempbool)
                {
                    Console.WriteLine("innvalid booking id");
                }
            }
        }
        /// <summary>
        /// CancelOrder method alloes the user to cancel an order <see cref="Operation"/>
        /// </summary>
        public static void CancelOrder()
        {
            int temp = 0;
            foreach (BookingDetails booking in bookingCustomList)
            {
                if (currentLoggedInuser.CustomerID.Equals(booking.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked))
                {
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("you have no booking details that in booked state");
            }
            else
            {
                Console.WriteLine($"|{"BookingID",-10}|{"CustomerID",-10}|{"TotalPrice",-11}|{"DateOfBooking",-15}|{"BookingStatus",-15}|");
                foreach (BookingDetails booking in bookingCustomList)
                {
                    if (currentLoggedInuser.CustomerID.Equals(booking.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked))
                    {
                        Console.WriteLine($"|{booking.BookingID,-10}|{booking.CustomerID,-10}|{booking.TotalPrice,-11}|{booking.DateOfBooking.ToString("dd/MM/yyyy"),-15}|{booking.BookingStatus,-15}|");
                    }
                }
                Console.WriteLine("Select an booking id");
                string cancelID = Console.ReadLine().ToUpper();
                int count = 0;
                int refundAmount = 0;
                foreach (BookingDetails booking in bookingCustomList)
                {
                    if (booking.BookingID.Equals(cancelID))
                    {
                        refundAmount = booking.TotalPrice;
                        booking.BookingStatus = BookingStatus.Cancelled;
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Enter valid ID");
                }
                else
                {
                    Console.WriteLine("order canceled succesfully");
                    currentLoggedInuser.WalletRecharge(refundAmount);
                    foreach (OrderDetails order in globelOrderCustomList)
                    {
                        if (order.BookingID.Equals(cancelID))
                        {
                            foreach (ProductDetails product in ProductCustomList)
                            {
                                if (order.ProductID.Equals(product.ProductID))
                                {
                                    product.QuantityAvailable += order.PurchaseCount;
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// ShowBalance method is used to Show the Balance of the current user<see cref="Operation"/>
        /// </summary>
        public static void ShowBalance()
        {
            Console.WriteLine($"Your Balance {currentLoggedInuser.WalletBalance}");
        }
        /// <summary>
        /// AddDetails method is used to add defualt values<see cref="Operation"/>
        /// </summary>
        public static void AddDetails()
        {
            CustomerRegistration customer1 = new CustomerRegistration(10000, "Ravi", "Ettapparajan", Gender.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gmail.com");
            customersCustomList.Add(customer1);
            CustomerRegistration customer2 = new CustomerRegistration(15000, "Baskaran", "Sethurajan", Gender.Male, "847575775", new DateTime(1999, 11, 11), "baskaran@gmail.com");
            customersCustomList.Add(customer2);
            // customersList.AddRange(new List<CustomerRegistration> { customer1, customer2 });

            ProductDetails product1 = new ProductDetails("Sugar", 20, 40);
            ProductCustomList.Add(product1);
            ProductDetails product2 = new ProductDetails("Rice", 100, 50);
            ProductCustomList.Add(product2);
            ProductDetails product3 = new ProductDetails("Milk", 10, 40);
            ProductCustomList.Add(product3);
            ProductDetails product4 = new ProductDetails("Coffee", 10, 10);
            ProductCustomList.Add(product4);
            ProductDetails product5 = new ProductDetails("Tea", 10, 10);
            ProductCustomList.Add(product5);
            ProductDetails product6 = new ProductDetails("Masala Powder", 10, 20);
            ProductCustomList.Add(product6);
            ProductDetails product7 = new ProductDetails("Salt", 10, 10);
            ProductCustomList.Add(product7);
            ProductDetails product8 = new ProductDetails("Turmeric Powder", 10, 25);
            ProductCustomList.Add(product8);
            ProductDetails product9 = new ProductDetails("Chilli Powder", 10, 20);
            ProductCustomList.Add(product9);
            ProductDetails product10 = new ProductDetails("Groundnut Oil", 10, 140);
            ProductCustomList.Add(product10);
            // ProductList.AddRange(new List<ProductDetails> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 });

            BookingDetails booking1 = new BookingDetails("CID1001", 220, new DateTime(2022, 07, 26), BookingStatus.Booked);
            bookingCustomList.Add(booking1);
            BookingDetails booking2 = new BookingDetails("CID1002", 400, new DateTime(2022, 07, 26), BookingStatus.Booked);
            bookingCustomList.Add(booking2);
            BookingDetails booking3 = new BookingDetails("CID1001", 280, new DateTime(2022, 07, 26), BookingStatus.Cancelled);
            bookingCustomList.Add(booking3);
            BookingDetails booking4 = new BookingDetails("CID1002", 0, new DateTime(2022, 07, 26), BookingStatus.Initiated);
            bookingCustomList.Add(booking4);
            // BookingList.AddRange(new List<BookingDetails> { booking1, booking2, booking3, booking4 });

            OrderDetails order1 = new OrderDetails("BID3001", "PID2001", 2, 80);
            globelOrderCustomList.Add(order1);
            OrderDetails order2 = new OrderDetails("BID3001", "PID2002", 2, 100);
            globelOrderCustomList.Add(order2);
            OrderDetails order3 = new OrderDetails("BID3001", "PID2003", 1, 40);
            globelOrderCustomList.Add(order3);
            OrderDetails order4 = new OrderDetails("BID3002", "PID2001", 1, 40);
            globelOrderCustomList.Add(order4);
            OrderDetails order5 = new OrderDetails("BID3002", "PID2002", 4, 200);
            globelOrderCustomList.Add(order5);
            OrderDetails order6 = new OrderDetails("BID3002", "PID2010", 1, 140);
            globelOrderCustomList.Add(order6);
            OrderDetails order7 = new OrderDetails("BID3002", "PID2009", 1, 20);
            globelOrderCustomList.Add(order7);
            OrderDetails order8 = new OrderDetails("BID3003", "PID2002", 2, 100);
            globelOrderCustomList.Add(order8);
            OrderDetails order9 = new OrderDetails("BID3003", "PID2008", 4, 100);
            globelOrderCustomList.Add(order9);
            OrderDetails order10 = new OrderDetails("BID3003", "PID2001", 2, 80);
            globelOrderCustomList.Add(order10);
            // globelOrderList.AddRange(new List<OrderDetails> { order1, order2, order3, order4, order5, order6, order7, order8, order9, order10 });
        }
    }
}