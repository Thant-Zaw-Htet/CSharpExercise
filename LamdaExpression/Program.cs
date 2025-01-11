using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    internal class Program
    {
        delegate void showMessage(string message);
        static void Main(string[] args)
        {
            showMessage sm = ShowName;
            sm("New York");

            Func<string, string> getString = x => "Welcome to " + x;
            Console.WriteLine(getString("Canada"));

            Func<int> getInt = () => 1;
            Console.WriteLine(getInt());

            Func<string, string, int> getStringLength = (s1,s2) => s1.Length + s2.Length;
            Console.WriteLine(getStringLength("United", "States"));

            Func<string,string> getbyName = x => "Product is " + x;
            Console.WriteLine(getbyName("Milk"));


            Func<string, string, int, int, string> getTwin = (n1, n2, a1, a2) => $"{n1} is {a1} years old and {n2} is {a2} years old";
            Console.WriteLine(getTwin("Youn Youn","Zaw Zaw",28 ,27));


            Func<int, int , int > getPlus = (n1,n2) => n1 + n2;
            Console.WriteLine(getPlus(1,2));

        }
        static void ShowName(string name)
        {
            Console.WriteLine("Welcome from " + name);
        }
    }

    
}
