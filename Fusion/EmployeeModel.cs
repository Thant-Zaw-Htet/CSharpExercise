using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusion
{
    public class EmployeeModel
    {
        public Guid EmployeeID {  get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode {  get; set; }
        public string Position { get; set; }
        public string Gender {  get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; }= DateTime.Now;        
        public bool ActiveFlag { get; set; }
        public EmployeeModel()
        {
            
        }

        public EmployeeModel(Guid employeeID, string employeeName, string employeeCode, string position, string gender, int age, string address, decimal salary, DateTime createDate, bool activeFlag)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            EmployeeCode = employeeCode;
            Position = position;
            Gender = gender;
            Age = age;
            Address = address;
            Salary = salary;
            CreateDate = createDate;
            ActiveFlag = activeFlag;
        }
        public EmployeeModel(Guid employeeID, string employeeName, string employeeCode, string position, string gender, int age, string address, decimal salary, DateTime createDate, DateTime updateDate, bool activeFlag)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            EmployeeCode = employeeCode;
            Position = position;
            Gender = gender;
            Age = age;
            Address = address;
            Salary = salary;
            CreateDate = createDate;
            UpdateDate = updateDate;
            ActiveFlag = activeFlag;
        }
    }
}
