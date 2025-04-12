using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3,12, 2, 33, 14, 5, 26, 7, 8, 9, 10, 11, 22, 23, 24, 25, 65, 23 };
            var num = arr.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
             
 
            foreach (var i in num) 
            { 
                   Console.WriteLine(i);
            }



            // LINQ Query
            // Syntax ( Fluent , Query )
            /*string[] countries = { "Myanmar", "Thailand", "Singpore", "Laos", "Cambodia", "Malaysia" };
            var list = countries.Where(c => c.Length > 7).ToList();//Fluent

            var list2 = (from c in countries
                        where c.Length > 7
                        select c).ToList();// Query 


*/

            //ArrayList array = new ArrayList();
            //array.Add(1);
            //array.Add("Zaw");
            //array.Add(2);


            //var arryLing = array.OfType<int>().Where(x => x > 0);
            //foreach (var x in arryLing)
            //{
            //    Console.WriteLine(x);
            //}

            /*var Nums = new int[] { 5, 22, 13, 54, 75, 66, 22};

            //Method Chaining
            var multipleNum = Nums.Select(n => n * 2);
            var filter = multipleNum.Where(n => n != 4);
            var orderBy = filter.OrderBy(n => n);

            // Extension Method
            var oneseintance = Nums.Select(n => n * 2).Where(n => n != 4).OrderBy(n => n);
            //foreach (var num in oneseintance)
            //{
            //    Console.WriteLine(num);
            //}

            // Element
            // First, Last, Single
            string[] countries = { "Myanmar", "Thailand", "Singpore", "Laos", "China", "Malaysia" ,"America" ,"Cambodia", "NewZeland", "Netherland" };

            var countryFirst = countries.First();

            var countryElement = countries.Where(c => c.ToUpper().Contains("L"));

            var countryWithM = countries.Where(c => c.ToUpper().Contains("C")).FirstOrDefault();

            //Console.WriteLine(countryWithM);
            Console.WriteLine(new string[] {"a","c"}.Single(s=> s.Equals("a")));*/

            //int[] numbers = { 1, 2, 3, 6, 8, 10 };
            //var filterEven = numbers.Where(n => n % 2 == 0);
            //var filterFive = numbers.Where(n => n > 5);
            //var oddNum = numbers.Where(n => n % 2 != 0).Sum();
            //var last = numbers.LastOrDefault();
            //var first = numbers.FirstOrDefault();
            //Console.WriteLine(last + first);
            //foreach (var n in oddNum)
            //{
            //    Console.WriteLine(n);
            //}


            //var Num = new int[] { 2, 4, 10, 3, 6, 18, 22, 15, 13, 23, 67, 45, 88, 100, 102, 140 };
            //var mulitNum = Num.Where(n => n % 2 == 0);
            ////var mulitNum = Num.Select(x  => x % 2 == 0);

            //foreach (var n in mulitNum)
            //{
            //    Console.WriteLine(n);
            //}

            //string[] countries = { "Myanmar", "Thailand", "Singpore", "Laos", "China", "Malaysia", "America", "Cambodia", "NewZeland", "Netherland" };

            //var countryList = countries.Where(c => c.StartsWith("C")).OrderBy(c=>c).First();
            //foreach (var country in countryList)
            //{
            //    Console.Write(country);
            //}

            //int[] fums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //int[] sums = {1, 2, 3, 4, 12,5, 13, 14, 15};

            //foreach (int i in fums.Intersect(sums))
            //{
            //    Console.WriteLine(i);   
            //}

        }
    }
}
