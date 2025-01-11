using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Test";
            user.Age = 5;
            user.Address = "Ygn";
            Console.WriteLine(user.Name + user.Age + user.Address);

            User user2 = new User { Name = "Zaw", Age = 20};
            Console.WriteLine(user2.Name + user2.Age);

            User user3 = new User("Youn", 23);
            Console.WriteLine($"{user3.Name} - {user3.Age}");
        }
    }

    class User
    {
        public User()
        {
            
        }

        public User(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }
}
