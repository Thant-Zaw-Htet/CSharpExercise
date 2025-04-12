using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Program
    {
        readonly string name = "Zaw Zaw";
        static void Main(string[] args)
        {

            //int[] arr = { 1, 28, 48, 45, 56, 40, 49 };
            //var largestNum = arr.Where(x => x > arr.Length);
            //foreach (var i in largestNum)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] arr = { 1, 28, 48, 45, 56, 40, 49 };
            //int largest = 0;
            //foreach (int i in arr)
            //{
            //    if (i > largest)
            //    {
            //        largest = i;
            //    }
            //}
            //Console.WriteLine("The largest number is: " + largest);

            //int[] arr1 = { 1, 28, 48, 45, 56, 40, 49 };
            //int sumArr1 = 0;
            //foreach (int i in arr1)
            //{
            //    sumArr1 += i;

            //}

            //Console.WriteLine("Total" + sumArr1);

            //int[] arr = { 2, 4, 7, 34, 82, 22, 44, 23 };
            //int largest = arr[0];
            //foreach (int i in arr)
            //{
            //    if (i > largest)
            //    {
            //        largest = i;
            //    }
            //}
            //Console.WriteLine(largest);

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;
            //foreach (int i in arr) {
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            string text = "Hello World";
            int vowelCount = 0;


            // Loop through each character in the string
            foreach (char c in text.ToLower())
            {
                // Check if the character is a vowel
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
            }


            // Output the number of vowels
            Console.WriteLine("The number of vowels is: " + vowelCount);

        }


            //Console.WriteLine("Enter your age: ");
            //string age = Console.ReadLine();
            //if (int.TryParse(age, out int ageInput))
            //{
            //    Console.WriteLine("Success Add");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input");
            //}
           
        //    int a = 0;
        //START:
        //    if (a <= 10) {
        //        Console.WriteLine(a);
        //        a += 1;
        //        goto START;
        //    }

            //int b = 0;
            //while (b <= 10) {
            //    Console.WriteLine(b);
            //    b += 1;
            //}




            //Console.WriteLine("Enter this year: ");
            //int year = int.Parse(Console.ReadLine());
            //if (year.ToString())
            //{
            //}


            //Dictionary<int , string> month = new Dictionary<int , string>();
            //month.Add(1, "January");
            //month.Add(2, "February");
            //month.Add(3, "March");
            //month.Add(4, "April");
            //month.Add(5, "May");
            //month.Add(6, "June");
            //month.Add(7, "July");
            //month.Add(8, "August");
            //month.Add(9, "September");
            //month.Add(10, "October");
            //month.Add(11, "November");
            //month.Add(12, "December");

            //foreach(var months in month)
            //{
            //    Console.WriteLine($"{months.Key} = {months.Value}");
            //}

        }
    }

