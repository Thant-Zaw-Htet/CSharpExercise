using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            double doubleNum = 1.23;
            int intNum = (int)doubleNum;

            Console.WriteLine(intNum);


            byte b = 10;
            int i = b;
            Console.WriteLine(i);
            //Console.WriteLine("Enter your nationality: ");
            //string nat = Console.ReadLine();

            //Console.WriteLine("Enter your age: ");

            //int age = Convert.ToInt32(Console.ReadLine());

            //if (nat.Equals("Myanmar") && age == 18)
            //{
            //    Console.WriteLine("You can vote.");
            //}
            //else
            //{
            //    Console.WriteLine("You can't vote.");
            //}

            //Console.WriteLine("Enter your mark: ");
            //int mark = int.Parse(Console.ReadLine());

            //if (mark >= 40 && mark <= 79)
            //{
            //    Console.WriteLine("You pass exam");
            //}
            //else if (mark > 79)
            //{
            //    Console.WriteLine("You pass exam with D");
            //}
            //else 
            //{
            //    Console.WriteLine("You failed");
            //}


            //Console.WriteLine("Enter a card number: ");
            //int cardNumber = int.Parse(Console.ReadLine());
            //switch (cardNumber)
            //{
            //    case 11:
            //        Console.WriteLine("Jack");break;
            //    case 12:
            //        Console.WriteLine("Queen"); break;
            //    case 13:
            //        Console.WriteLine("King");break;
            //    default:
            //        Console.WriteLine("Plain Card");break;
            //}

            //int.Parse(string s): Purpose: Converts a "string" representation of a number into an integer. Null Handling: Throws an exception (ArgumentNullException) if the input is null.

            //Convert.ToInt32(object value): Purpose: Converts various types (including strings) to an intege Null Handling: Returns 0 if the input is null (no exception)
            //int a = 10;
            //int b = 0;
            //int result = a / b;


            //int first = 1;
            //string one = "1";
            //bool myTrue = false;
            //decimal myDecimal = 7.23m;
            //long myLong = 70;

            //Console.WriteLine(int.Parse(one));
            //Console.WriteLine(Convert.ToInt32(first));



        }
    }
}
