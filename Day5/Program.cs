using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int , string> month = new Dictionary<int , string>();
            month.Add(1, "January");
            month.Add(2, "February");
            month.Add(3, "March");
            month.Add(4, "April");
            month.Add(5, "May");
            month.Add(6, "June");
            month.Add(7, "July");
            month.Add(8, "August");
            month.Add(9, "September");
            month.Add(10, "October");
            month.Add(11, "November");
            month.Add(12, "December");

            foreach(var months in month)
            {
                Console.WriteLine($"{months.Key} = {months.Value}");
            }
       
        }
    }
}
