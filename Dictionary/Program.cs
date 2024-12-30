using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> phone = new Dictionary<int, string>();
            phone.Add(1, "iPhone 15, 600$");
            phone.Add(2, "Samsung Galaxy S23, 800$");
            phone.Add(3, "Google Pixel 8, 700$");
            phone.Add(4, "OnePlus 11, 650$");
            phone.Add(5, "Xiaomi Mi 13, 550$");
            phone.Add(6, "Sony Xperia 5 V, 750$");
            Console.WriteLine("Enter the phone number (1-6): ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine(phone[1]);
                    break;
                case 2:
                    Console.WriteLine(phone[2]);
                    break;
                case 3:
                    Console.WriteLine(phone[3]);
                    break;
                case 4:
                    Console.WriteLine(phone[4]);
                    break;
                case 5:
                    Console.WriteLine(phone[5]);
                    break;
                case 6:
                    Console.WriteLine(phone[6]);
                    break;
                default:
                    Console.WriteLine("Invalid phone number.");
                    break;
            }


        }
    }
}
