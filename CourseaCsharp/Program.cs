using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseaCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your income: ");
            int income = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you resident: (Yes/No) ");
           
            string residentinput = Console.ReadLine();
            bool isResident = residentinput.ToLower() == "yes";

            double taxRate = 0;
            double tax;

            if (income < 50000)
            {
                if (isResident)
                {
                    taxRate = 0.10;
                }
                else
                {
                    taxRate = 0.15;
                }
            }
            else if (income >= 50000 && income <= 100000)
            {
                if (isResident)
                {
                    taxRate = 0.20;  // 20% tax for residents
                }
                else
                {
                    taxRate = 0.25;  // 25% tax for non-residents
                }
            }
            else
            {
                if (isResident)
                {
                    taxRate = 0.30;  // 30% tax for residents
                }
                else
                {
                    taxRate = 0.35;  // 35% tax for non-residents
                }
            }

            tax = income * taxRate;
            Console.WriteLine("The tax is: $" + tax);

        }
    }


}
