using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ArrayList array = new ArrayList();
            //array.Add(1);
            //array.Add(2);
            //array.Add(3);
            //array.Add("Hello");
            //array.Add("Morning");

            //foreach (var i in array)
            //{
            //    if(i.GetType() == typeof(int))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            int[] arr = { 1, 2, 5, 234, 45363, 232737, 4635, 23736, 34382732, 343374373 };

            int biggest = arr[0]; 

            foreach (int i in arr)
            {
                if (i > biggest)
                {
                    biggest = i; 
                }
            }

            Console.WriteLine($"The biggest number in the array is: {biggest}");


            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //if (arr.Length > 0) 
            //{ 

            //}

            //for (int i = arr.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //   int num = 1;

            //START: if (num <= 10) 
            //    {

            //        Console.WriteLine(num++);

            //    }goto START;

            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //for (int i = num.Length-1 ; i >= 0; i--) 
            //{
            //    Console.WriteLine(num[i]);
            //}
            // int i = num.Length;
            //START: if(i >= 0 )
            // {
            //     Console.WriteLine(i--);
            // }goto START;

            //int[] numArr = { 21, 41, 3, 10, 23, 24, 45, 67, 34, 56, 34, 78, 65, 79, 89 };

            //int minNum = numArr[0];//3
            //int maxNum = numArr[0]; //41


            //for (int i = 1; i < numArr.Length; i++)
            //{
            //    if (numArr[i] < minNum)
            //    {
            //        minNum = numArr[i];
            //    }
            //    if (numArr[i] > maxNum)
            //    {
            //        maxNum = numArr[i];
            //    }
            //}

            //Console.WriteLine($"Minimum number: {minNum}");
            //Console.WriteLine($"Maximum number: {maxNum}");

            //int[] numbers = new int[10];

            //for (int i = 0; i <= numbers.Length; i++)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Enter number {i + 1 }:");
            //}

        }
    }
}
