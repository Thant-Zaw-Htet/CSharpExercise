using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int  Age { get; set; }
        }
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>();
            list.Add(new Person() { Name = "Mg Mg", Age = 18});
            list.Add(new Person() { Name = "Zaw Zaw", Age = 28});
            list.Add(new Person() { Name = "Mya Mya", Age = 38});
            list.Add(new Person() { Name = "U Ba", Age = 48});
            list.Add(new Person() { Name = "Aye Aye", Age = 14});
            list.Add(new Person() { Name = "Khine Khine", Age = 17});
            list.Add(new Person() { Name = "Thidar", Age = 25});
            list.Add(new Person() { Name = "Daw Moe", Age = 44});

            var listQuery = list.GroupBy(l => l.Age);
            foreach (var agelist in listQuery) 
            {
                Console.WriteLine("Age : " + agelist.Key);
                Console.WriteLine("*******");
                foreach (var person in agelist)
                {
                    Console.WriteLine(person.Name);
                }
                Console.WriteLine();
            }



            //List<int > list = new List<int>() { 1,2, 3, 4, 5, 6, 7, 8, 9 };

            //var grp = list.GroupBy(x => x % 2 != 0);

            //foreach (var gp in grp)
            //{
            //    foreach (var item in gp )
            //    {
            //        Console.WriteLine(item); 
            //    }
            //}
            //string[] countries = { "Myanmar", "Laos", "Singapore", "GreenLand",  "Cambodia", "Malaysia", "America" };
            //var list = countries.Where(x => x.Length > 5).ToList();
            //foreach (var country in list)
            //{
            //    Console.WriteLine(country);
            //}

            //Console.WriteLine();

            //var list2 = (from x in countries
            //            where x.Length <=5 
            //            select x).ToList();

            //foreach (var country in list2) { 
            //    Console.WriteLine(country);
            //}

            //var Nums = new int[] { 3, 2, 10, 23, 34, 54 };

            //var multipy = Nums.Select(x => x * 2);
            //var result4 = multipy.Where(x => x != 6);
            //var orderResult = result4.OrderBy(x => x);
            //foreach(var num in orderResult)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine();

            //var result = Nums.Select(x => x * 2).Where(x => x != 6).OrderBy(x => x);
            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}

            //Element
            //First, Last, Single
            //string[] countries = { "Myanmar", "Laos", "Singapore", "GreenLand", "Cambodia", "Malaysia", "America", "Temor"  };


            //var countriesList = countries.First();
            //Console.WriteLine(countriesList);

            //Console.WriteLine();
            //try
            //{
            //    var countryStart = countries.Where(x => x.StartsWith("z")).First();
            //    Console.WriteLine(countryStart);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Not Found");
            //}


            //int[] fnums = new int[] { 1, 2, 3, 4 , 6 };
            //int[] fnums2 = new int[] { 0, 1, 3, 5, 6 };

            //foreach(var res in fnums.Concat(fnums2))
            //{
            //    Console.WriteLine(res);
            //}

            //Console.WriteLine("____________");

            //foreach(var res in fnums.Except(fnums2))
            //{
            //    Console.WriteLine(res);
            //}

            //Join
            //Inner,Left, Right, Cross ,Full  

            //var city = new string[] { "Yangon", "Mandalay", "Taunggyi", "MayMyo" };
            //var food = new string[] { "Coffee", "HtoeMote", "Noddle", "MayMyo" };

            ////Inner Join
            //var innerJoin = from c in city
            //                join f in food
            //                on c equals f 
            //                select new { c, f };

            //var innerJoin2 = city.Join(food,
            //                 c=>c,
            //                 f=>f,
            //                 (c, f) => new { c, f });

            //foreach (var result in innerJoin) { 
            //    Console.WriteLine(result.c + " | " + result.f);
            //}

            //var rightJoin = from f in food
            //                join c in city
            //                on f equals c into temp
            //                from t in temp.DefaultIfEmpty()
            //                select new { Food = f, City = t };

            //foreach(var result in rightJoin)
            //{
            //    Console.WriteLine(result.Food + " | " + result.City);
            //}

            //Cross Join
            //var cresult =from c in city
            //             from f in food
            //             where c != f
            //             select new { c, f };
            //foreach(var result in cresult)
            //{
            //    Console.WriteLine(result);
            //}


            //var leftJoin = from c in city
            //               join f in food
            //               on c equals f into temp
            //               from t in temp.DefaultIfEmpty()
            //               select new { City = c , Food = t };
            //foreach (var result in leftJoin) {
            //    Console.WriteLine(result.City + " | " + result.Food);
            
            //}




                      



        }
    }
}
