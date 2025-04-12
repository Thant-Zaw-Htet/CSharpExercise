using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedConsole;

        public class Player
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public int ShirtNumber { get; set; }
            public string Position { get; set; }
            public decimal Salary { get; set; }

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

        public class Coach : Player
        {
            public double YearOfExperience { get; set; }

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
    

