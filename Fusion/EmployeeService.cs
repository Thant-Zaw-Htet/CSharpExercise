using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusion
{
    public class EmployeeService : EmployeeManage
    {
        List<EmployeeModel> employees = new List<EmployeeModel>();
        public void GetAllEmployee(EmployeeModel employee)
        {

        }

        public void AddEmployee()
        {
            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Position: ");
            string position = Console.ReadLine();
            Console.WriteLine("Enter Employee Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            string salary = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender: ");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter Employee Address: ");
            string address = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(position) || !int.TryParse(age, out int ageInput) || !decimal.TryParse(salary, out decimal salaryInput) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(address))
            {
                Console.WriteLine("Please add valid data!");
            }
            else
            {
                //Guid id = Guid.NewGuid();
                //DateTime createDate = DateTime.Now;
                //EmployeeModel employee = new EmployeeModel(id,name,code, position, age, salary,gender,address,createDate,);
                //{
                //    EmployeeID = Guid.NewGuid(),
                //    EmployeeCode = "",
                //    EmployeeName = name,
                //    Position = position,
                    



                //} ;
            }

        }
    }
}
