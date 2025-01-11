using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayDelegate
{
    internal class Program
    {
        delegate void ShowMessage(string message);
        static void Main(string[] args)
        {
        }
        
        static void ShowName(string name) 
        {
            Console.WriteLine($"Welcome to {name}");
        }
    }
}
