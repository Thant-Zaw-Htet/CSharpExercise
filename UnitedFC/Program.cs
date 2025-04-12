using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedFC
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Player
    {
        protected int Code { get; set; }
        protected string Name { get; set; }
        protected string Address {  get; set; }
        protected int ShirtNumber { get; set; }
        protected string Position { get; set; }
        protected decimal Salary { get; set; }

        public Player()
        {
            
        }
        public Player(int code, string name, string address, int shirtNumber, string position, decimal salary)
        {
            Code = code;
            Name = name;
            Address = address;
            ShirtNumber = shirtNumber;
            Position = position;
            Salary = salary;
        }

    }

    class Coach : Player
    {
        double YearOfExperience { get; set; }

        public Coach()
        {
            
        }
        public Coach(int code, string name, string address, string position, decimal salary, double yearOfExperience)
        {
            Code = code;
            Name = name;
            Address = address;
            Position = position;
            Salary = salary;
            YearOfExperience = yearOfExperience;

        }
    }

    

}
