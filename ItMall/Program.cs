 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ItMall
{
    internal class Program
    {
        static List<string> itemList = new List<string>();
        static List<decimal> priceList = new List<decimal>();
        static Dictionary<string, string> userLogin = new Dictionary<string, string>();
    
        
        static void Main()
        {
            Console.WriteLine("1: Register \n2: Continue with Google \n3: Login");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    User user = new User();
                    Console.WriteLine("Enter UserName: ");                   
                    user.Name = Console.ReadLine();
                    Console.WriteLine("Enter Email: ");
                    user.Email = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    user.Password = Console.ReadLine();
                    
                    var returnobj = user.Register(user.Name, user.Email,user.Password);
                    if (returnobj != null)
                    {
                        Console.WriteLine($"{returnobj.Id}| {returnobj.Name} was created successfully.");
                        userLogin.Add(user.Name, user.Password);  
                        Main();
                    }

                    break;
                case 3:
                    while (true)
                    {
                        Console.WriteLine("Enter 'exit' to go back to Login Menu: ");
                        Console.WriteLine("Enter Username: ");
                        string userName = Console.ReadLine();
                      
                        if (userName.Equals("exit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Exiting the program...");
                            Main();
                        }

                        Console.WriteLine("Enter Password: ");
                        string password = Console.ReadLine();
                        if (userLogin.ContainsKey(userName) && userLogin.TryGetValue(userName, out string storedPassword) && storedPassword == password)
                        {
                            Console.WriteLine("Login successful.");
                            Menu();
                        }
                        else
                        {
                            Console.WriteLine("Invalid username or password.");

                        }
                        
                    }
                  

                default:
                    Console.WriteLine("Invalid option.");
                    break;



            }

            
        }
        private static void Menu()
        {
            Console.WriteLine("Welcome form IT-Mall \n(1) Start Shopping \n(2) Check Out \n(3) Exit");
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Welcome");
                    startShop();
                    break;
                case 2:
                    Console.WriteLine("Check out your items");
                    checkOut();
                    break;
                case 3:
                    Console.WriteLine("Bye");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        private static void startShop()
        {
            Console.WriteLine("Enter item you want to buy");
                Console.WriteLine("Enter '0' to go main menu");
                Dictionary<int, string> items = new Dictionary<int, string>();
                items.Add(1, "Laptop");
                items.Add(2, "Mobile Phone");
                Console.WriteLine();
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Key} {item.Value}");
                }
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                    START:
                        Console.WriteLine("Laptop");
                        Console.WriteLine("Enter '0' to go main menu");
                        Dictionary<int, string> laptops = new Dictionary<int, string>();
                        laptops.Add(1, "Lenovo Thinkpad X1 Carbon, 1200$");
                        laptops.Add(2, "Dell XPS 13, 1300$");
                        laptops.Add(3, "HP Spectre x360, 1400$");
                        laptops.Add(4, "Apple MacBook Pro, 2000$");
                        laptops.Add(5, "Asus ZenBook 14, 1100$");
                        laptops.Add(6, "Acer Swift 3, 900$");

                        foreach (var laptopItems in laptops)
                        {
                            Console.WriteLine($"{laptopItems.Key} {laptopItems.Value}");
                        }
                        int laptopChoice = int.Parse(Console.ReadLine());
                        decimal price;
                        switch (laptopChoice)
                        {

                            case 0:
                                startShop();
                                break;
                            case 1:
                                Console.WriteLine(laptops[1]);
                                itemList.Add(laptops[laptopChoice]);
                                price = ExtractPrice(laptops[laptopChoice]);
                                priceList.Add(price);
                                break;
                            case 2:
                                Console.WriteLine(laptops[2]);
                                itemList.Add(laptops[laptopChoice]);
                                price = ExtractPrice(laptops[laptopChoice]);
                                priceList.Add(price);
                                break;
                            case 3:
                                Console.WriteLine(laptops[3]);
                                itemList.Add(laptops[laptopChoice]);
                                price = ExtractPrice(laptops[laptopChoice]);
                                priceList.Add(price);
                                break;
                            case 4:
                                Console.WriteLine(laptops[4]);
                                itemList.Add(laptops[laptopChoice]);
                                price = ExtractPrice(laptops[laptopChoice]);
                                priceList.Add(price);
                                break;
                            case 5:
                                Console.WriteLine(laptops[5]);
                                itemList.Add(laptops[laptopChoice]);
                                price = ExtractPrice(laptops[laptopChoice]);
                                priceList.Add(price);
                                break;
                            case 6:
                                Console.WriteLine(laptops[6]);
                                itemList.Add(laptops[laptopChoice]);
                                price = ExtractPrice(laptops[laptopChoice]);
                                priceList.Add(price);
                                break;
                            default:
                                Console.WriteLine("Invalid choice");
                                break;

                        }
                        Console.WriteLine();
                        goto START;

                    case 2:
                    STARTSECOND:
                        Console.WriteLine("Mobile Phone");
                        Console.WriteLine("Enter '0' to go main menu");
                        Dictionary<int, string> phone = new Dictionary<int, string>();
                        phone.Add(1, "iPhone 15, 600$");
                        phone.Add(2, "Samsung Galaxy S23, 800$");
                        phone.Add(3, "Google Pixel 8, 700$");
                        phone.Add(4, "OnePlus 11, 650$");
                        phone.Add(5, "Xiaomi Mi 13, 550$");
                        phone.Add(6, "Sony Xperia 5 V, 750$");

                        foreach (var phoneItem in phone)
                        {
                            Console.WriteLine($"{phoneItem.Key} {phoneItem.Value}");
                        }
                        int phoneChoice = int.Parse(Console.ReadLine());
                        switch (phoneChoice)
                        {
                            case 0:
                                startShop();
                                break;
                            case 1:
                                Console.WriteLine(phone[1]);
                                itemList.Add(phone[phoneChoice]);
                                price = ExtractPrice(phone[phoneChoice]);
                                priceList.Add(price);
                                break;
                            case 2:
                                Console.WriteLine(phone[2]);
                                itemList.Add(phone[phoneChoice]);
                                price = ExtractPrice(phone[phoneChoice]);
                                priceList.Add(price);
                                break;
                            case 3:
                                Console.WriteLine(phone[3]);
                                itemList.Add(phone[phoneChoice]);
                                price = ExtractPrice(phone[phoneChoice]);
                                priceList.Add(price);
                                break;
                            case 4:
                                Console.WriteLine(phone[4]);
                                itemList.Add(phone[phoneChoice]);
                                price = ExtractPrice(phone[phoneChoice]);
                                priceList.Add(price);
                                break;
                            case 5:
                                Console.WriteLine(phone[5]);
                                itemList.Add(phone[phoneChoice]);
                                price = ExtractPrice(phone[phoneChoice]);
                                priceList.Add(price);
                                break;
                            case 6:
                                Console.WriteLine(phone[6]);
                                itemList.Add(phone[phoneChoice]);
                                price = ExtractPrice(phone[phoneChoice]);
                                priceList.Add(price);
                                break;
                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                        Console.WriteLine();
                        goto STARTSECOND;

                    case 0:
                        Main();
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
        private static decimal ExtractPrice(string itemDescription) 
        {
            string priceString = itemDescription.Split(',').Last().Replace("$", "").Trim();
            return decimal.Parse(priceString);
        }
        private static void checkOut()
        {
            foreach (var itemCheckout in itemList)
            {
                Console.WriteLine(itemCheckout);
            }
            decimal totalCost = priceList.Sum();
            Console.WriteLine();
            Console.WriteLine($"Are you sure to buy? \nTotal cost: {totalCost}$.Type 'Yes' for buy and 'No' for cancel");

            string itemBuy = Console.ReadLine();
            if (itemBuy.Equals("Yes"))
            {
                Console.WriteLine("Thanks for shopping with us!");
                Main();
            }
            else if (itemBuy.Equals("No"))
            {
                Console.WriteLine("Bye! See you soon.");
                Main();
            }
        }

    }

    class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        
        public User Register(string name, string email, string password)
        {
            User user = new User();
            Guid id = Guid.NewGuid();  
            user.Id = id;   
            user.Name = name;
            user.Email = email;
            user.Password = password;

            return user;
        }

        public User Register(string jToken)
        {
            return new User();
        }

    }
}
