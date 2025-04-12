using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Join
            // Inner, Left, Right, Cross, Full

            var first = new string[] { "McDonal", "Buger Kings", "Pizza Hut", "Pizza Maru", };
            var second = new string[] { "USA", "China", "Korea", "Thailand", "Buger Kings", "Pizza Hut" };

            // Inner Join
            /*var resut = from f in first
                        join  s in second
                        on f equals s
                        select new {f, s };

            var result2 = first.Join(second,
                          f => f,
                          s => s,
                          (f, s) => new { f, s }
                          );

            foreach (var t in result2)
            {
                Console.WriteLine(t.f + " | " + t.s );*/


            // Left Join
            //var result = from f in first
            //             join s in second
            //             on f equals s into temp
            //             from t in temp.DefaultIfEmpty()
            //             select new { f, t };

            //foreach (var t in result)
            //{
            //    Console.WriteLine(t);   
            //}
            
            // Right Join
            var resultRight = from s in second
                              join f in first
                              on s equals f into temp
                              from t in temp.DefaultIfEmpty()
                              select new {s , t};

            foreach (var t in resultRight)
            {
                Console.WriteLine(t);
            }

        }

    }
}
