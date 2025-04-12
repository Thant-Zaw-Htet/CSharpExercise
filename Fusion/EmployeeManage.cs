using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusion
{
    public interface EmployeeManage
    {
        void GetAllEmployee(EmployeeModel employee);
        //void GetEmployeeById(int id);
        void AddEmployee();

    }
}
