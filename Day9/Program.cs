using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Program
    {

        class Asset
        {
            public string Name;
        }

        class Stock : Asset
        {
            public int SharesOwned;
        }
        class Cash : Asset
        {
            public int Dollar;
        }

        static void Main(string[] args)
        {
            //Upcast, Downcast, Mulit-Cast


            //Stock stock = new Stock();
            //Asset asset = stock;//Upcast

            //stock = (Stock)asset;//Downcast


            //Console.WriteLine(asset==stock);
            //Asset asset = new Asset();
            //asset.Name = "test";

            //Stock stock = new Stock();
            //stock.Name = "test";
            //stock.SharesOwned = 1;

            //LINQ
            // Conversion(ToList(), ToDictonary(), ToArray())
            // Filtering(Where)
            // Ordering (OrderBy, OrderByDescending)
            // Joining (Join)
            // Element (First,FirstOrDefault,FirstAsync,FistOrDefaultAsync,Last,Single)
            // Set (Intersect,Union,Concat)
            // Aggregation (MAx,Min,Avg,Count)
            //// Grouping (GroupBy)
            //string[] countries = { "Myanmar", "Thailand", "Singpore", "Laos", "Cambodia", "Malaysia" };

            //var ord = countries.OrderBy(x => x);
            //foreach (var country in ord)
            //{
            //    Console.WriteLine(country);
            //}

            //var ordL = countries.Where(x => x.ToUpper().Contains("L"));
            //foreach (var country in ordL)
            //{
            //    Console.WriteLine(country);
            //}

        }
    }
}
