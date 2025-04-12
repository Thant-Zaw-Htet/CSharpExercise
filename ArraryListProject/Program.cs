using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraryListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList personList = new ArrayList();
            personList.Add("Sandeep");
            personList.Add("Raviendra");
            personList.Add("Shaijal");
            personList.Add("nafe");
            personList.Add("dec");
            Console.WriteLine("=====Original List======");
            for (int i = 0; i < personList.Count; i++)
            {
                string arrayItem = string.Format($"Name  is {personList[i]}");
                Console.WriteLine(arrayItem);
            }
            //remove first two item from person list using index
            personList.RemoveRange(0,4);
            Console.WriteLine("=====Modified List======");
            for (int i = 0; i < personList.Count; i++)
            {
                string arrayItem = string.Format($"Name  is {personList[i]}");
                Console.WriteLine(arrayItem);
            }
            Console.Read();
        }
    }
}
