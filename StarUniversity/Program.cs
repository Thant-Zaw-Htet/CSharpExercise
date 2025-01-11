using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarUniversity
{
    public class Program
    {
        static StudentData studentData = new StudentData();
     
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome form Star University  \nChoice (1) for Register Student \nChoice (2) for TotalStudent");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        studentData.Register();
                        break;
                    case 2:
                        studentData.DisplayStudents();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;

                }
            }               
        }
    }

    public class StudentData
    {
        static List<Students> studentDataList = new List<Students>();   
        public void Register()
        {
            while (true)
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Age: ");
                string ageInput = Console.ReadLine();
                Console.Write("Enter Gender: ");
                string gender = Console.ReadLine();

                if (string.IsNullOrEmpty(name) || !int.TryParse(ageInput, out int age) || string.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Please fill all data properly.");
                }
                else
                {
                    Students students = new Students
                    {
                        Id = Guid.NewGuid(),
                        Name = name,
                        Age = age,
                        Gender = gender
                    };
                    studentDataList.Add(students);
               
                    Console.WriteLine("Student data successfully recorded.");
                    break;
                }
            }
        }  

        public void DisplayStudents()
        {
            StudentData studentData = new StudentData();
            Console.WriteLine($"Total Students {studentDataList.Count}");

            if (studentDataList.Count <= 0) 
            {
                Console.WriteLine("No Student Register: ");
            }
            else
            {
                foreach (var student in studentDataList) 
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}");
                }
            }                        
        }
    }
}
